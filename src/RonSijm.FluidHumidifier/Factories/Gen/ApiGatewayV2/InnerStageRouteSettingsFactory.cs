// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerStageRouteSettingsFactory(Action<Humidifier.ApiGatewayV2.StageTypes.RouteSettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.StageTypes.RouteSettings>
{

    protected override Humidifier.ApiGatewayV2.StageTypes.RouteSettings Create()
    {
        var routeSettingsResult = CreateRouteSettings();
        factoryAction?.Invoke(routeSettingsResult);

        return routeSettingsResult;
    }

    private Humidifier.ApiGatewayV2.StageTypes.RouteSettings CreateRouteSettings()
    {
        var routeSettingsResult = new Humidifier.ApiGatewayV2.StageTypes.RouteSettings();

        return routeSettingsResult;
    }

} // End Of Class

public static class InnerStageRouteSettingsFactoryExtensions
{
}
