// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensDetailedStatusCodesMetricsFactory(Action<Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics>
{

    protected override Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics Create()
    {
        var detailedStatusCodesMetricsResult = CreateDetailedStatusCodesMetrics();
        factoryAction?.Invoke(detailedStatusCodesMetricsResult);

        return detailedStatusCodesMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics CreateDetailedStatusCodesMetrics()
    {
        var detailedStatusCodesMetricsResult = new Humidifier.S3.StorageLensTypes.DetailedStatusCodesMetrics();

        return detailedStatusCodesMetricsResult;
    }

} // End Of Class

public static class InnerStorageLensDetailedStatusCodesMetricsFactoryExtensions
{
}
