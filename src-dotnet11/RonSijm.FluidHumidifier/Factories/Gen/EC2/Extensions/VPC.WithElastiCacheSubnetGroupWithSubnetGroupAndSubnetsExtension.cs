// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedType.Global

using Humidifier.EC2;
using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Factories.ElastiCache;
using RonSijm.FluidHumidifier.Factories.Custom.SubnetFactories;

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class ElastiCacheSubnetGroupWithSubnetsExtension
{
    public static SubnetGroupFactory WithElastiCacheSubnetGroupAndSubnets(this VPCFactory factory, string subnetName, Action<SubnetFactoryConfig> config)
    {
        var subnets = new List<IResultFactory>();
        var dbSubnetGroupFactory = factory.CreateSubFactory(() => new SubnetGroupFactory($"{subnetName} Subnet Group", x =>
        {
            x.SubnetIds = FFn.FFnREFList(subnets);
            x.DependsOn = FFn.FFNamedList(subnets);
            x.Description = "Default Subnet Group for ElastiCache";
        }));

        factory.WithSubnets(subnetName, config, subnets, () => dbSubnetGroupFactory.Build());

        factory.ExtendedSubFactories.Add(dbSubnetGroupFactory);

        return dbSubnetGroupFactory;
    }
}
