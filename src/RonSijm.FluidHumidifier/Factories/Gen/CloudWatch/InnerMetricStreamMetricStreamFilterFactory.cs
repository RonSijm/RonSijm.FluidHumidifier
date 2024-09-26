// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerMetricStreamMetricStreamFilterFactory(Action<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter>
{

    protected override Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter Create()
    {
        var metricStreamFilterResult = CreateMetricStreamFilter();
        factoryAction?.Invoke(metricStreamFilterResult);

        return metricStreamFilterResult;
    }

    private Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter CreateMetricStreamFilter()
    {
        var metricStreamFilterResult = new Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter();

        return metricStreamFilterResult;
    }

} // End Of Class

public static class InnerMetricStreamMetricStreamFilterFactoryExtensions
{
}
