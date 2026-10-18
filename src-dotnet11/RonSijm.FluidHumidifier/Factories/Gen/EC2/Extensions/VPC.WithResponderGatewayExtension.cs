// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithResponderGatewayExtension
{
    public static CombinedResult<VPCFactory, RTBFabric.ResponderGatewayFactory> WithResponderGateway(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.RTBFabric.ResponderGateway> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new RTBFabric.ResponderGatewayFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, RTBFabric.ResponderGatewayFactory>(factory, childResourceFactory);
    }
}
