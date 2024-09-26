// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveRequestBasedSliFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli>
{

    internal InnerServiceLevelObjectiveRequestBasedSliMetricFactory RequestBasedSliMetricFactory { get; set; }

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli Create()
    {
        var requestBasedSliResult = CreateRequestBasedSli();
        factoryAction?.Invoke(requestBasedSliResult);

        return requestBasedSliResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli CreateRequestBasedSli()
    {
        var requestBasedSliResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli();

        return requestBasedSliResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli result)
    {
        base.CreateChildren(result);

        result.RequestBasedSliMetric ??= RequestBasedSliMetricFactory?.Build();
    }

} // End Of Class

public static class InnerServiceLevelObjectiveRequestBasedSliFactoryExtensions
{
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric(this InnerServiceLevelObjectiveRequestBasedSliFactory parentFactory, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null)
    {
        parentFactory.RequestBasedSliMetricFactory = new InnerServiceLevelObjectiveRequestBasedSliMetricFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RequestBasedSliMetricFactory);
    }

    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliFactory, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, T2, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliFactory, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliFactory, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, T2, T3, T4, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3, T4>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, T2, T3, T4, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliFactory, T3, T4, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliFactory, T4, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveRequestBasedSliFactory, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> WithRequestBasedSliMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveRequestBasedSliFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRequestBasedSliMetric(combinedResult.T5, subFactoryAction));
}
