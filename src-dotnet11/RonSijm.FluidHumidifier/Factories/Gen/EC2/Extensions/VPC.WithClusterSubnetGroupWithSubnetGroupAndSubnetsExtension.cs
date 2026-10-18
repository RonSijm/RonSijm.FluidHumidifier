// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedType.Global

using Humidifier.EC2;
using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Factories.Redshift;
using RonSijm.FluidHumidifier.Factories.Custom.SubnetFactories;

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class RedshiftClusterSubnetGroupWithSubnetsExtension
{
    public static ClusterSubnetGroupFactory WithRedshiftClusterSubnetGroupAndSubnets(this VPCFactory factory, string subnetName, Action<SubnetFactoryConfig> config)
    {
        var subnets = new List<IResultFactory>();
        var dbSubnetGroupFactory = factory.CreateSubFactory(() => new ClusterSubnetGroupFactory($"{subnetName} Subnet Group", x =>
        {
            x.SubnetIds = FFn.FFnREFList(subnets);
            x.DependsOn = FFn.FFNamedList(subnets);
            x.Description = "Default Subnet Group for Redshift";
        }));

        factory.WithSubnets(subnetName, config, subnets, () => dbSubnetGroupFactory.Build());

        factory.ExtendedSubFactories.Add(dbSubnetGroupFactory);

        return dbSubnetGroupFactory;
    }
}
