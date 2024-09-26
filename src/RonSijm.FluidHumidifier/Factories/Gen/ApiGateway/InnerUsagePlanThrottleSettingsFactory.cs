// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerUsagePlanThrottleSettingsFactory(Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings>
{

    protected override Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings Create()
    {
        var throttleSettingsResult = CreateThrottleSettings();
        factoryAction?.Invoke(throttleSettingsResult);

        return throttleSettingsResult;
    }

    private Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings CreateThrottleSettings()
    {
        var throttleSettingsResult = new Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings();

        return throttleSettingsResult;
    }

} // End Of Class

public static class InnerUsagePlanThrottleSettingsFactoryExtensions
{
}
