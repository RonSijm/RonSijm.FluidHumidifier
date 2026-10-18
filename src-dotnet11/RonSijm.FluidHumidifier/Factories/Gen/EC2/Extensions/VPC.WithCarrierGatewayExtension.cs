// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithCarrierGatewayExtension
{
    public static CombinedResult<VPCFactory, EC2.CarrierGatewayFactory> WithCarrierGateway(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.EC2.CarrierGateway> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new EC2.CarrierGatewayFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, EC2.CarrierGatewayFactory>(factory, childResourceFactory);
    }
}
