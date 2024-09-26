// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class BridgeSourceFactory(string resourceName = null, Action<Humidifier.MediaConnect.BridgeSource> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.BridgeSource>(resourceName)
{

    internal InnerBridgeSourceBridgeNetworkSourceFactory NetworkSourceFactory { get; set; }

    internal InnerBridgeSourceBridgeFlowSourceFactory FlowSourceFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeSource Create()
    {
        var bridgeSourceResult = CreateBridgeSource();
        factoryAction?.Invoke(bridgeSourceResult);

        return bridgeSourceResult;
    }

    private Humidifier.MediaConnect.BridgeSource CreateBridgeSource()
    {
        var bridgeSourceResult = new Humidifier.MediaConnect.BridgeSource
        {
            GivenName = InputResourceName,
        };

        return bridgeSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeSource result)
    {
        base.CreateChildren(result);

        result.NetworkSource ??= NetworkSourceFactory?.Build();
        result.FlowSource ??= FlowSourceFactory?.Build();
    }

} // End Of Class

public static class BridgeSourceFactoryExtensions
{
    public static CombinedResult<BridgeSourceFactory, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource(this BridgeSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null)
    {
        parentFactory.NetworkSourceFactory = new InnerBridgeSourceBridgeNetworkSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkSourceFactory);
    }

    public static CombinedResult<BridgeSourceFactory, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource(this BridgeSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null)
    {
        parentFactory.FlowSourceFactory = new InnerBridgeSourceBridgeFlowSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlowSourceFactory);
    }

    public static CombinedResult<BridgeSourceFactory, T1, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1>(this CombinedResult<BridgeSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1>(this CombinedResult<T1, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2>(this CombinedResult<BridgeSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, T2, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2>(this CombinedResult<T1, BridgeSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeSourceFactory, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2>(this CombinedResult<T1, T2, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, T2, T3, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<BridgeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, T2, T3, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<T1, BridgeSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeSourceFactory, T3, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<T1, T2, BridgeSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeSourceFactory, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, T2, T3, T4, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<BridgeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, T2, T3, T4, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, BridgeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeSourceFactory, T3, T4, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeSourceFactory, T4, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeSourceFactory, InnerBridgeSourceBridgeNetworkSourceFactory> WithNetworkSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1>(this CombinedResult<BridgeSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1>(this CombinedResult<T1, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, T2, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2>(this CombinedResult<BridgeSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, T2, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2>(this CombinedResult<T1, BridgeSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeSourceFactory, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2>(this CombinedResult<T1, T2, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, T2, T3, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<BridgeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, T2, T3, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<T1, BridgeSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeSourceFactory, T3, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<T1, T2, BridgeSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeSourceFactory, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BridgeSourceFactory, T1, T2, T3, T4, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<BridgeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BridgeSourceFactory, T2, T3, T4, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, BridgeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BridgeSourceFactory, T3, T4, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, BridgeSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BridgeSourceFactory, T4, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BridgeSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BridgeSourceFactory, InnerBridgeSourceBridgeFlowSourceFactory> WithFlowSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowSource(combinedResult.T5, subFactoryAction));
}
