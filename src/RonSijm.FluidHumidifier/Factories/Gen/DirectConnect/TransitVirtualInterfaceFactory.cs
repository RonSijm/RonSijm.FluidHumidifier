// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class TransitVirtualInterfaceFactory(string resourceName = null, Action<Humidifier.DirectConnect.TransitVirtualInterface> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.TransitVirtualInterface>(resourceName)
{

    internal List<InnerTransitVirtualInterfaceBgpPeerFactory> BgpPeersFactories { get; set; } = [];

    protected override Humidifier.DirectConnect.TransitVirtualInterface Create()
    {
        var transitVirtualInterfaceResult = CreateTransitVirtualInterface();
        factoryAction?.Invoke(transitVirtualInterfaceResult);

        return transitVirtualInterfaceResult;
    }

    private Humidifier.DirectConnect.TransitVirtualInterface CreateTransitVirtualInterface()
    {
        var transitVirtualInterfaceResult = new Humidifier.DirectConnect.TransitVirtualInterface
        {
            GivenName = InputResourceName,
        };

        return transitVirtualInterfaceResult;
    }
    public override void CreateChildren(Humidifier.DirectConnect.TransitVirtualInterface result)
    {
        base.CreateChildren(result);

        result.BgpPeers = BgpPeersFactories.Any() ? BgpPeersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TransitVirtualInterfaceFactoryExtensions
{
    public static CombinedResult<TransitVirtualInterfaceFactory, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers(this TransitVirtualInterfaceFactory parentFactory, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null)
    {
        var factory = new InnerTransitVirtualInterfaceBgpPeerFactory(subFactoryAction);
        parentFactory.BgpPeersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TransitVirtualInterfaceFactory, T1, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1>(this CombinedResult<TransitVirtualInterfaceFactory, T1> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitVirtualInterfaceFactory, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1>(this CombinedResult<T1, TransitVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TransitVirtualInterfaceFactory, T1, T2, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<TransitVirtualInterfaceFactory, T1, T2> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitVirtualInterfaceFactory, T2, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<T1, TransitVirtualInterfaceFactory, T2> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitVirtualInterfaceFactory, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<T1, T2, TransitVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TransitVirtualInterfaceFactory, T1, T2, T3, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<TransitVirtualInterfaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitVirtualInterfaceFactory, T2, T3, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, TransitVirtualInterfaceFactory, T2, T3> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitVirtualInterfaceFactory, T3, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, T2, TransitVirtualInterfaceFactory, T3> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitVirtualInterfaceFactory, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, T2, T3, TransitVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TransitVirtualInterfaceFactory, T1, T2, T3, T4, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<TransitVirtualInterfaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TransitVirtualInterfaceFactory, T2, T3, T4, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, TransitVirtualInterfaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TransitVirtualInterfaceFactory, T3, T4, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, TransitVirtualInterfaceFactory, T3, T4> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TransitVirtualInterfaceFactory, T4, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TransitVirtualInterfaceFactory, T4> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TransitVirtualInterfaceFactory, InnerTransitVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TransitVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T5, subFactoryAction).T2);
}
