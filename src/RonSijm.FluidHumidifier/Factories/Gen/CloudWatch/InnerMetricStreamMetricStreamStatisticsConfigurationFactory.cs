// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerMetricStreamMetricStreamStatisticsConfigurationFactory(Action<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration>
{

    protected override Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration Create()
    {
        var metricStreamStatisticsConfigurationResult = CreateMetricStreamStatisticsConfiguration();
        factoryAction?.Invoke(metricStreamStatisticsConfigurationResult);

        return metricStreamStatisticsConfigurationResult;
    }

    private Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration CreateMetricStreamStatisticsConfiguration()
    {
        var metricStreamStatisticsConfigurationResult = new Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration();

        return metricStreamStatisticsConfigurationResult;
    }

} // End Of Class

public static class InnerMetricStreamMetricStreamStatisticsConfigurationFactoryExtensions
{
}
