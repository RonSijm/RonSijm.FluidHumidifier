// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeFailoverConfigFactory(Action<Humidifier.MediaConnect.BridgeTypes.FailoverConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.FailoverConfig>
{

    internal InnerBridgeSourcePriorityFactory SourcePriorityFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeTypes.FailoverConfig Create()
    {
        var failoverConfigResult = CreateFailoverConfig();
        factoryAction?.Invoke(failoverConfigResult);

        return failoverConfigResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.FailoverConfig CreateFailoverConfig()
    {
        var failoverConfigResult = new Humidifier.MediaConnect.BridgeTypes.FailoverConfig();

        return failoverConfigResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeTypes.FailoverConfig result)
    {
        base.CreateChildren(result);

        result.SourcePriority ??= SourcePriorityFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeFailoverConfigFactoryExtensions
{
    public static CombinedResult<InnerBridgeFailoverConfigFactory, InnerBridgeSourcePriorityFactory> WithSourcePriority(this InnerBridgeFailoverConfigFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null)
    {
        parentFactory.SourcePriorityFactory = new InnerBridgeSourcePriorityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourcePriorityFactory);
    }

    public static CombinedResult<InnerBridgeFailoverConfigFactory, T1, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1>(this CombinedResult<InnerBridgeFailoverConfigFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeFailoverConfigFactory, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1>(this CombinedResult<T1, InnerBridgeFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeFailoverConfigFactory, T1, T2, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2>(this CombinedResult<InnerBridgeFailoverConfigFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeFailoverConfigFactory, T2, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2>(this CombinedResult<T1, InnerBridgeFailoverConfigFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeFailoverConfigFactory, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2>(this CombinedResult<T1, T2, InnerBridgeFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeFailoverConfigFactory, T1, T2, T3, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<InnerBridgeFailoverConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeFailoverConfigFactory, T2, T3, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<T1, InnerBridgeFailoverConfigFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeFailoverConfigFactory, T3, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeFailoverConfigFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeFailoverConfigFactory, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeFailoverConfigFactory, T1, T2, T3, T4, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<InnerBridgeFailoverConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeFailoverConfigFactory, T2, T3, T4, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeFailoverConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeFailoverConfigFactory, T3, T4, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeFailoverConfigFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeFailoverConfigFactory, T4, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeFailoverConfigFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeFailoverConfigFactory, InnerBridgeSourcePriorityFactory> WithSourcePriority<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeFailoverConfigFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.SourcePriority> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourcePriority(combinedResult.T5, subFactoryAction));
}
