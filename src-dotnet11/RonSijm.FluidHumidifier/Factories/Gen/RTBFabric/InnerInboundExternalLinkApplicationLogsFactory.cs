// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerInboundExternalLinkApplicationLogsFactory(Action<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs>
{

    internal InnerInboundExternalLinkLinkApplicationLogSamplingFactory LinkApplicationLogSamplingFactory { get; set; }

    protected override Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs Create()
    {
        var applicationLogsResult = CreateApplicationLogs();
        factoryAction?.Invoke(applicationLogsResult);

        return applicationLogsResult;
    }

    private Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs CreateApplicationLogs()
    {
        var applicationLogsResult = new Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs();

        return applicationLogsResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.InboundExternalLinkTypes.ApplicationLogs result)
    {
        base.CreateChildren(result);

        result.LinkApplicationLogSampling ??= LinkApplicationLogSamplingFactory?.Build();
    }

} // End Of Class

public static class InnerInboundExternalLinkApplicationLogsFactoryExtensions
{
    public static CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling(this InnerInboundExternalLinkApplicationLogsFactory parentFactory, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null)
    {
        parentFactory.LinkApplicationLogSamplingFactory = new InnerInboundExternalLinkLinkApplicationLogSamplingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkApplicationLogSamplingFactory);
    }

    public static CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1>(this CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1>(this CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, T2, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, T2, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, T2> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInboundExternalLinkApplicationLogsFactory, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<T1, T2, InnerInboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, T2, T3, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, T2, T3, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInboundExternalLinkApplicationLogsFactory, T3, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, T2, InnerInboundExternalLinkApplicationLogsFactory, T3> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInboundExternalLinkApplicationLogsFactory, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, T2, T3, T4, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<InnerInboundExternalLinkApplicationLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, T2, T3, T4, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, InnerInboundExternalLinkApplicationLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInboundExternalLinkApplicationLogsFactory, T3, T4, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInboundExternalLinkApplicationLogsFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInboundExternalLinkApplicationLogsFactory, T4, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInboundExternalLinkApplicationLogsFactory, T4> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInboundExternalLinkApplicationLogsFactory, InnerInboundExternalLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInboundExternalLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T5, subFactoryAction).T2);
}
