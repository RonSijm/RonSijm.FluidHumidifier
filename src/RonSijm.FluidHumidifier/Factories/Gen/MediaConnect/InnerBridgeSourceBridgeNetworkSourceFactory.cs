// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeSourceBridgeNetworkSourceFactory(Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource>
{

    internal InnerBridgeSourceMulticastSourceSettingsFactory MulticastSourceSettingsFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource Create()
    {
        var bridgeNetworkSourceResult = CreateBridgeNetworkSource();
        factoryAction?.Invoke(bridgeNetworkSourceResult);

        return bridgeNetworkSourceResult;
    }

    private Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource CreateBridgeNetworkSource()
    {
        var bridgeNetworkSourceResult = new Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource();

        return bridgeNetworkSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource result)
    {
        base.CreateChildren(result);

        result.MulticastSourceSettings ??= MulticastSourceSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeSourceBridgeNetworkSourceFactoryExtensions
{
    public static CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings(this InnerBridgeSourceBridgeNetworkSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null)
    {
        parentFactory.MulticastSourceSettingsFactory = new InnerBridgeSourceMulticastSourceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MulticastSourceSettingsFactory);
    }

    public static CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1>(this CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1>(this CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, T2, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2>(this CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, T2, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2>(this CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2>(this CombinedResult<T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, T2, T3, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, T2, T3, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory, T3, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeNetworkSourceFactory, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, T2, T3, T4, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<InnerBridgeSourceBridgeNetworkSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, T2, T3, T4, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeSourceBridgeNetworkSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory, T3, T4, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeSourceBridgeNetworkSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeNetworkSourceFactory, T4, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeNetworkSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeSourceBridgeNetworkSourceFactory, InnerBridgeSourceMulticastSourceSettingsFactory> WithMulticastSourceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeSourceBridgeNetworkSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMulticastSourceSettings(combinedResult.T5, subFactoryAction));
}
