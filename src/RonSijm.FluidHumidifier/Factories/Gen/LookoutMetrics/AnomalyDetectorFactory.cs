// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class AnomalyDetectorFactory(string resourceName = null, Action<Humidifier.LookoutMetrics.AnomalyDetector> factoryAction = null) : ResourceFactory<Humidifier.LookoutMetrics.AnomalyDetector>(resourceName)
{

    internal List<InnerAnomalyDetectorMetricSetFactory> MetricSetListFactories { get; set; } = [];

    internal InnerAnomalyDetectorAnomalyDetectorConfigFactory AnomalyDetectorConfigFactory { get; set; }

    protected override Humidifier.LookoutMetrics.AnomalyDetector Create()
    {
        var anomalyDetectorResult = CreateAnomalyDetector();
        factoryAction?.Invoke(anomalyDetectorResult);

        return anomalyDetectorResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetector CreateAnomalyDetector()
    {
        var anomalyDetectorResult = new Humidifier.LookoutMetrics.AnomalyDetector
        {
            GivenName = InputResourceName,
        };

        return anomalyDetectorResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.AnomalyDetector result)
    {
        base.CreateChildren(result);

        result.MetricSetList = MetricSetListFactories.Any() ? MetricSetListFactories.Select(x => x.Build()).ToList() : null;
        result.AnomalyDetectorConfig ??= AnomalyDetectorConfigFactory?.Build();
    }

} // End Of Class

public static class AnomalyDetectorFactoryExtensions
{
    public static CombinedResult<AnomalyDetectorFactory, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList(this AnomalyDetectorFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null)
    {
        var factory = new InnerAnomalyDetectorMetricSetFactory(subFactoryAction);
        parentFactory.MetricSetListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig(this AnomalyDetectorFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null)
    {
        parentFactory.AnomalyDetectorConfigFactory = new InnerAnomalyDetectorAnomalyDetectorConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnomalyDetectorConfigFactory);
    }

    public static CombinedResult<AnomalyDetectorFactory, T1, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1>(this CombinedResult<AnomalyDetectorFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricSetList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1>(this CombinedResult<T1, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricSetList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2>(this CombinedResult<AnomalyDetectorFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2>(this CombinedResult<T1, AnomalyDetectorFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2>(this CombinedResult<T1, T2, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3, T4>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3, T4>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory, InnerAnomalyDetectorMetricSetFactory> WithMetricSetList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.MetricSet> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricSetList(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1>(this CombinedResult<AnomalyDetectorFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1>(this CombinedResult<T1, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2>(this CombinedResult<AnomalyDetectorFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2>(this CombinedResult<T1, AnomalyDetectorFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2>(this CombinedResult<T1, T2, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3, T4>(this CombinedResult<AnomalyDetectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3, T4>(this CombinedResult<T1, AnomalyDetectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnomalyDetectorFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnomalyDetectorFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory, InnerAnomalyDetectorAnomalyDetectorConfigFactory> WithAnomalyDetectorConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnomalyDetectorFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.AnomalyDetectorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnomalyDetectorConfig(combinedResult.T5, subFactoryAction));
}
