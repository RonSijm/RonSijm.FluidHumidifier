using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using RonSijm.FluidHumidifier.Factories.EC2;
using RonSijm.FluidHumidifier.Features;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.VPCInfrastructureStack;

public class VPCInfrastructureStackComposer : BaseStackComposer<VPCInfrastructureConfig>
{
    public override StackCreateResult Create(VPCInfrastructureConfig config)
    {
        var result = new StackCreateResult();

        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory
            .AddStack("VPC Infrastructure");

        var vpc = stack.WithVPC($"{ResourceConfigSettings.ConceptName} Infrastructure", vpc =>
        {
            vpc.CidrBlock = "10.0.0.0/16";
            vpc.EnableDnsHostnames = true;
            vpc.EnableDnsSupport = true;
        });


        AddIPSecGateWay(stack, vpc);

        var networkACL = CreateNetworkACL(stack, vpc);

        var internetGateWay = stack.WithInternetGateway($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-internet-gw");

        var gatewayAttachment = stack.WithVPCGatewayAttachment("VPCGateway-Attachment", x =>
        {
            x.InternetGatewayId = internetGateWay.FFnREF();
            x.VpcId = vpc.FFnREF();
        });

        /////// Subnets

        var pubFacingRouteTable = stack.WithRouteTable($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-pub-rt", routeTable =>
        {
            routeTable.VpcId = vpc.FFnREF();
        });
        
        stack.WithEC2Route("internet-route", x =>
        {
            x.GatewayId = internetGateWay.FFnREF();
            x.RouteTableId = pubFacingRouteTable.FFnREF();
            x.DestinationCidrBlock = "0.0.0.0/0";
        });

        var localRouteTable = stack.WithRouteTable($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-local-rt", routeTable =>
        {
            routeTable.VpcId = vpc.FFnREF();
        });

        var beanstalk = stack.WithRouteTable($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-beanstalk-rt", routeTable =>
        {
            routeTable.VpcId = vpc.FFnREF();
        });

        stack.WithEC2Route("docker-route", x =>
        {
            x.GatewayId = internetGateWay.FFnREF();
            x.RouteTableId = beanstalk.FFnREF();
            x.DestinationCidrBlock = "0.0.0.0/0";
        });

        stack.WithVPCEndpoint("S3Endpoint", s3Config =>
        {
            s3Config.ServiceName = $"com.amazonaws.{Environment.Region}.s3";
            s3Config.VpcId = vpc.FFnREF();
            s3Config.VpcEndpointType = "Gateway";
            s3Config.RouteTableIds = beanstalk.FFnREFList();
        });

        var natEIPFactory = stack.WithEIP($"{ResourceConfigSettings.ConceptName}-NAT-EIP");

        var natGateway = stack.WithNatGateway($"{ResourceConfigSettings.ConceptName}-NAT", x =>
        {
            x.SubnetId = Fn.Ref($"{ResourceConfigSettings.BackendName}SubnetAZA");
            x.AllocationId = natEIPFactory.FFnGetAtt("AllocationId");
        });

        stack.WithEC2Route("local-nat-route", x =>
        {
            x.NatGatewayId = natGateway.FFnREF();
            x.RouteTableId = localRouteTable.FFnREF();
            x.DestinationCidrBlock = "0.0.0.0/0";
        });

        var networkInterfaceFactory = stack.WithNetworkInterface($"{ResourceConfigSettings.ConceptName}-NI", x =>
        {
            x.SubnetId = Fn.Ref($"{ResourceConfigSettings.BackendName}SubnetAZA");
        });

        var nweipFactory = stack.WithEIP($"{ResourceConfigSettings.ConceptName}-NW-EIP");

        var eipAssFactory = stack.WithEIPAssociation($"{ResourceConfigSettings.ConceptName}-EIPAss", x =>
        {
            x.AllocationId = nweipFactory.FFnGetAtt("AllocationId");
            x.NetworkInterfaceId = networkInterfaceFactory.FFnREF();
        });

        vpc.WithSubnets(ResourceConfigSettings.LoadBalancerName, subnet =>
        {
            subnet.RegionName = Environment.Region;
            subnet.CidrBlock = i => $"10.0.{i}.0/24";
            subnet.StartAt = 0;
            subnet.RouteTable = pubFacingRouteTable;
            subnet.NetworkACL = networkACL;
            subnet.Export = true;
        });

        var databaseGroupAndSubnets = vpc.WithRDSDBSubnetGroupAndSubnets(ResourceConfigSettings.DatabaseGroupName, subnet =>
        {
            subnet.RegionName = Environment.Region;
            subnet.CidrBlock = i => $"10.0.{i}.0/24";
            subnet.StartAt = 3;
            subnet.RouteTable = localRouteTable;
            subnet.NetworkACL = networkACL;
        });

        vpc.WithSubnets(ResourceConfigSettings.BackendName, subnet =>
        {
            subnet.RegionName = Environment.Region;
            subnet.CidrBlock = i => $"10.0.{i}.0/24";
            subnet.StartAt = 9;
            subnet.Export = true;
            subnet.RouteTable = beanstalk;
            subnet.NetworkACL = networkACL;
        });

        /////// Security Groups

        //var redisSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.RedisName);
        var loadBalancerSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.LoadBalancerName);
        var backendSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.BackendName);
        var rdsSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.DatabaseGroupName);

        // Configure Security Groups

        loadBalancerSecurityGroup.AcceptTraffic("Http Inbound", 80, 80); // TODO: Do we need http inbound, or just https?
        loadBalancerSecurityGroup.AcceptTraffic("Https Inbound", 443, 443);

        stack.CanTalkTo(loadBalancerSecurityGroup, ResourceConfigSettings.ServiceName, backendSecurityGroup, PortConfig.PumaPort);
        stack.CanTalkTo(backendSecurityGroup, ResourceConfigSettings.DatabaseName, rdsSecurityGroup, PortConfig.PostgreSQLDefaultPort);
        //stack.CanTalkTo(dockerSecurityGroup, ResourceConfigSettings.RedisName, redisSecurityGroup, PortConfig.RedisDefaultPort);

        result.Export.Add(databaseGroupAndSubnets);
        result.Export.Add(loadBalancerSecurityGroup.T2);
        result.Export.Add(rdsSecurityGroup.T2);
        result.Export.Add(backendSecurityGroup.T2);
        result.Export.Add(vpc);

        var stackResult = environmentFactory.Build().First();

        result.Stack = stackResult;

        return result;
    }

    private NetworkAclFactory CreateNetworkACL(StackFactory stack, VPCFactory vpc)
    {
        var networkACL = stack.WithNetworkAcl($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-network-acl", acl =>
        {
            acl.VpcId = vpc.FFnREF();
        });

        var networkACLEntryEgress = stack.WithNetworkAclEntry($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-network-acl-in-et", acl =>
        {
            acl.CidrBlock = "0.0.0.0/0";
            acl.Egress = true;
            acl.NetworkAclId = networkACL.FFnREF();
            acl.RuleNumber = 100;
            acl.Protocol = -1;
            acl.RuleAction = "allow";
        });

        var networkACLEntry = stack.WithNetworkAclEntry($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-network-acl-et", acl =>
        {
            acl.CidrBlock = "0.0.0.0/0";
            acl.NetworkAclId = networkACL.FFnREF();
            acl.RuleNumber = 100;
            acl.Protocol = -1;
            acl.RuleAction = "allow";
        });

        return networkACL;
    }

    private static void AddIPSecGateWay(StackFactory stack, VPCFactory vpc)
    {
        var vpcGateway = stack.WithVPNGateway(ResourceConfigSettings.ConceptName + "-VPNGW", gateway =>
        {
            gateway.Type = "ipsec.1";
        });


        var vpcGatewayAttachment = stack.WithVPCGatewayAttachment("VPCGateway", x =>
        {
            x.VpnGatewayId = vpcGateway.FFnREF();
            x.VpcId = vpc.FFnREF();
        });
    }
}