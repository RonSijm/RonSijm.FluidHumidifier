// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class NetworkFactory(string resourceName = null, Action<Humidifier.MediaLive.Network> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.Network>(resourceName)
{

    internal List<InnerNetworkIpPoolFactory> IpPoolsFactories { get; set; } = [];

    internal List<InnerNetworkRouteFactory> RoutesFactories { get; set; } = [];

    internal List<InnerNetworkTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.MediaLive.Network Create()
    {
        var networkResult = CreateNetwork();
        factoryAction?.Invoke(networkResult);

        return networkResult;
    }

    private Humidifier.MediaLive.Network CreateNetwork()
    {
        var networkResult = new Humidifier.MediaLive.Network
        {
            GivenName = InputResourceName,
        };

        return networkResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.Network result)
    {
        base.CreateChildren(result);

        result.IpPools = IpPoolsFactories.Any() ? IpPoolsFactories.Select(x => x.Build()).ToList() : null;
        result.Routes = RoutesFactories.Any() ? RoutesFactories.Select(x => x.Build()).ToList() : null;
        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class NetworkFactoryExtensions
{
    public static CombinedResult<NetworkFactory, InnerNetworkIpPoolFactory> WithIpPools(this NetworkFactory parentFactory, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null)
    {
        var factory = new InnerNetworkIpPoolFactory(subFactoryAction);
        parentFactory.IpPoolsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NetworkFactory, InnerNetworkRouteFactory> WithRoutes(this NetworkFactory parentFactory, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null)
    {
        var factory = new InnerNetworkRouteFactory(subFactoryAction);
        parentFactory.RoutesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NetworkFactory, InnerNetworkTagsFactory> WithTags(this NetworkFactory parentFactory, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerNetworkTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<NetworkFactory, T1, InnerNetworkIpPoolFactory> WithIpPools<T1>(this CombinedResult<NetworkFactory, T1> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpPools(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, InnerNetworkIpPoolFactory> WithIpPools<T1>(this CombinedResult<T1, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpPools(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, InnerNetworkIpPoolFactory> WithIpPools<T1, T2>(this CombinedResult<NetworkFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, InnerNetworkIpPoolFactory> WithIpPools<T1, T2>(this CombinedResult<T1, NetworkFactory, T2> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, InnerNetworkIpPoolFactory> WithIpPools<T1, T2>(this CombinedResult<T1, T2, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, T3, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3>(this CombinedResult<NetworkFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, T3, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3>(this CombinedResult<T1, NetworkFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, T3, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3>(this CombinedResult<T1, T2, NetworkFactory, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkFactory, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, T3, T4, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3, T4>(this CombinedResult<NetworkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, T3, T4, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3, T4>(this CombinedResult<T1, NetworkFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, T3, T4, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkFactory, T4, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkFactory, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkFactory, InnerNetworkIpPoolFactory> WithIpPools<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.IpPool> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpPools(combinedResult.T5, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, InnerNetworkRouteFactory> WithRoutes<T1>(this CombinedResult<NetworkFactory, T1> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, InnerNetworkRouteFactory> WithRoutes<T1>(this CombinedResult<T1, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, InnerNetworkRouteFactory> WithRoutes<T1, T2>(this CombinedResult<NetworkFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, InnerNetworkRouteFactory> WithRoutes<T1, T2>(this CombinedResult<T1, NetworkFactory, T2> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, InnerNetworkRouteFactory> WithRoutes<T1, T2>(this CombinedResult<T1, T2, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, T3, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3>(this CombinedResult<NetworkFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, T3, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3>(this CombinedResult<T1, NetworkFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, T3, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3>(this CombinedResult<T1, T2, NetworkFactory, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkFactory, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, T3, T4, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3, T4>(this CombinedResult<NetworkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, T3, T4, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3, T4>(this CombinedResult<T1, NetworkFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, T3, T4, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkFactory, T4, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkFactory, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkFactory, InnerNetworkRouteFactory> WithRoutes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Route> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, InnerNetworkTagsFactory> WithTags<T1>(this CombinedResult<NetworkFactory, T1> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, InnerNetworkTagsFactory> WithTags<T1>(this CombinedResult<T1, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, InnerNetworkTagsFactory> WithTags<T1, T2>(this CombinedResult<NetworkFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, InnerNetworkTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, NetworkFactory, T2> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, InnerNetworkTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, T3, InnerNetworkTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<NetworkFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, T3, InnerNetworkTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, NetworkFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, T3, InnerNetworkTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, NetworkFactory, T3> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkFactory, InnerNetworkTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NetworkFactory, T1, T2, T3, T4, InnerNetworkTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<NetworkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NetworkFactory, T2, T3, T4, InnerNetworkTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, NetworkFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NetworkFactory, T3, T4, InnerNetworkTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, NetworkFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NetworkFactory, T4, InnerNetworkTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NetworkFactory, T4> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NetworkFactory, InnerNetworkTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NetworkFactory> combinedResult, Action<Humidifier.MediaLive.NetworkTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
