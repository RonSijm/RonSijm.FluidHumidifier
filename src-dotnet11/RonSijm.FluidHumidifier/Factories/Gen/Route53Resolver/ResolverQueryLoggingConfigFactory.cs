// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverQueryLoggingConfigFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverQueryLoggingConfig> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverQueryLoggingConfig>(resourceName)
{

    protected override Humidifier.Route53Resolver.ResolverQueryLoggingConfig Create()
    {
        var resolverQueryLoggingConfigResult = CreateResolverQueryLoggingConfig();
        factoryAction?.Invoke(resolverQueryLoggingConfigResult);

        return resolverQueryLoggingConfigResult;
    }

    private Humidifier.Route53Resolver.ResolverQueryLoggingConfig CreateResolverQueryLoggingConfig()
    {
        var resolverQueryLoggingConfigResult = new Humidifier.Route53Resolver.ResolverQueryLoggingConfig
        {
            GivenName = InputResourceName,
        };

        return resolverQueryLoggingConfigResult;
    }

} // End Of Class

public static class ResolverQueryLoggingConfigFactoryExtensions
{
}
