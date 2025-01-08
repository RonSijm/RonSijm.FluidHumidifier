// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeBridgeNetworkSourceFactory(Action<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource>
{

    internal InnerBridgeMulticastSourceSettingsFactory MulticastSourceSettingsFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource Create()
    {
        var bridgeNetworkSourceResult = CreateBridgeNetworkSource();
        factoryAction?.Invoke(bridgeNetworkSourceResult);

        return bridgeNetworkSourceResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource CreateBridgeNetworkSource()
    {
        var bridgeNetworkSourceResult = new Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource();

        return bridgeNetworkSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeTypes.BridgeNetworkSource result)
    {
        base.CreateChildren(result);

        result.MulticastSourceSettings ??= MulticastSourceSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeBridgeNetworkSourceFactoryExtensions
{
    public static CombinedResult<InnerBridgeBridgeNetworkSourceFactory, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings(this InnerBridgeBridgeNetworkSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null)
    {
        parentFactory.MulticastSourceSettingsFactory = new InnerBridgeMulticastSourceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MulticastSourceSettingsFactory);
    }

    public static CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1>(this CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1>(this CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, T2, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2>(this CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, T2, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2>(this CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeNetworkSourceFactory, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2>(this CombinedResult<T1, T2, InnerBridgeBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, T2, T3, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, T2, T3, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeNetworkSourceFactory, T3, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeBridgeNetworkSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeNetworkSourceFactory, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, T2, T3, T4, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<InnerBridgeBridgeNetworkSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, T2, T3, T4, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeBridgeNetworkSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeNetworkSourceFactory, T3, T4, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeBridgeNetworkSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeNetworkSourceFactory, T4, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeNetworkSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeNetworkSourceFactory, InnerBridgeMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T5, subFactoryAction));
}
