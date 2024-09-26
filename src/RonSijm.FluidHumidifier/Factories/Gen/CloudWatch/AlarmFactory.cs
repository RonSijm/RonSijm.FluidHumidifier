// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class AlarmFactory(string resourceName = null, Action<Humidifier.CloudWatch.Alarm> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.Alarm>(resourceName)
{

    internal List<InnerAlarmDimensionFactory> DimensionsFactories { get; set; } = [];

    internal List<InnerAlarmMetricDataQueryFactory> MetricsFactories { get; set; } = [];

    protected override Humidifier.CloudWatch.Alarm Create()
    {
        var alarmResult = CreateAlarm();
        factoryAction?.Invoke(alarmResult);

        return alarmResult;
    }

    private Humidifier.CloudWatch.Alarm CreateAlarm()
    {
        var alarmResult = new Humidifier.CloudWatch.Alarm
        {
            GivenName = InputResourceName,
        };

        return alarmResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.Alarm result)
    {
        base.CreateChildren(result);

        result.Dimensions = DimensionsFactories.Any() ? DimensionsFactories.Select(x => x.Build()).ToList() : null;
        result.Metrics = MetricsFactories.Any() ? MetricsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AlarmFactoryExtensions
{
    public static CombinedResult<AlarmFactory, InnerAlarmDimensionFactory> WithDimensions(this AlarmFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null)
    {
        var factory = new InnerAlarmDimensionFactory(subFactoryAction);
        parentFactory.DimensionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AlarmFactory, InnerAlarmMetricDataQueryFactory> WithMetrics(this AlarmFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null)
    {
        var factory = new InnerAlarmMetricDataQueryFactory(subFactoryAction);
        parentFactory.MetricsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AlarmFactory, T1, InnerAlarmDimensionFactory> WithDimensions<T1>(this CombinedResult<AlarmFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, InnerAlarmDimensionFactory> WithDimensions<T1>(this CombinedResult<T1, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, T2, InnerAlarmDimensionFactory> WithDimensions<T1, T2>(this CombinedResult<AlarmFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, T2, InnerAlarmDimensionFactory> WithDimensions<T1, T2>(this CombinedResult<T1, AlarmFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmFactory, InnerAlarmDimensionFactory> WithDimensions<T1, T2>(this CombinedResult<T1, T2, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, T2, T3, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3>(this CombinedResult<AlarmFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, T2, T3, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, AlarmFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmFactory, T3, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, T2, AlarmFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmFactory, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, T2, T3, T4, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<AlarmFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, T2, T3, T4, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, AlarmFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmFactory, T3, T4, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmFactory, T4, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AlarmFactory, InnerAlarmDimensionFactory> WithDimensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.Dimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDimensions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, InnerAlarmMetricDataQueryFactory> WithMetrics<T1>(this CombinedResult<AlarmFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, InnerAlarmMetricDataQueryFactory> WithMetrics<T1>(this CombinedResult<T1, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, T2, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2>(this CombinedResult<AlarmFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, T2, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2>(this CombinedResult<T1, AlarmFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmFactory, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2>(this CombinedResult<T1, T2, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, T2, T3, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3>(this CombinedResult<AlarmFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, T2, T3, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3>(this CombinedResult<T1, AlarmFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmFactory, T3, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3>(this CombinedResult<T1, T2, AlarmFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmFactory, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3>(this CombinedResult<T1, T2, T3, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AlarmFactory, T1, T2, T3, T4, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<AlarmFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AlarmFactory, T2, T3, T4, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, AlarmFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AlarmFactory, T3, T4, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, AlarmFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AlarmFactory, T4, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AlarmFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AlarmFactory, InnerAlarmMetricDataQueryFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AlarmFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T5, subFactoryAction));
}
