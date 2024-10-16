// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class RouteResponseFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.RouteResponse> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.RouteResponse>(resourceName)
{

    protected override Humidifier.ApiGatewayV2.RouteResponse Create()
    {
        var routeResponseResult = CreateRouteResponse();
        factoryAction?.Invoke(routeResponseResult);

        return routeResponseResult;
    }

    private Humidifier.ApiGatewayV2.RouteResponse CreateRouteResponse()
    {
        var routeResponseResult = new Humidifier.ApiGatewayV2.RouteResponse
        {
            GivenName = InputResourceName,
        };

        return routeResponseResult;
    }

} // End Of Class

public static class RouteResponseFactoryExtensions
{
}
