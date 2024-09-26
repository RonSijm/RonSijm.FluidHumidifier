// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class ConnectPeerFactory(string resourceName = null, Action<Humidifier.NetworkManager.ConnectPeer> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.ConnectPeer>(resourceName)
{

    internal InnerConnectPeerBgpOptionsFactory BgpOptionsFactory { get; set; }

    protected override Humidifier.NetworkManager.ConnectPeer Create()
    {
        var connectPeerResult = CreateConnectPeer();
        factoryAction?.Invoke(connectPeerResult);

        return connectPeerResult;
    }

    private Humidifier.NetworkManager.ConnectPeer CreateConnectPeer()
    {
        var connectPeerResult = new Humidifier.NetworkManager.ConnectPeer
        {
            GivenName = InputResourceName,
        };

        return connectPeerResult;
    }
    public override void CreateChildren(Humidifier.NetworkManager.ConnectPeer result)
    {
        base.CreateChildren(result);

        result.BgpOptions ??= BgpOptionsFactory?.Build();
    }

} // End Of Class

public static class ConnectPeerFactoryExtensions
{
    public static CombinedResult<ConnectPeerFactory, InnerConnectPeerBgpOptionsFactory> WithBgpOptions(this ConnectPeerFactory parentFactory, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null)
    {
        parentFactory.BgpOptionsFactory = new InnerConnectPeerBgpOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BgpOptionsFactory);
    }

    public static CombinedResult<ConnectPeerFactory, T1, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1>(this CombinedResult<ConnectPeerFactory, T1> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectPeerFactory, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1>(this CombinedResult<T1, ConnectPeerFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConnectPeerFactory, T1, T2, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2>(this CombinedResult<ConnectPeerFactory, T1, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectPeerFactory, T2, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2>(this CombinedResult<T1, ConnectPeerFactory, T2> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectPeerFactory, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2>(this CombinedResult<T1, T2, ConnectPeerFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConnectPeerFactory, T1, T2, T3, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<ConnectPeerFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectPeerFactory, T2, T3, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<T1, ConnectPeerFactory, T2, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectPeerFactory, T3, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<T1, T2, ConnectPeerFactory, T3> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectPeerFactory, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectPeerFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConnectPeerFactory, T1, T2, T3, T4, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<ConnectPeerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConnectPeerFactory, T2, T3, T4, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, ConnectPeerFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConnectPeerFactory, T3, T4, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectPeerFactory, T3, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConnectPeerFactory, T4, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectPeerFactory, T4> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConnectPeerFactory, InnerConnectPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectPeerFactory> combinedResult, Action<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T5, subFactoryAction));
}
