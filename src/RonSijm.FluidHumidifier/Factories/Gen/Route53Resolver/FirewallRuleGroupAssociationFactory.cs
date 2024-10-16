// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class FirewallRuleGroupAssociationFactory(string resourceName = null, Action<Humidifier.Route53Resolver.FirewallRuleGroupAssociation> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroupAssociation>(resourceName)
{

    protected override Humidifier.Route53Resolver.FirewallRuleGroupAssociation Create()
    {
        var firewallRuleGroupAssociationResult = CreateFirewallRuleGroupAssociation();
        factoryAction?.Invoke(firewallRuleGroupAssociationResult);

        return firewallRuleGroupAssociationResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroupAssociation CreateFirewallRuleGroupAssociation()
    {
        var firewallRuleGroupAssociationResult = new Humidifier.Route53Resolver.FirewallRuleGroupAssociation
        {
            GivenName = InputResourceName,
        };

        return firewallRuleGroupAssociationResult;
    }

} // End Of Class

public static class FirewallRuleGroupAssociationFactoryExtensions
{
}
