// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAnomalyDetectorMetricConfigurationFactory(Action<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricConfiguration>
{

    protected override Humidifier.CloudWatch.AnomalyDetectorTypes.MetricConfiguration Create()
    {
        var metricConfigurationResult = CreateMetricConfiguration();
        factoryAction?.Invoke(metricConfigurationResult);

        return metricConfigurationResult;
    }

    private Humidifier.CloudWatch.AnomalyDetectorTypes.MetricConfiguration CreateMetricConfiguration()
    {
        var metricConfigurationResult = new Humidifier.CloudWatch.AnomalyDetectorTypes.MetricConfiguration();

        return metricConfigurationResult;
    }

} // End Of Class

public static class InnerAnomalyDetectorMetricConfigurationFactoryExtensions
{
}
