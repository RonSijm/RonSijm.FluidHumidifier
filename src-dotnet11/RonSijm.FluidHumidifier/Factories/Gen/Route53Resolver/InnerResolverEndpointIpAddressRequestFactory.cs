// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerResolverEndpointIpAddressRequestFactory(Action<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest>
{

    protected override Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest Create()
    {
        var ipAddressRequestResult = CreateIpAddressRequest();
        factoryAction?.Invoke(ipAddressRequestResult);

        return ipAddressRequestResult;
    }

    private Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest CreateIpAddressRequest()
    {
        var ipAddressRequestResult = new Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest();

        return ipAddressRequestResult;
    }

} // End Of Class

public static class InnerResolverEndpointIpAddressRequestFactoryExtensions
{
}
