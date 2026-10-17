// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithRequesterGatewayExtension
{
    public static CombinedResult<VPCFactory, RTBFabric.RequesterGatewayFactory> WithRequesterGateway(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.RTBFabric.RequesterGateway> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new RTBFabric.RequesterGatewayFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, RTBFabric.RequesterGatewayFactory>(factory, childResourceFactory);
    }
}
