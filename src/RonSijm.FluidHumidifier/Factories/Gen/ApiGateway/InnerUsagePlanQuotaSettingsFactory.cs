// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerUsagePlanQuotaSettingsFactory(Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings>
{

    protected override Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings Create()
    {
        var quotaSettingsResult = CreateQuotaSettings();
        factoryAction?.Invoke(quotaSettingsResult);

        return quotaSettingsResult;
    }

    private Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings CreateQuotaSettings()
    {
        var quotaSettingsResult = new Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings();

        return quotaSettingsResult;
    }

} // End Of Class

public static class InnerUsagePlanQuotaSettingsFactoryExtensions
{
}
