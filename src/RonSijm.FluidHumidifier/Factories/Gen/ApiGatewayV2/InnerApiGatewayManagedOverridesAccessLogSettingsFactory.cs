// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerApiGatewayManagedOverridesAccessLogSettingsFactory(Action<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.AccessLogSettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.AccessLogSettings>
{

    protected override Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.AccessLogSettings Create()
    {
        var accessLogSettingsResult = CreateAccessLogSettings();
        factoryAction?.Invoke(accessLogSettingsResult);

        return accessLogSettingsResult;
    }

    private Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.AccessLogSettings CreateAccessLogSettings()
    {
        var accessLogSettingsResult = new Humidifier.ApiGatewayV2.ApiGatewayManagedOverridesTypes.AccessLogSettings();

        return accessLogSettingsResult;
    }

} // End Of Class

public static class InnerApiGatewayManagedOverridesAccessLogSettingsFactoryExtensions
{
}
