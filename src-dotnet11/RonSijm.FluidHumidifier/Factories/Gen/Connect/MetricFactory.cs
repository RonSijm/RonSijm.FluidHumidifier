// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class MetricFactory(string resourceName = null, Action<Humidifier.Connect.Metric> factoryAction = null) : ResourceFactory<Humidifier.Connect.Metric>(resourceName)
{

    internal InnerMetricMetricCalculationFactory MetricCalculationFactory { get; set; }

    protected override Humidifier.Connect.Metric Create()
    {
        var metricResult = CreateMetric();
        factoryAction?.Invoke(metricResult);

        return metricResult;
    }

    private Humidifier.Connect.Metric CreateMetric()
    {
        var metricResult = new Humidifier.Connect.Metric
        {
            GivenName = InputResourceName,
        };

        return metricResult;
    }
    public override void CreateChildren(Humidifier.Connect.Metric result)
    {
        base.CreateChildren(result);

        result.MetricCalculation ??= MetricCalculationFactory?.Build();
    }

} // End Of Class

public static class MetricFactoryExtensions
{
    public static CombinedResult<MetricFactory, InnerMetricMetricCalculationFactory> WithMetricCalculation(this MetricFactory parentFactory, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null)
    {
        parentFactory.MetricCalculationFactory = new InnerMetricMetricCalculationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricCalculationFactory);
    }

    public static CombinedResult<MetricFactory, T1, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1>(this CombinedResult<MetricFactory, T1> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricCalculation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricFactory, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1>(this CombinedResult<T1, MetricFactory> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricCalculation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MetricFactory, T1, T2, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2>(this CombinedResult<MetricFactory, T1, T2> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricFactory, T2, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2>(this CombinedResult<T1, MetricFactory, T2> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricFactory, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2>(this CombinedResult<T1, T2, MetricFactory> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MetricFactory, T1, T2, T3, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3>(this CombinedResult<MetricFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricFactory, T2, T3, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3>(this CombinedResult<T1, MetricFactory, T2, T3> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricFactory, T3, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3>(this CombinedResult<T1, T2, MetricFactory, T3> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetricFactory, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3>(this CombinedResult<T1, T2, T3, MetricFactory> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MetricFactory, T1, T2, T3, T4, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3, T4>(this CombinedResult<MetricFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MetricFactory, T2, T3, T4, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3, T4>(this CombinedResult<T1, MetricFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MetricFactory, T3, T4, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3, T4>(this CombinedResult<T1, T2, MetricFactory, T3, T4> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MetricFactory, T4, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MetricFactory, T4> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MetricFactory, InnerMetricMetricCalculationFactory> WithMetricCalculation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MetricFactory> combinedResult, Action<Humidifier.Connect.MetricTypes.MetricCalculation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricCalculation(combinedResult.T5, subFactoryAction).T2);
}
