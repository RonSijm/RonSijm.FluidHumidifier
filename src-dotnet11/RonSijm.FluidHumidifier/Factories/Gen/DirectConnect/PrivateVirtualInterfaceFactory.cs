// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DirectConnect;

public class PrivateVirtualInterfaceFactory(string resourceName = null, Action<Humidifier.DirectConnect.PrivateVirtualInterface> factoryAction = null) : ResourceFactory<Humidifier.DirectConnect.PrivateVirtualInterface>(resourceName)
{

    internal List<InnerPrivateVirtualInterfaceBgpPeerFactory> BgpPeersFactories { get; set; } = [];

    protected override Humidifier.DirectConnect.PrivateVirtualInterface Create()
    {
        var privateVirtualInterfaceResult = CreatePrivateVirtualInterface();
        factoryAction?.Invoke(privateVirtualInterfaceResult);

        return privateVirtualInterfaceResult;
    }

    private Humidifier.DirectConnect.PrivateVirtualInterface CreatePrivateVirtualInterface()
    {
        var privateVirtualInterfaceResult = new Humidifier.DirectConnect.PrivateVirtualInterface
        {
            GivenName = InputResourceName,
        };

        return privateVirtualInterfaceResult;
    }
    public override void CreateChildren(Humidifier.DirectConnect.PrivateVirtualInterface result)
    {
        base.CreateChildren(result);

        result.BgpPeers = BgpPeersFactories.Any() ? BgpPeersFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class PrivateVirtualInterfaceFactoryExtensions
{
    public static CombinedResult<PrivateVirtualInterfaceFactory, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers(this PrivateVirtualInterfaceFactory parentFactory, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null)
    {
        var factory = new InnerPrivateVirtualInterfaceBgpPeerFactory(subFactoryAction);
        parentFactory.BgpPeersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PrivateVirtualInterfaceFactory, T1, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1>(this CombinedResult<PrivateVirtualInterfaceFactory, T1> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateVirtualInterfaceFactory, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1>(this CombinedResult<T1, PrivateVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PrivateVirtualInterfaceFactory, T1, T2, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<PrivateVirtualInterfaceFactory, T1, T2> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateVirtualInterfaceFactory, T2, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<T1, PrivateVirtualInterfaceFactory, T2> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateVirtualInterfaceFactory, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2>(this CombinedResult<T1, T2, PrivateVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PrivateVirtualInterfaceFactory, T1, T2, T3, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<PrivateVirtualInterfaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateVirtualInterfaceFactory, T2, T3, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, PrivateVirtualInterfaceFactory, T2, T3> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateVirtualInterfaceFactory, T3, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, T2, PrivateVirtualInterfaceFactory, T3> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PrivateVirtualInterfaceFactory, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3>(this CombinedResult<T1, T2, T3, PrivateVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PrivateVirtualInterfaceFactory, T1, T2, T3, T4, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<PrivateVirtualInterfaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PrivateVirtualInterfaceFactory, T2, T3, T4, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, PrivateVirtualInterfaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PrivateVirtualInterfaceFactory, T3, T4, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, PrivateVirtualInterfaceFactory, T3, T4> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PrivateVirtualInterfaceFactory, T4, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PrivateVirtualInterfaceFactory, T4> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PrivateVirtualInterfaceFactory, InnerPrivateVirtualInterfaceBgpPeerFactory> WithBgpPeers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PrivateVirtualInterfaceFactory> combinedResult, Action<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpPeers(combinedResult.T5, subFactoryAction).T2);
}
