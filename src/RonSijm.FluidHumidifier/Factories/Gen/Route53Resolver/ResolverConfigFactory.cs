// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverConfigFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverConfig> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverConfig>(resourceName)
{

    protected override Humidifier.Route53Resolver.ResolverConfig Create()
    {
        var resolverConfigResult = CreateResolverConfig();
        factoryAction?.Invoke(resolverConfigResult);

        return resolverConfigResult;
    }

    private Humidifier.Route53Resolver.ResolverConfig CreateResolverConfig()
    {
        var resolverConfigResult = new Humidifier.Route53Resolver.ResolverConfig
        {
            GivenName = InputResourceName,
        };

        return resolverConfigResult;
    }

} // End Of Class

public static class ResolverConfigFactoryExtensions
{
}
