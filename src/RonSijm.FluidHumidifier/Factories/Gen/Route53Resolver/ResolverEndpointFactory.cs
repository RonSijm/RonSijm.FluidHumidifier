// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverEndpointFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverEndpoint> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverEndpoint>(resourceName)
{

    internal List<InnerResolverEndpointIpAddressRequestFactory> IpAddressesFactories { get; set; } = [];

    protected override Humidifier.Route53Resolver.ResolverEndpoint Create()
    {
        var resolverEndpointResult = CreateResolverEndpoint();
        factoryAction?.Invoke(resolverEndpointResult);

        return resolverEndpointResult;
    }

    private Humidifier.Route53Resolver.ResolverEndpoint CreateResolverEndpoint()
    {
        var resolverEndpointResult = new Humidifier.Route53Resolver.ResolverEndpoint
        {
            GivenName = InputResourceName,
        };

        return resolverEndpointResult;
    }
    public override void CreateChildren(Humidifier.Route53Resolver.ResolverEndpoint result)
    {
        base.CreateChildren(result);

        result.IpAddresses = IpAddressesFactories.Any() ? IpAddressesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ResolverEndpointFactoryExtensions
{
    public static CombinedResult<ResolverEndpointFactory, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses(this ResolverEndpointFactory parentFactory, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null)
    {
        var factory = new InnerResolverEndpointIpAddressRequestFactory(subFactoryAction);
        parentFactory.IpAddressesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ResolverEndpointFactory, T1, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1>(this CombinedResult<ResolverEndpointFactory, T1> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverEndpointFactory, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1>(this CombinedResult<T1, ResolverEndpointFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResolverEndpointFactory, T1, T2, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2>(this CombinedResult<ResolverEndpointFactory, T1, T2> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverEndpointFactory, T2, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2>(this CombinedResult<T1, ResolverEndpointFactory, T2> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverEndpointFactory, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2>(this CombinedResult<T1, T2, ResolverEndpointFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResolverEndpointFactory, T1, T2, T3, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<ResolverEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverEndpointFactory, T2, T3, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<T1, ResolverEndpointFactory, T2, T3> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverEndpointFactory, T3, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<T1, T2, ResolverEndpointFactory, T3> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverEndpointFactory, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResolverEndpointFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResolverEndpointFactory, T1, T2, T3, T4, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<ResolverEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResolverEndpointFactory, T2, T3, T4, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, ResolverEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResolverEndpointFactory, T3, T4, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResolverEndpointFactory, T3, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResolverEndpointFactory, T4, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResolverEndpointFactory, T4> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResolverEndpointFactory, InnerResolverEndpointIpAddressRequestFactory> WithIpAddresses<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResolverEndpointFactory> combinedResult, Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIpAddresses(combinedResult.T5, subFactoryAction));
}
