// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerApiGatewayManagedOverridesRouteOverridesFactory(Action<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteOverrides> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteOverrides>
{

    protected override Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteOverrides Create()
    {
        var routeOverridesResult = CreateRouteOverrides();
        factoryAction?.Invoke(routeOverridesResult);

        return routeOverridesResult;
    }

    private Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteOverrides CreateRouteOverrides()
    {
        var routeOverridesResult = new Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteOverrides();

        return routeOverridesResult;
    }

} // End Of Class

public static class InnerApiGatewayManagedOverridesRouteOverridesFactoryExtensions
{
}
