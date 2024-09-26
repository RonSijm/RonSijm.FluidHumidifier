// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerApiGatewayManagedOverridesRouteSettingsFactory(Action<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings>
{

    protected override Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings Create()
    {
        var routeSettingsResult = CreateRouteSettings();
        factoryAction?.Invoke(routeSettingsResult);

        return routeSettingsResult;
    }

    private Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings CreateRouteSettings()
    {
        var routeSettingsResult = new Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.RouteSettings();

        return routeSettingsResult;
    }

} // End Of Class

public static class InnerApiGatewayManagedOverridesRouteSettingsFactoryExtensions
{
}
