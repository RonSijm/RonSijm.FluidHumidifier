// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorMetricSetFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet>
{

    internal InnerAnomalyDetectorMetricSourceFactory MetricSourceFactory { get; set; }

    internal InnerAnomalyDetectorTimestampColumnFactory TimestampColumnFactory { get; set; }

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet Create()
    {
        var metricSetResult = CreateMetricSet();
        factoryAction?.Invoke(metricSetResult);

        return metricSetResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet CreateMetricSet()
    {
        var metricSetResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet();

        return metricSetResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet result)
    {
        base.CreateChildren(result);

        result.MetricSource ??= MetricSourceFactory?.Build();
        result.TimestampColumn ??= TimestampColumnFactory?.Build();
    }

} // End Of Class

public static class InnerAnomalyDetectorMetricSetFactoryExtensions
{
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource(this InnerAnomalyDetectorMetricSetFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null)
    {
        parentFactory.MetricSourceFactory = new InnerAnomalyDetectorMetricSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricSourceFactory);
    }

    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn(this InnerAnomalyDetectorMetricSetFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null)
    {
        parentFactory.TimestampColumnFactory = new InnerAnomalyDetectorTimestampColumnFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimestampColumnFactory);
    }

    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2>(this CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3, T4, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3, T4>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3, T4, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3, T4, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory, T4, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorMetricSourceFactory> WithMetricSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestampColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimestampColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2>(this CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3, T4, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3, T4>(this CombinedResult<InnerAnomalyDetectorMetricSetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3, T4, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnomalyDetectorMetricSetFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3, T4, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnomalyDetectorMetricSetFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory, T4, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorMetricSetFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorMetricSetFactory, InnerAnomalyDetectorTimestampColumnFactory> WithTimestampColumn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorMetricSetFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.TimestampColumn> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimestampColumn(combinedResult.T5, subFactoryAction));
}
