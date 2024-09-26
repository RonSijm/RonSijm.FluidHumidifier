// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeBridgeSourceFactory(Action<Humidifier.MediaConnect.BridgeTypes.BridgeSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.BridgeSource>
{

    internal InnerBridgeBridgeNetworkSourceFactory NetworkSourceFactory { get; set; }

    internal InnerBridgeBridgeFlowSourceFactory FlowSourceFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeTypes.BridgeSource Create()
    {
        var bridgeSourceResult = CreateBridgeSource();
        factoryAction?.Invoke(bridgeSourceResult);

        return bridgeSourceResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.BridgeSource CreateBridgeSource()
    {
        var bridgeSourceResult = new Humidifier.MediaConnect.BridgeTypes.BridgeSource();

        return bridgeSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeTypes.BridgeSource result)
    {
        base.CreateChildren(result);

        result.NetworkSource ??= NetworkSourceFactory?.Build();
        result.FlowSource ??= FlowSourceFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeBridgeSourceFactoryExtensions
{
    public static CombinedResult<InnerBridgeBridgeSourceFactory, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource(this InnerBridgeBridgeSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null)
    {
        parentFactory.NetworkSourceFactory = new InnerBridgeBridgeNetworkSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkSourceFactory);
    }

    public static CombinedResult<InnerBridgeBridgeSourceFactory, InnerBridgeBridgeFlowSourceFactory> WithFlowSource(this InnerBridgeBridgeSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null)
    {
        parentFactory.FlowSourceFactory = new InnerBridgeBridgeFlowSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlowSourceFactory);
    }

    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2>(this CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3, T4, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3, T4, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3, T4, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory, T4, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2>(this CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3, T4, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<InnerBridgeBridgeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3, T4, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeBridgeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3, T4, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeBridgeSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory, T4, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeSourceFactory, InnerBridgeBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T5, subFactoryAction));
}
