// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerSecurityProfileMetricToRetainFactory(Action<Humidifier.IoT.SecurityProfileTypes.MetricToRetain> factoryAction = null) : SubResourceFactory<Humidifier.IoT.SecurityProfileTypes.MetricToRetain>
{

    internal InnerSecurityProfileMetricDimensionFactory MetricDimensionFactory { get; set; }

    protected override Humidifier.IoT.SecurityProfileTypes.MetricToRetain Create()
    {
        var metricToRetainResult = CreateMetricToRetain();
        factoryAction?.Invoke(metricToRetainResult);

        return metricToRetainResult;
    }

    private Humidifier.IoT.SecurityProfileTypes.MetricToRetain CreateMetricToRetain()
    {
        var metricToRetainResult = new Humidifier.IoT.SecurityProfileTypes.MetricToRetain();

        return metricToRetainResult;
    }
    public override void CreateChildren(Humidifier.IoT.SecurityProfileTypes.MetricToRetain result)
    {
        base.CreateChildren(result);

        result.MetricDimension ??= MetricDimensionFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityProfileMetricToRetainFactoryExtensions
{
    public static CombinedResult<InnerSecurityProfileMetricToRetainFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension(this InnerSecurityProfileMetricToRetainFactory parentFactory, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null)
    {
        parentFactory.MetricDimensionFactory = new InnerSecurityProfileMetricDimensionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetricDimensionFactory);
    }

    public static CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1>(this CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1>(this CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, T2, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2>(this CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, T2> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, T2, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2>(this CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, T2> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileMetricToRetainFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2>(this CombinedResult<T1, T2, InnerSecurityProfileMetricToRetainFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, T2, T3, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, T2, T3, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, T2, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileMetricToRetainFactory, T3, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityProfileMetricToRetainFactory, T3> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileMetricToRetainFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityProfileMetricToRetainFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, T2, T3, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<InnerSecurityProfileMetricToRetainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, T2, T3, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityProfileMetricToRetainFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSecurityProfileMetricToRetainFactory, T3, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityProfileMetricToRetainFactory, T3, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSecurityProfileMetricToRetainFactory, T4, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityProfileMetricToRetainFactory, T4> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityProfileMetricToRetainFactory, InnerSecurityProfileMetricDimensionFactory> WithMetricDimension<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityProfileMetricToRetainFactory> combinedResult, Action<Humidifier.IoT.SecurityProfileTypes.MetricDimension> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetricDimension(combinedResult.T5, subFactoryAction));
}
