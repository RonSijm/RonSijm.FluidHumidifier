// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedType.Global

using Humidifier.EC2;
using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Factories.EC2;
using RonSijm.FluidHumidifier.Factories.Custom.SubnetFactories;

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class EC2TransitGatewayAttachmentSubnetGroupWithSubnetsExtension
{
    public static TransitGatewayAttachmentFactory WithEC2TransitGatewayAttachmentSubnetGroupAndSubnets(this VPCFactory factory, string subnetName, Action<SubnetFactoryConfig> config)
    {
        var subnets = new List<IResultFactory>();
        var dbSubnetGroupFactory = factory.CreateSubFactory(() => new TransitGatewayAttachmentFactory($"{subnetName} Subnet Group", x =>
        {
            x.SubnetIds = FFn.FFnREFList(subnets);
            x.DependsOn = FFn.FFNamedList(subnets);
        }));

        factory.WithSubnets(subnetName, config, subnets, () => dbSubnetGroupFactory.Build());

        factory.ExtendedSubFactories.Add(dbSubnetGroupFactory);

        return dbSubnetGroupFactory;
    }
}
