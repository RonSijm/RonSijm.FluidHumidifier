// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensAdvancedPerformanceMetricsFactory(Action<Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics>
{

    protected override Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics Create()
    {
        var advancedPerformanceMetricsResult = CreateAdvancedPerformanceMetrics();
        factoryAction?.Invoke(advancedPerformanceMetricsResult);

        return advancedPerformanceMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics CreateAdvancedPerformanceMetrics()
    {
        var advancedPerformanceMetricsResult = new Humidifier.S3.StorageLensTypes.AdvancedPerformanceMetrics();

        return advancedPerformanceMetricsResult;
    }

} // End Of Class

public static class InnerStorageLensAdvancedPerformanceMetricsFactoryExtensions
{
}
