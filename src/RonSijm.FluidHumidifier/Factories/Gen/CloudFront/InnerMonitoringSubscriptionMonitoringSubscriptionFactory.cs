// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerMonitoringSubscriptionMonitoringSubscriptionFactory(Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription>
{

    internal InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory RealtimeMetricsSubscriptionConfigFactory { get; set; }

    protected override Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription Create()
    {
        var monitoringSubscriptionResult = CreateMonitoringSubscription();
        factoryAction?.Invoke(monitoringSubscriptionResult);

        return monitoringSubscriptionResult;
    }

    private Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription CreateMonitoringSubscription()
    {
        var monitoringSubscriptionResult = new Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription();

        return monitoringSubscriptionResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription result)
    {
        base.CreateChildren(result);

        result.RealtimeMetricsSubscriptionConfig ??= RealtimeMetricsSubscriptionConfigFactory?.Build();
    }

} // End Of Class

public static class InnerMonitoringSubscriptionMonitoringSubscriptionFactoryExtensions
{
    public static CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig(this InnerMonitoringSubscriptionMonitoringSubscriptionFactory parentFactory, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null)
    {
        parentFactory.RealtimeMetricsSubscriptionConfigFactory = new InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RealtimeMetricsSubscriptionConfigFactory);
    }

    public static CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1>(this CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1>(this CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, T2, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2>(this CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T2, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2>(this CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T2> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2>(this CombinedResult<T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, T2, T3, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3>(this CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T2, T3, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3>(this CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T3, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T3> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, T2, T3, T4, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3, T4>(this CombinedResult<InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T2, T3, T4, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T3, T4, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T4, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, T4> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMonitoringSubscriptionMonitoringSubscriptionFactory, InnerMonitoringSubscriptionRealtimeMetricsSubscriptionConfigFactory> WithRealtimeMetricsSubscriptionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMonitoringSubscriptionMonitoringSubscriptionFactory> combinedResult, Action<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealtimeMetricsSubscriptionConfig(combinedResult.T5, subFactoryAction));
}
