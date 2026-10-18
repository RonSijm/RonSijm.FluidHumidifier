// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensAdvancedCostOptimizationMetricsFactory(Action<Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics>
{

    protected override Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics Create()
    {
        var advancedCostOptimizationMetricsResult = CreateAdvancedCostOptimizationMetrics();
        factoryAction?.Invoke(advancedCostOptimizationMetricsResult);

        return advancedCostOptimizationMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics CreateAdvancedCostOptimizationMetrics()
    {
        var advancedCostOptimizationMetricsResult = new Humidifier.S3.StorageLensTypes.AdvancedCostOptimizationMetrics();

        return advancedCostOptimizationMetricsResult;
    }

} // End Of Class

public static class InnerStorageLensAdvancedCostOptimizationMetricsFactoryExtensions
{
}
