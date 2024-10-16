// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverQueryLoggingConfigAssociationFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverQueryLoggingConfigAssociation> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverQueryLoggingConfigAssociation>(resourceName)
{

    protected override Humidifier.Route53Resolver.ResolverQueryLoggingConfigAssociation Create()
    {
        var resolverQueryLoggingConfigAssociationResult = CreateResolverQueryLoggingConfigAssociation();
        factoryAction?.Invoke(resolverQueryLoggingConfigAssociationResult);

        return resolverQueryLoggingConfigAssociationResult;
    }

    private Humidifier.Route53Resolver.ResolverQueryLoggingConfigAssociation CreateResolverQueryLoggingConfigAssociation()
    {
        var resolverQueryLoggingConfigAssociationResult = new Humidifier.Route53Resolver.ResolverQueryLoggingConfigAssociation
        {
            GivenName = InputResourceName,
        };

        return resolverQueryLoggingConfigAssociationResult;
    }

} // End Of Class

public static class ResolverQueryLoggingConfigAssociationFactoryExtensions
{
}
