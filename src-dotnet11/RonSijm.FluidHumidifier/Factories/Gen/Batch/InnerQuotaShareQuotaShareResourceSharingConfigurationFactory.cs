// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerQuotaShareQuotaShareResourceSharingConfigurationFactory(Action<Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration>
{

    protected override Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration Create()
    {
        var quotaShareResourceSharingConfigurationResult = CreateQuotaShareResourceSharingConfiguration();
        factoryAction?.Invoke(quotaShareResourceSharingConfigurationResult);

        return quotaShareResourceSharingConfigurationResult;
    }

    private Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration CreateQuotaShareResourceSharingConfiguration()
    {
        var quotaShareResourceSharingConfigurationResult = new Humidifier.Batch.QuotaShareTypes.QuotaShareResourceSharingConfiguration();

        return quotaShareResourceSharingConfigurationResult;
    }

} // End Of Class

public static class InnerQuotaShareQuotaShareResourceSharingConfigurationFactoryExtensions
{
}
