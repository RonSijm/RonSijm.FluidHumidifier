using RonSijm.FluidHumidifier.Factories.EC2;
using RonSijm.FluidHumidifier.Features;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.VPCInfrastructureStack;

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

        var dockerRouteTable = stack.WithRouteTable($"{Environment.EnvironmentName}-{ResourceConfigSettings.ConceptName}-docker-rt", routeTable =>
        {
            routeTable.VpcId = vpc.FFnREF();
        });

        stack.WithEC2Route("docker-route", x =>
        {
            x.GatewayId = internetGateWay.FFnREF();
            x.RouteTableId = dockerRouteTable.FFnREF();
            x.DestinationCidrBlock = "0.0.0.0/0";
        });

        stack.WithVPCEndpoint("S3Endpoint", s3Config =>
        {
            s3Config.ServiceName = $"com.amazonaws.{Environment.Region}.s3";
            s3Config.VpcId = vpc.FFnREF();
            s3Config.VpcEndpointType = "Gateway";
            s3Config.RouteTableIds = dockerRouteTable.FFnREFList();
        });

        stack.WithVPCEndpoint("ECRAPIEndpoint", s3Config =>
        {
            s3Config.ServiceName = $"com.amazonaws.{Environment.Region}.ecr.api";
            s3Config.VpcId = vpc.FFnREF();
            s3Config.VpcEndpointType = "Interface";
            s3Config.SubnetIds = new List<Union<string, BaseFunction>>
            {
                Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZA"),
                Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZB"),
                Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZC"),
            };

            s3Config.SecurityGroupIds = new List<Union<string, BaseFunction>>
            {
                Fn.Ref($"{ResourceConfigSettings.DockerName}SecurityGroup"),
            };
        });

        stack.WithVPCEndpoint("ECRDKREndpoint", s3Config =>
        {
            s3Config.ServiceName = $"com.amazonaws.{Environment.Region}.ecr.dkr";
            s3Config.VpcId = vpc.FFnREF();
            s3Config.VpcEndpointType = "Interface";
            s3Config.SubnetIds = new List<Union<string, BaseFunction>>
            {
                Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZA"),
                Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZB"),
                Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZC"),
            };

            s3Config.SecurityGroupIds = new List<Union<string, BaseFunction>>
            {
                Fn.Ref($"{ResourceConfigSettings.DockerName}SecurityGroup"),
            };
        });

        var natEIPFactory = stack.WithEIP($"{ResourceConfigSettings.ConceptName}-NAT-EIP");

        var natGateway = stack.WithNatGateway($"{ResourceConfigSettings.ConceptName}-NAT", x =>
        {
            x.SubnetId = Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZA");
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
            x.SubnetId = Fn.Ref($"{ResourceConfigSettings.DockerName}SubnetAZA");
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

        var elastiCacheSubnetGroupAndSubnets = vpc.WithElastiCacheSubnetGroupAndSubnets(ResourceConfigSettings.RedisName, subnet =>
        {
            subnet.RegionName = Environment.Region;
            subnet.CidrBlock = i => $"10.0.{i}.0/24";
            subnet.StartAt = 6;
            subnet.RouteTable = localRouteTable;
            subnet.NetworkACL = networkACL;
        });

        vpc.WithSubnets(ResourceConfigSettings.DockerName, subnet =>
        {
            subnet.RegionName = Environment.Region;
            subnet.CidrBlock = i => $"10.0.{i}.0/24";
            subnet.StartAt = 9;
            subnet.Export = true;
            subnet.RouteTable = dockerRouteTable;
            subnet.NetworkACL = networkACL;
        });

        /////// Security Groups

        var redisSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.RedisName);
        var loadBalancerSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.LoadBalancerName);
        var dockerSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.DockerName);
        var rdsSecurityGroup = vpc.WithSecurityGroup(ResourceConfigSettings.DatabaseGroupName);

        // Configure Security Groups

        loadBalancerSecurityGroup.AcceptTraffic("Http Inbound", 80, 80); // TODO: Do we need http inbound, or just https?
        loadBalancerSecurityGroup.AcceptTraffic("Https Inbound", 443, 443);

        stack.CanTalkTo(loadBalancerSecurityGroup, ResourceConfigSettings.ServiceName, dockerSecurityGroup, PortConfig.PumaPort);
        stack.CanTalkTo(dockerSecurityGroup, ResourceConfigSettings.DatabaseName, rdsSecurityGroup, PortConfig.PostgreSQLDefaultPort);
        stack.CanTalkTo(dockerSecurityGroup, ResourceConfigSettings.RedisName, redisSecurityGroup, PortConfig.RedisDefaultPort);

        result.Export.Add(databaseGroupAndSubnets);
        result.Export.Add(elastiCacheSubnetGroupAndSubnets);
        result.Export.Add(redisSecurityGroup.T2);
        result.Export.Add(loadBalancerSecurityGroup.T2);
        result.Export.Add(rdsSecurityGroup.T2);
        result.Export.Add(dockerSecurityGroup.T2);
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
