// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteServerPeerFactory(string resourceName = null, Action<Humidifier.EC2.RouteServerPeer> factoryAction = null) : ResourceFactory<Humidifier.EC2.RouteServerPeer>(resourceName)
{

    internal InnerRouteServerPeerBgpOptionsFactory BgpOptionsFactory { get; set; }

    protected override Humidifier.EC2.RouteServerPeer Create()
    {
        var routeServerPeerResult = CreateRouteServerPeer();
        factoryAction?.Invoke(routeServerPeerResult);

        return routeServerPeerResult;
    }

    private Humidifier.EC2.RouteServerPeer CreateRouteServerPeer()
    {
        var routeServerPeerResult = new Humidifier.EC2.RouteServerPeer
        {
            GivenName = InputResourceName,
        };

        return routeServerPeerResult;
    }
    public override void CreateChildren(Humidifier.EC2.RouteServerPeer result)
    {
        base.CreateChildren(result);

        result.BgpOptions ??= BgpOptionsFactory?.Build();
    }

} // End Of Class

public static class RouteServerPeerFactoryExtensions
{
    public static CombinedResult<RouteServerPeerFactory, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions(this RouteServerPeerFactory parentFactory, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null)
    {
        parentFactory.BgpOptionsFactory = new InnerRouteServerPeerBgpOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BgpOptionsFactory);
    }

    public static CombinedResult<RouteServerPeerFactory, T1, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1>(this CombinedResult<RouteServerPeerFactory, T1> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouteServerPeerFactory, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1>(this CombinedResult<T1, RouteServerPeerFactory> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RouteServerPeerFactory, T1, T2, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2>(this CombinedResult<RouteServerPeerFactory, T1, T2> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouteServerPeerFactory, T2, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2>(this CombinedResult<T1, RouteServerPeerFactory, T2> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RouteServerPeerFactory, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2>(this CombinedResult<T1, T2, RouteServerPeerFactory> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RouteServerPeerFactory, T1, T2, T3, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<RouteServerPeerFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouteServerPeerFactory, T2, T3, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<T1, RouteServerPeerFactory, T2, T3> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RouteServerPeerFactory, T3, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<T1, T2, RouteServerPeerFactory, T3> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RouteServerPeerFactory, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, RouteServerPeerFactory> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RouteServerPeerFactory, T1, T2, T3, T4, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<RouteServerPeerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RouteServerPeerFactory, T2, T3, T4, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, RouteServerPeerFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RouteServerPeerFactory, T3, T4, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, RouteServerPeerFactory, T3, T4> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RouteServerPeerFactory, T4, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RouteServerPeerFactory, T4> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RouteServerPeerFactory, InnerRouteServerPeerBgpOptionsFactory> WithBgpOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RouteServerPeerFactory> combinedResult, Action<Humidifier.EC2.RouteServerPeerTypes.BgpOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBgpOptions(combinedResult.T5, subFactoryAction).T2);
}
