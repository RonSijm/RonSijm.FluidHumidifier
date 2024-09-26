// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmMetricDataQueryFactory(Action<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery>
{

    internal InnerAlarmMetricStatFactory MetricStatFactory { get; set; }

    protected override Humidifier.CloudWatch.AlarmTypes.MetricDataQuery Create()
    {
        var metricDataQueryResult = CreateMetricDataQuery();
        factoryAction?.Invoke(metricDataQueryResult);

        return metricDataQueryResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.MetricDataQuery CreateMetricDataQuery()
    {
        var metricDataQueryResult = new Humidifier.CloudWatch.AlarmTypes.MetricDataQuery();

        return metricDataQueryResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.AlarmTypes.MetricDataQuery result)
    {
        base.CreateChildren(result);

        result.MetricStat ??= MetricStatFactory?.Build();
    }

} // End Of Class

public static class InnerAlarmMetricDataQueryFactoryExtensions
{
    public static CombinedResult<InnerAlarmMetricDataQueryFactory, InnerAlarmMetricStatFactory> WithMetricStat(this InnerAlarmMetricDataQueryFactory parentFactory, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null)
    {
        parentFactory.MetricStatFactory = new InnerAlarmMetricStatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricStatFactory);
    }

    public static CombinedResult<InnerAlarmMetricDataQueryFactory, T1, InnerAlarmMetricStatFactory> WithMetricStat<T1>(this CombinedResult<InnerAlarmMetricDataQueryFactory, T1> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricStat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricDataQueryFactory, InnerAlarmMetricStatFactory> WithMetricStat<T1>(this CombinedResult<T1, InnerAlarmMetricDataQueryFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricStat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAlarmMetricDataQueryFactory, T1, T2, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2>(this CombinedResult<InnerAlarmMetricDataQueryFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricDataQueryFactory, T2, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2>(this CombinedResult<T1, InnerAlarmMetricDataQueryFactory, T2> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmMetricDataQueryFactory, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2>(this CombinedResult<T1, T2, InnerAlarmMetricDataQueryFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAlarmMetricDataQueryFactory, T1, T2, T3, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3>(this CombinedResult<InnerAlarmMetricDataQueryFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricDataQueryFactory, T2, T3, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3>(this CombinedResult<T1, InnerAlarmMetricDataQueryFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmMetricDataQueryFactory, T3, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3>(this CombinedResult<T1, T2, InnerAlarmMetricDataQueryFactory, T3> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlarmMetricDataQueryFactory, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAlarmMetricDataQueryFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAlarmMetricDataQueryFactory, T1, T2, T3, T4, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3, T4>(this CombinedResult<InnerAlarmMetricDataQueryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAlarmMetricDataQueryFactory, T2, T3, T4, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3, T4>(this CombinedResult<T1, InnerAlarmMetricDataQueryFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAlarmMetricDataQueryFactory, T3, T4, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAlarmMetricDataQueryFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAlarmMetricDataQueryFactory, T4, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAlarmMetricDataQueryFactory, T4> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAlarmMetricDataQueryFactory, InnerAlarmMetricStatFactory> WithMetricStat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAlarmMetricDataQueryFactory> combinedResult, Action<Humidifier.CloudWatch.AlarmTypes.MetricStat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricStat(combinedResult.T5, subFactoryAction));
}
