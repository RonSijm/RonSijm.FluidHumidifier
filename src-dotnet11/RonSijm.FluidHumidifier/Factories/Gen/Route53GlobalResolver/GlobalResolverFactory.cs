// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class GlobalResolverFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.GlobalResolver> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.GlobalResolver>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.GlobalResolver Create()
    {
        var globalResolverResult = CreateGlobalResolver();
        factoryAction?.Invoke(globalResolverResult);

        return globalResolverResult;
    }

    private Humidifier.Route53GlobalResolver.GlobalResolver CreateGlobalResolver()
    {
        var globalResolverResult = new Humidifier.Route53GlobalResolver.GlobalResolver
        {
            GivenName = InputResourceName,
        };

        return globalResolverResult;
    }

} // End Of Class

public static class GlobalResolverFactoryExtensions
{
}
