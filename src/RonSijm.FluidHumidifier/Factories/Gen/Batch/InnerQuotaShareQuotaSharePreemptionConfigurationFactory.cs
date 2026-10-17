// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerQuotaShareQuotaSharePreemptionConfigurationFactory(Action<Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration>
{

    protected override Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration Create()
    {
        var quotaSharePreemptionConfigurationResult = CreateQuotaSharePreemptionConfiguration();
        factoryAction?.Invoke(quotaSharePreemptionConfigurationResult);

        return quotaSharePreemptionConfigurationResult;
    }

    private Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration CreateQuotaSharePreemptionConfiguration()
    {
        var quotaSharePreemptionConfigurationResult = new Humidifier.Batch.QuotaShareTypes.QuotaSharePreemptionConfiguration();

        return quotaSharePreemptionConfigurationResult;
    }

} // End Of Class

public static class InnerQuotaShareQuotaSharePreemptionConfigurationFactoryExtensions
{
}
