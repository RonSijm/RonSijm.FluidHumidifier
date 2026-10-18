// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableBucketMetricsConfigurationFactory(Action<Humidifier.S3Tables.TableBucketTypes.MetricsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableBucketTypes.MetricsConfiguration>
{

    protected override Humidifier.S3Tables.TableBucketTypes.MetricsConfiguration Create()
    {
        var metricsConfigurationResult = CreateMetricsConfiguration();
        factoryAction?.Invoke(metricsConfigurationResult);

        return metricsConfigurationResult;
    }

    private Humidifier.S3Tables.TableBucketTypes.MetricsConfiguration CreateMetricsConfiguration()
    {
        var metricsConfigurationResult = new Humidifier.S3Tables.TableBucketTypes.MetricsConfiguration();

        return metricsConfigurationResult;
    }

} // End Of Class

public static class InnerTableBucketMetricsConfigurationFactoryExtensions
{
}
