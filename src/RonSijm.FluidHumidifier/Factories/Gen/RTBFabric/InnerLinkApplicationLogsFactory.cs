// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkApplicationLogsFactory(Action<Humidifier.RTBFabric.LinkTypes.ApplicationLogs> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.ApplicationLogs>
{

    internal InnerLinkLinkApplicationLogSamplingFactory LinkApplicationLogSamplingFactory { get; set; }

    protected override Humidifier.RTBFabric.LinkTypes.ApplicationLogs Create()
    {
        var applicationLogsResult = CreateApplicationLogs();
        factoryAction?.Invoke(applicationLogsResult);

        return applicationLogsResult;
    }

    private Humidifier.RTBFabric.LinkTypes.ApplicationLogs CreateApplicationLogs()
    {
        var applicationLogsResult = new Humidifier.RTBFabric.LinkTypes.ApplicationLogs();

        return applicationLogsResult;
    }
    public override void CreateChildren(Humidifier.RTBFabric.LinkTypes.ApplicationLogs result)
    {
        base.CreateChildren(result);

        result.LinkApplicationLogSampling ??= LinkApplicationLogSamplingFactory?.Build();
    }

} // End Of Class

public static class InnerLinkApplicationLogsFactoryExtensions
{
    public static CombinedResult<InnerLinkApplicationLogsFactory, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling(this InnerLinkApplicationLogsFactory parentFactory, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null)
    {
        parentFactory.LinkApplicationLogSamplingFactory = new InnerLinkLinkApplicationLogSamplingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LinkApplicationLogSamplingFactory);
    }

    public static CombinedResult<InnerLinkApplicationLogsFactory, T1, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1>(this CombinedResult<InnerLinkApplicationLogsFactory, T1> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkApplicationLogsFactory, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1>(this CombinedResult<T1, InnerLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLinkApplicationLogsFactory, T1, T2, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<InnerLinkApplicationLogsFactory, T1, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkApplicationLogsFactory, T2, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<T1, InnerLinkApplicationLogsFactory, T2> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkApplicationLogsFactory, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2>(this CombinedResult<T1, T2, InnerLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLinkApplicationLogsFactory, T1, T2, T3, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<InnerLinkApplicationLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkApplicationLogsFactory, T2, T3, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, InnerLinkApplicationLogsFactory, T2, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkApplicationLogsFactory, T3, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, T2, InnerLinkApplicationLogsFactory, T3> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkApplicationLogsFactory, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLinkApplicationLogsFactory, T1, T2, T3, T4, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<InnerLinkApplicationLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLinkApplicationLogsFactory, T2, T3, T4, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, InnerLinkApplicationLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLinkApplicationLogsFactory, T3, T4, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLinkApplicationLogsFactory, T3, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLinkApplicationLogsFactory, T4, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLinkApplicationLogsFactory, T4> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLinkApplicationLogsFactory, InnerLinkLinkApplicationLogSamplingFactory> WithLinkApplicationLogSampling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLinkApplicationLogsFactory> combinedResult, Action<Humidifier.RTBFabric.LinkTypes.LinkApplicationLogSampling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLinkApplicationLogSampling(combinedResult.T5, subFactoryAction).T2);
}
