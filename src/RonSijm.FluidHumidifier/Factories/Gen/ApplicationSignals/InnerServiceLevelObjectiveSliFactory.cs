// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveSliFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli>
{

    internal InnerServiceLevelObjectiveSliMetricFactory SliMetricFactory { get; set; }

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli Create()
    {
        var sliResult = CreateSli();
        factoryAction?.Invoke(sliResult);

        return sliResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli CreateSli()
    {
        var sliResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli();

        return sliResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli result)
    {
        base.CreateChildren(result);

        result.SliMetric ??= SliMetricFactory?.Build();
    }

} // End Of Class

public static class InnerServiceLevelObjectiveSliFactoryExtensions
{
    public static CombinedResult<InnerServiceLevelObjectiveSliFactory, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric(this InnerServiceLevelObjectiveSliFactory parentFactory, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null)
    {
        parentFactory.SliMetricFactory = new InnerServiceLevelObjectiveSliMetricFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SliMetricFactory);
    }

    public static CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1>(this CombinedResult<InnerServiceLevelObjectiveSliFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, WithSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1>(this CombinedResult<T1, InnerServiceLevelObjectiveSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, WithSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, T2, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2>(this CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, T2, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2>(this CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveSliFactory, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, T2, T3, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3>(this CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, T2, T3, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3>(this CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveSliFactory, T3, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveSliFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveSliFactory, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, T2, T3, T4, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3, T4>(this CombinedResult<InnerServiceLevelObjectiveSliFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, T2, T3, T4, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceLevelObjectiveSliFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveSliFactory, T3, T4, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveSliFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveSliFactory, T4, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveSliFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveSliFactory, InnerServiceLevelObjectiveSliMetricFactory> WithSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSliMetric(combinedResult.T5, subFactoryAction));
}
