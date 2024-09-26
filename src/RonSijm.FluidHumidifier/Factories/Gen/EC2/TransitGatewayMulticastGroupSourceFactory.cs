// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayMulticastGroupSourceFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayMulticastGroupSource> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayMulticastGroupSource>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayMulticastGroupSource Create()
    {
        var transitGatewayMulticastGroupSourceResult = CreateTransitGatewayMulticastGroupSource();
        factoryAction?.Invoke(transitGatewayMulticastGroupSourceResult);

        return transitGatewayMulticastGroupSourceResult;
    }

    private Humidifier.EC2.TransitGatewayMulticastGroupSource CreateTransitGatewayMulticastGroupSource()
    {
        var transitGatewayMulticastGroupSourceResult = new Humidifier.EC2.TransitGatewayMulticastGroupSource
        {
            GivenName = InputResourceName,
        };

        return transitGatewayMulticastGroupSourceResult;
    }

} // End Of Class

public static class TransitGatewayMulticastGroupSourceFactoryExtensions
{
}
