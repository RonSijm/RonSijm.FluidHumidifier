// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmMetricFactory(Action<Humidifier.CloudWatch.AlarmTypes.Metric> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.Metric>
{

    protected override Humidifier.CloudWatch.AlarmTypes.Metric Create()
    {
        var metricResult = CreateMetric();
        factoryAction?.Invoke(metricResult);

        return metricResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.Metric CreateMetric()
    {
        var metricResult = new Humidifier.CloudWatch.AlarmTypes.Metric();

        return metricResult;
    }

} // End Of Class

public static class InnerAlarmMetricFactoryExtensions
{
}
