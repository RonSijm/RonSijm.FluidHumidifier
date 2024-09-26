// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensCloudWatchMetricsFactory(Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.CloudWatchMetrics>
{

    protected override Humidifier.S3.StorageLensTypes.CloudWatchMetrics Create()
    {
        var cloudWatchMetricsResult = CreateCloudWatchMetrics();
        factoryAction?.Invoke(cloudWatchMetricsResult);

        return cloudWatchMetricsResult;
    }

    private Humidifier.S3.StorageLensTypes.CloudWatchMetrics CreateCloudWatchMetrics()
    {
        var cloudWatchMetricsResult = new Humidifier.S3.StorageLensTypes.CloudWatchMetrics();

        return cloudWatchMetricsResult;
    }

} // End Of Class

public static class InnerStorageLensCloudWatchMetricsFactoryExtensions
{
}
