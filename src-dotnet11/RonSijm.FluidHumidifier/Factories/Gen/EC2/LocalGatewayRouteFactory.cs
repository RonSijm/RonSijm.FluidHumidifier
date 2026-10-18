// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class LocalGatewayRouteFactory(string resourceName = null, Action<Humidifier.EC2.LocalGatewayRoute> factoryAction = null) : ResourceFactory<Humidifier.EC2.LocalGatewayRoute>(resourceName)
{

    protected override Humidifier.EC2.LocalGatewayRoute Create()
    {
        var localGatewayRouteResult = CreateLocalGatewayRoute();
        factoryAction?.Invoke(localGatewayRouteResult);

        return localGatewayRouteResult;
    }

    private Humidifier.EC2.LocalGatewayRoute CreateLocalGatewayRoute()
    {
        var localGatewayRouteResult = new Humidifier.EC2.LocalGatewayRoute
        {
            GivenName = InputResourceName,
        };

        return localGatewayRouteResult;
    }

} // End Of Class

public static class LocalGatewayRouteFactoryExtensions
{
}
