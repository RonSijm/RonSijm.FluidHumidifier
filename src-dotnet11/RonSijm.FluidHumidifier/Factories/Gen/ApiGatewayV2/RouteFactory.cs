// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class RouteFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Route> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Route>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.Route Create()
    {
        var routeResult = CreateRoute();
        factoryAction?.Invoke(routeResult);

        return routeResult;
    }

    private Humidifier.ApiGatewayV2.Route CreateRoute()
    {
        var routeResult = new Humidifier.ApiGatewayV2.Route
        {
            GivenName = InputResourceName,
        };

        return routeResult;
    }

} // End Of Class

public static class RouteFactoryExtensions
{
}
