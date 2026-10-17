// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerMetricAttributionMetricsOutputConfigFactory(Action<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig>
{

    internal InnerMetricAttributionS3DataDestinationFactory S3DataDestinationFactory { get; set; }

    protected override Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig Create()
    {
        var metricsOutputConfigResult = CreateMetricsOutputConfig();
        factoryAction?.Invoke(metricsOutputConfigResult);

        return metricsOutputConfigResult;
    }

    private Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig CreateMetricsOutputConfig()
    {
        var metricsOutputConfigResult = new Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig();

        return metricsOutputConfigResult;
    }
    public override void CreateChildren(Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig result)
    {
        base.CreateChildren(result);

        result.S3DataDestination ??= S3DataDestinationFactory?.Build();
    }

} // End Of Class

public static class InnerMetricAttributionMetricsOutputConfigFactoryExtensions
{
    public static CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination(this InnerMetricAttributionMetricsOutputConfigFactory parentFactory, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null)
    {
        parentFactory.S3DataDestinationFactory = new InnerMetricAttributionS3DataDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataDestinationFactory);
    }

    public static CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1>(this CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1>(this CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, T2, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2>(this CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, T2, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, T2> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMetricAttributionMetricsOutputConfigFactory, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2>(this CombinedResult<T1, T2, InnerMetricAttributionMetricsOutputConfigFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, T2, T3, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, T2, T3, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMetricAttributionMetricsOutputConfigFactory, T3, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerMetricAttributionMetricsOutputConfigFactory, T3> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMetricAttributionMetricsOutputConfigFactory, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMetricAttributionMetricsOutputConfigFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, T2, T3, T4, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<InnerMetricAttributionMetricsOutputConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, T2, T3, T4, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerMetricAttributionMetricsOutputConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMetricAttributionMetricsOutputConfigFactory, T3, T4, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMetricAttributionMetricsOutputConfigFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMetricAttributionMetricsOutputConfigFactory, T4, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMetricAttributionMetricsOutputConfigFactory, T4> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMetricAttributionMetricsOutputConfigFactory, InnerMetricAttributionS3DataDestinationFactory> WithS3DataDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMetricAttributionMetricsOutputConfigFactory> combinedResult, Action<Humidifier.Personalize.MetricAttributionTypes.S3DataDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataDestination(combinedResult.T5, subFactoryAction).T2);
}
