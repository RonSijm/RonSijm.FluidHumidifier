// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerStageAccessLogSettingsFactory(Action<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings>
{

    protected override Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings Create()
    {
        var accessLogSettingsResult = CreateAccessLogSettings();
        factoryAction?.Invoke(accessLogSettingsResult);

        return accessLogSettingsResult;
    }

    private Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings CreateAccessLogSettings()
    {
        var accessLogSettingsResult = new Humidifier.ApiGatewayV2.StageTypes.AccessLogSettings();

        return accessLogSettingsResult;
    }

} // End Of Class

public static class InnerStageAccessLogSettingsFactoryExtensions
{
}
