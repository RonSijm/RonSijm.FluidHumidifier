// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class ResolverRuleAssociationFactory(string resourceName = null, Action<Humidifier.Route53Resolver.ResolverRuleAssociation> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.ResolverRuleAssociation>(resourceName)
{

    protected override Humidifier.Route53Resolver.ResolverRuleAssociation Create()
    {
        var resolverRuleAssociationResult = CreateResolverRuleAssociation();
        factoryAction?.Invoke(resolverRuleAssociationResult);

        return resolverRuleAssociationResult;
    }

    private Humidifier.Route53Resolver.ResolverRuleAssociation CreateResolverRuleAssociation()
    {
        var resolverRuleAssociationResult = new Humidifier.Route53Resolver.ResolverRuleAssociation
        {
            GivenName = InputResourceName,
        };

        return resolverRuleAssociationResult;
    }

} // End Of Class

public static class ResolverRuleAssociationFactoryExtensions
{
}
