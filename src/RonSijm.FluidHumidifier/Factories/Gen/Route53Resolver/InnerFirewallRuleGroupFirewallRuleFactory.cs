// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerFirewallRuleGroupFirewallRuleFactory(Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule>
{

    protected override Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule Create()
    {
        var firewallRuleResult = CreateFirewallRule();
        factoryAction?.Invoke(firewallRuleResult);

        return firewallRuleResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule CreateFirewallRule()
    {
        var firewallRuleResult = new Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule();

        return firewallRuleResult;
    }

} // End Of Class

public static class InnerFirewallRuleGroupFirewallRuleFactoryExtensions
{
}
