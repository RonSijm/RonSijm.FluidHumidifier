// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class FirewallRuleFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.FirewallRule> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.FirewallRule>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.FirewallRule Create()
    {
        var firewallRuleResult = CreateFirewallRule();
        factoryAction?.Invoke(firewallRuleResult);

        return firewallRuleResult;
    }

    private Humidifier.Route53GlobalResolver.FirewallRule CreateFirewallRule()
    {
        var firewallRuleResult = new Humidifier.Route53GlobalResolver.FirewallRule
        {
            GivenName = InputResourceName,
        };

        return firewallRuleResult;
    }

} // End Of Class

public static class FirewallRuleFactoryExtensions
{
}
