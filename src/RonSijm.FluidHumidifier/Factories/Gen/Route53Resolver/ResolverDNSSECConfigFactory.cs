// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverDNSSECConfigFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverDNSSECConfig> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverDNSSECConfig>(resourceName)
{

    protected override Humidifier.Route53Resolver.ResolverDNSSECConfig Create()
    {
        var resolverDNSSECConfigResult = CreateResolverDNSSECConfig();
        factoryAction?.Invoke(resolverDNSSECConfigResult);

        return resolverDNSSECConfigResult;
    }

    private Humidifier.Route53Resolver.ResolverDNSSECConfig CreateResolverDNSSECConfig()
    {
        var resolverDNSSECConfigResult = new Humidifier.Route53Resolver.ResolverDNSSECConfig
        {
            GivenName = InputResourceName,
        };

        return resolverDNSSECConfigResult;
    }

} // End Of Class

public static class ResolverDNSSECConfigFactoryExtensions
{
}
