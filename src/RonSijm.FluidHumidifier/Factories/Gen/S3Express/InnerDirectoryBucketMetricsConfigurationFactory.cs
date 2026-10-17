// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Express;

public class InnerDirectoryBucketMetricsConfigurationFactory(Action<Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration>
{

    protected override Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration Create()
    {
        var metricsConfigurationResult = CreateMetricsConfiguration();
        factoryAction?.Invoke(metricsConfigurationResult);

        return metricsConfigurationResult;
    }

    private Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration CreateMetricsConfiguration()
    {
        var metricsConfigurationResult = new Humidifier.S3Express.DirectoryBucketTypes.MetricsConfiguration();

        return metricsConfigurationResult;
    }

} // End Of Class

public static class InnerDirectoryBucketMetricsConfigurationFactoryExtensions
{
}
