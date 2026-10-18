// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class OutpostResolverFactory(string resourceName = null, Action<Humidifier.Route53Resolver.OutpostResolver> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.OutpostResolver>(resourceName)
{

    protected override Humidifier.Route53Resolver.OutpostResolver Create()
    {
        var outpostResolverResult = CreateOutpostResolver();
        factoryAction?.Invoke(outpostResolverResult);

        return outpostResolverResult;
    }

    private Humidifier.Route53Resolver.OutpostResolver CreateOutpostResolver()
    {
        var outpostResolverResult = new Humidifier.Route53Resolver.OutpostResolver
        {
            GivenName = InputResourceName,
        };

        return outpostResolverResult;
    }

} // End Of Class

public static class OutpostResolverFactoryExtensions
{
}
