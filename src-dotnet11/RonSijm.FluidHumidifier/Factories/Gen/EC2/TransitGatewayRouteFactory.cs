// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayRouteFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayRoute> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayRoute>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayRoute Create()
    {
        var transitGatewayRouteResult = CreateTransitGatewayRoute();
        factoryAction?.Invoke(transitGatewayRouteResult);

        return transitGatewayRouteResult;
    }

    private Humidifier.EC2.TransitGatewayRoute CreateTransitGatewayRoute()
    {
        var transitGatewayRouteResult = new Humidifier.EC2.TransitGatewayRoute
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRouteResult;
    }

} // End Of Class

public static class TransitGatewayRouteFactoryExtensions
{
}
