// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class MetricFilterFactory(string resourceName = null, Action<Humidifier.Logs.MetricFilter> factoryAction = null) : ResourceFactory<Humidifier.Logs.MetricFilter>(resourceName)
{

    internal List<InnerMetricFilterMetricTransformationFactory> MetricTransformationsFactories { get; set; } = [];

    protected override Humidifier.Logs.MetricFilter Create()
    {
        var metricFilterResult = CreateMetricFilter();
        factoryAction?.Invoke(metricFilterResult);

        return metricFilterResult;
    }

    private Humidifier.Logs.MetricFilter CreateMetricFilter()
    {
        var metricFilterResult = new Humidifier.Logs.MetricFilter
        {
            GivenName = InputResourceName,
        };

        return metricFilterResult;
    }
    public override void CreateChildren(Humidifier.Logs.MetricFilter result)
    {
        base.CreateChildren(result);

        result.MetricTransformations = MetricTransformationsFactories.Any() ? MetricTransformationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MetricFilterFactoryExtensions
{
    public static CombinedResult<MetricFilterFactory, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations(this MetricFilterFactory parentFactory, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null)
    {
        var factory = new InnerMetricFilterMetricTransformationFactory(subFactoryAction);
        parentFactory.MetricTransformationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MetricFilterFactory, T1, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1>(this CombinedResult<MetricFilterFactory, T1> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricTransformations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MetricFilterFactory, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1>(this CombinedResult<T1, MetricFilterFactory> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricTransformations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MetricFilterFactory, T1, T2, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2>(this CombinedResult<MetricFilterFactory, T1, T2> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MetricFilterFactory, T2, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2>(this CombinedResult<T1, MetricFilterFactory, T2> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MetricFilterFactory, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2>(this CombinedResult<T1, T2, MetricFilterFactory> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MetricFilterFactory, T1, T2, T3, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3>(this CombinedResult<MetricFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MetricFilterFactory, T2, T3, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3>(this CombinedResult<T1, MetricFilterFactory, T2, T3> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MetricFilterFactory, T3, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3>(this CombinedResult<T1, T2, MetricFilterFactory, T3> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MetricFilterFactory, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3>(this CombinedResult<T1, T2, T3, MetricFilterFactory> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MetricFilterFactory, T1, T2, T3, T4, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3, T4>(this CombinedResult<MetricFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MetricFilterFactory, T2, T3, T4, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3, T4>(this CombinedResult<T1, MetricFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MetricFilterFactory, T3, T4, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3, T4>(this CombinedResult<T1, T2, MetricFilterFactory, T3, T4> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MetricFilterFactory, T4, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MetricFilterFactory, T4> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MetricFilterFactory, InnerMetricFilterMetricTransformationFactory> WithMetricTransformations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MetricFilterFactory> combinedResult, Action<Humidifier.Logs.MetricFilterTypes.MetricTransformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricTransformations(combinedResult.T5, subFactoryAction));
}
