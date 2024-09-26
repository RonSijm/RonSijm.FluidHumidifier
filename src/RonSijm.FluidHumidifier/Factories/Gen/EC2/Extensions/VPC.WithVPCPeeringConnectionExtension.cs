// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithVPCPeeringConnectionExtension
{
    public static CombinedResult<VPCFactory, EC2.VPCPeeringConnectionFactory> WithVPCPeeringConnection(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.EC2.VPCPeeringConnection> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new EC2.VPCPeeringConnectionFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, EC2.VPCPeeringConnectionFactory>(factory, childResourceFactory);
    }
}
