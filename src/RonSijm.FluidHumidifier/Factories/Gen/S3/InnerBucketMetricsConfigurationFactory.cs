// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketMetricsConfigurationFactory(Action<Humidifier.S3.BucketTypes.MetricsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.MetricsConfiguration>
{

    protected override Humidifier.S3.BucketTypes.MetricsConfiguration Create()
    {
        var metricsConfigurationResult = CreateMetricsConfiguration();
        factoryAction?.Invoke(metricsConfigurationResult);

        return metricsConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.MetricsConfiguration CreateMetricsConfiguration()
    {
        var metricsConfigurationResult = new Humidifier.S3.BucketTypes.MetricsConfiguration();

        return metricsConfigurationResult;
    }

} // End Of Class

public static class InnerBucketMetricsConfigurationFactoryExtensions
{
}
