// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensAdvancedDataProtectionMetricsFactory(Action<Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics>
{

    protected override Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics Create()
    {
        var advancedDataProtectionMetricsResult = CreateAdvancedDataProtectionMetrics();
        factoryAction?.Invoke(advancedDataProtectionMetricsResult);

        return advancedDataProtectionMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics CreateAdvancedDataProtectionMetrics()
    {
        var advancedDataProtectionMetricsResult = new Humidifier.S3.StorageLensTypes.AdvancedDataProtectionMetrics();

        return advancedDataProtectionMetricsResult;
    }

} // End Of Class

public static class InnerStorageLensAdvancedDataProtectionMetricsFactoryExtensions
{
}
