// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class PublicVirtualInterfaceFactory(string resourceName = null, Action<Humidifier.DirectConnect.PublicVirtualInterface> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.PublicVirtualInterface>(resourceName)
{

    internal List<InnerPublicVirtualInterfaceBgpPeerFactory> BgpPeersFactories { get; set; } = [];

    protected override Humidifier.DirectConnect.PublicVirtualInterface Create()
    {
        var publicVirtualInterfaceResult = CreatePublicVirtualInterface();
        factoryAction?.Invoke(publicVirtualInterfaceResult);

        return publicVirtualInterfaceResult;
    }

    private Humidifier.DirectConnect.PublicVirtualInterface CreatePublicVirtualInterface()
    {
        var publicVirtualInterfaceResult = new Humidifier.DirectConnect.PublicVirtualInterface
        {
            GivenName = InputResourceName,
        };

        return publicVirtualInterfaceResult;
    }
    public override void CreateChildren(Humidifier.DirectConnect.PublicVirtualInterface result)
    {
        base.CreateChildren(result);

        result.BgpPeers = BgpPeersFactories.Any() ? BgpPeersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PublicVirtualInterfaceFactoryExtensions
{
    public static CombinedResult<PublicVirtualInterfaceFactory, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers(this PublicVirtualInterfaceFactory parentFactory, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null)
    {
        var factory = new InnerPublicVirtualInterfaceBgpPeerFactory(subFactoryAction);
        parentFactory.BgpPeersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PublicVirtualInterfaceFactory, T1, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1>(this CombinedResult<PublicVirtualInterfaceFactory, T1> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublicVirtualInterfaceFactory, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1>(this CombinedResult<T1, PublicVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PublicVirtualInterfaceFactory, T1, T2, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<PublicVirtualInterfaceFactory, T1, T2> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublicVirtualInterfaceFactory, T2, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<T1, PublicVirtualInterfaceFactory, T2> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublicVirtualInterfaceFactory, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<T1, T2, PublicVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PublicVirtualInterfaceFactory, T1, T2, T3, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<PublicVirtualInterfaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublicVirtualInterfaceFactory, T2, T3, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, PublicVirtualInterfaceFactory, T2, T3> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublicVirtualInterfaceFactory, T3, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, T2, PublicVirtualInterfaceFactory, T3> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PublicVirtualInterfaceFactory, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, T2, T3, PublicVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PublicVirtualInterfaceFactory, T1, T2, T3, T4, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<PublicVirtualInterfaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PublicVirtualInterfaceFactory, T2, T3, T4, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, PublicVirtualInterfaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PublicVirtualInterfaceFactory, T3, T4, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, PublicVirtualInterfaceFactory, T3, T4> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PublicVirtualInterfaceFactory, T4, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PublicVirtualInterfaceFactory, T4> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PublicVirtualInterfaceFactory, InnerPublicVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PublicVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T5, subFactoryAction).T2);
}
