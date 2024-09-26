// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmMetricStatFactory(Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.MetricStat>
{

    internal InnerAlarmMetricFactory MetricFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmTypes.MetricStat Create()
    {
        var metricStatResult = CreateMetricStat();
        factoryAction?.Invoke(metricStatResult);

        return metricStatResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.MetricStat CreateMetricStat()
    {
        var metricStatResult = new Humidifier.CloudWatch.AlarmTypes.MetricStat();

        return metricStatResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmTypes.MetricStat result)
    {
        base.CreateChildren(result);

        result.Metric ??= MetricFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmMetricStatFactoryExtensions
{
    public static CombinedResult<InnerAlarmMetricStatFactory, InnerAlarmMetricFactory> WithMetric(this InnerAlarmMetricStatFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null)
    {
        parentFactory.MetricFactory = new InnerAlarmMetricFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricFactory);
    }

    public static CombinedResult<InnerAlarmMetricStatFactory, T1, InnerAlarmMetricFactory> WithMetric<T1>(this CombinedResult<InnerAlarmMetricStatFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricStatFactory, InnerAlarmMetricFactory> WithMetric<T1>(this CombinedResult<T1, InnerAlarmMetricStatFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAlarmMetricStatFactory, T1, T2, InnerAlarmMetricFactory> WithMetric<T1, T2>(this CombinedResult<InnerAlarmMetricStatFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricStatFactory, T2, InnerAlarmMetricFactory> WithMetric<T1, T2>(this CombinedResult<T1, InnerAlarmMetricStatFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmMetricStatFactory, InnerAlarmMetricFactory> WithMetric<T1, T2>(this CombinedResult<T1, T2, InnerAlarmMetricStatFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAlarmMetricStatFactory, T1, T2, T3, InnerAlarmMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<InnerAlarmMetricStatFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricStatFactory, T2, T3, InnerAlarmMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<T1, InnerAlarmMetricStatFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmMetricStatFactory, T3, InnerAlarmMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmMetricStatFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlarmMetricStatFactory, InnerAlarmMetricFactory> WithMetric<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmMetricStatFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAlarmMetricStatFactory, T1, T2, T3, T4, InnerAlarmMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<InnerAlarmMetricStatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricStatFactory, T2, T3, T4, InnerAlarmMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmMetricStatFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmMetricStatFactory, T3, T4, InnerAlarmMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmMetricStatFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlarmMetricStatFactory, T4, InnerAlarmMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmMetricStatFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmMetricStatFactory, InnerAlarmMetricFactory> WithMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmMetricStatFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Metric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetric(combinedResult.T5, subFactoryAction));
}
