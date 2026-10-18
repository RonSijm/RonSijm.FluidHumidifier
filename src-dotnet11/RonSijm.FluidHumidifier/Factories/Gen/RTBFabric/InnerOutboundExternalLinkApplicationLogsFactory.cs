// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerOutboundExternalLinkApplicationLogsFactory(Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs>
{

    internal InnerOutboundExternalLinkLinkApplicationLogSamplingFactory LinkApplicationLogSamplingFactory { get; set; }

    protected override Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs Create()
    {
        var applicationLogsResult = CreateApplicationLogs();
        factoryAction?.Invoke(applicationLogsResult);

        return applicationLogsResult;
    }

    private Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs CreateApplicationLogs()
    {
        var applicationLogsResult = new Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs();

        return applicationLogsResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.OutboundExternalLinkTypes.ApplicationLogs result)
    {
        base.CreateChildren(result);

        result.LinkApplicationLogSampling ??= LinkApplicationLogSamplingFactory?.Build();
    }

} // End Of Class

public static class InnerOutboundExternalLinkApplicationLogsFactoryExtensions
{
    public static CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling(this InnerOutboundExternalLinkApplicationLogsFactory parentFactory, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null)
    {
        parentFactory.LinkApplicationLogSamplingFactory = new InnerOutboundExternalLinkLinkApplicationLogSamplingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkApplicationLogSamplingFactory);
    }

    public static CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1>(this CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1>(this CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, T2, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, T2, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, T2> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOutboundExternalLinkApplicationLogsFactory, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<T1, T2, InnerOutboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, T2, T3, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, T2, T3, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOutboundExternalLinkApplicationLogsFactory, T3, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, T2, InnerOutboundExternalLinkApplicationLogsFactory, T3> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOutboundExternalLinkApplicationLogsFactory, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOutboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, T2, T3, T4, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<InnerOutboundExternalLinkApplicationLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, T2, T3, T4, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, InnerOutboundExternalLinkApplicationLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOutboundExternalLinkApplicationLogsFactory, T3, T4, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOutboundExternalLinkApplicationLogsFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOutboundExternalLinkApplicationLogsFactory, T4, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOutboundExternalLinkApplicationLogsFactory, T4> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOutboundExternalLinkApplicationLogsFactory, InnerOutboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOutboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T5, subFactoryAction).T2);
}
