// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class MetricAttributionFactory(string resourceName = null, Action<Humidifier.Personalize.MetricAttribution> factoryAction = null) : ResourceFactory<Humidifier.Personalize.MetricAttribution>(resourceName)
{

    internal List<InnerMetricAttributionMetricAttributeFactory> MetricsFactories { get; set; } = [];

    internal InnerMetricAttributionMetricsOutputConfigFactory MetricsOutputConfigFactory { get; set; }

    protected override Humidifier.Personalize.MetricAttribution Create()
    {
        var metricAttributionResult = CreateMetricAttribution();
        factoryAction?.Invoke(metricAttributionResult);

        return metricAttributionResult;
    }

    private Humidifier.Personalize.MetricAttribution CreateMetricAttribution()
    {
        var metricAttributionResult = new Humidifier.Personalize.MetricAttribution
        {
            GivenName = InputResourceName,
        };

        return metricAttributionResult;
    }
    public override void CreateChildren(Humidifier.Personalize.MetricAttribution result)
    {
        base.CreateChildren(result);

        result.Metrics = MetricsFactories.Any() ? MetricsFactories.Select(x => x.Build()).ToList() : null;
        result.MetricsOutputConfig ??= MetricsOutputConfigFactory?.Build();
    }

} // End Of Class

public static class MetricAttributionFactoryExtensions
{
    public static CombinedResult<MetricAttributionFactory, InnerMetricAttributionMetricAttributeFactory> WithMetrics(this MetricAttributionFactory parentFactory, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null)
    {
        var factory = new InnerMetricAttributionMetricAttributeFactory(subFactoryAction);
        parentFactory.MetricsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MetricAttributionFactory, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig(this MetricAttributionFactory parentFactory, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null)
    {
        parentFactory.MetricsOutputConfigFactory = new InnerMetricAttributionMetricsOutputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricsOutputConfigFactory);
    }

    public static CombinedResult<MetricAttributionFactory, T1, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1>(this CombinedResult<MetricAttributionFactory, T1> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1>(this CombinedResult<T1, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, T2, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2>(this CombinedResult<MetricAttributionFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, T2, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2>(this CombinedResult<T1, MetricAttributionFactory, T2> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricAttributionFactory, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2>(this CombinedResult<T1, T2, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, T2, T3, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3>(this CombinedResult<MetricAttributionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, T2, T3, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3>(this CombinedResult<T1, MetricAttributionFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricAttributionFactory, T3, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3>(this CombinedResult<T1, T2, MetricAttributionFactory, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetricAttributionFactory, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3>(this CombinedResult<T1, T2, T3, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, T2, T3, T4, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<MetricAttributionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, T2, T3, T4, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, MetricAttributionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricAttributionFactory, T3, T4, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, MetricAttributionFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetricAttributionFactory, T4, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MetricAttributionFactory, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MetricAttributionFactory, InnerMetricAttributionMetricAttributeFactory> WithMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetrics(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1>(this CombinedResult<MetricAttributionFactory, T1> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1>(this CombinedResult<T1, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, T2, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2>(this CombinedResult<MetricAttributionFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, T2, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2>(this CombinedResult<T1, MetricAttributionFactory, T2> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricAttributionFactory, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2>(this CombinedResult<T1, T2, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, T2, T3, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3>(this CombinedResult<MetricAttributionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, T2, T3, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3>(this CombinedResult<T1, MetricAttributionFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricAttributionFactory, T3, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, MetricAttributionFactory, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetricAttributionFactory, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MetricAttributionFactory, T1, T2, T3, T4, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3, T4>(this CombinedResult<MetricAttributionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricAttributionFactory, T2, T3, T4, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, MetricAttributionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricAttributionFactory, T3, T4, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, MetricAttributionFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetricAttributionFactory, T4, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MetricAttributionFactory, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MetricAttributionFactory, InnerMetricAttributionMetricsOutputConfigFactory> WithMetricsOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MetricAttributionFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricsOutputConfig(combinedResult.T5, subFactoryAction).T2);
}
