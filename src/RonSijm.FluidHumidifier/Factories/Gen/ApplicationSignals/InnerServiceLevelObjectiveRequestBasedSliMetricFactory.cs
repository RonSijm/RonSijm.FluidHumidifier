// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveRequestBasedSliMetricFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric>
{

    internal InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory MonitoredRequestCountMetricFactory { get; set; }

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric Create()
    {
        var requestBasedSliMetricResult = CreateRequestBasedSliMetric();
        factoryAction?.Invoke(requestBasedSliMetricResult);

        return requestBasedSliMetricResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric CreateRequestBasedSliMetric()
    {
        var requestBasedSliMetricResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric();

        return requestBasedSliMetricResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric result)
    {
        base.CreateChildren(result);

        result.MonitoredRequestCountMetric ??= MonitoredRequestCountMetricFactory?.Build();
    }

} // End Of Class

public static class InnerServiceLevelObjectiveRequestBasedSliMetricFactoryExtensions
{
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric(this InnerServiceLevelObjectiveRequestBasedSliMetricFactory parentFactory, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null)
    {
        parentFactory.MonitoredRequestCountMetricFactory = new InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoredRequestCountMetricFactory);
    }

    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, T2, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T2, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, T2, T3, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T2, T3, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T3, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, T2, T3, T4, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3, T4>(this CombinedResult<InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T2, T3, T4, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T3, T4, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T4, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveRequestBasedSliMetricFactory, InnerServiceLevelObjectiveMonitoredRequestCountMetricFactory> WithMonitoredRequestCountMetric<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveRequestBasedSliMetricFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoredRequestCountMetric(combinedResult.T5, subFactoryAction));
}
