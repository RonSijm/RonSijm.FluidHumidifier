using Humidifier.EC2;
using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Factories.Custom.SubnetFactories;

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithSubnetsExtension
{
    public static VPCFactory WithSubnets(this VPCFactory factory, string subnetBaseName, Action<SubnetFactoryConfig> config, List<IResultFactory> addTo = null, Action withAction = null)
    {
        var vpcAction = new Action<VPC>(_ =>
        {
            var factoryConfig = new SubnetFactoryConfig();
            config(factoryConfig);

            for (var i = 1; i <= 3; i++)
            {
                var i1 = i;
                var az = $"{$"{(char)('a' + i1 - 1)}".ToUpper()}";

                var subnetName = $"{subnetBaseName} Subnet AZ-{az}";

                var subnetFactory = factory.WithSubnet(subnetName, subnet =>
                {
                    subnet.AvailabilityZone = $"{factoryConfig.RegionName}{(char)('a' + i1 - 1)}";
                    subnet.CidrBlock = factoryConfig.CidrBlock.Invoke(i1 + factoryConfig.StartAt);
                    subnet.Export = factoryConfig.Export;
                });

                if (factoryConfig.RouteTable != null)
                {
                    factory.CreateSubFactory(() => new RouteTableFactory($"{subnetBaseName}-AZ-{az}-{factoryConfig.RouteTable.Result.GivenName}-AS", x => { x.VpcId = FFn.FFnREF(factory); }));

                    var subnetRouteTableAssociationFactory = factory.CreateSubFactory(() => new SubnetRouteTableAssociationFactory($"{subnetBaseName}-AZ-{az}-{factoryConfig.RouteTable.Result.GivenName}-AS", x =>
                    {
                        x.RouteTableId = FFn.FFnREF(factoryConfig.RouteTable);
                        x.SubnetId = FFn.FFnREF(subnetFactory.T2);
                    }));

                    factory.ExtendedResourceFactories.Add(subnetRouteTableAssociationFactory);
                }

                if (factoryConfig.NetworkACL != null)
                {
                    var networkAclAssociationFactory = factory.CreateSubFactory(() => new SubnetNetworkAclAssociationFactory($"{subnetBaseName}-AZ-{az}-{factoryConfig.RouteTable.Result.GivenName}-NW-ASS", x =>
                    {
                        x.NetworkAclId = FFn.FFnREF(factoryConfig.NetworkACL);
                        x.SubnetId = FFn.FFnREF(subnetFactory.T2);
                    }));

                    factory.ExtendedResourceFactories.Add(networkAclAssociationFactory);
                }

                addTo?.Add(subnetFactory.T2);
            }

            withAction?.Invoke();
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return factory;
    }
}