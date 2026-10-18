// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerFirewallRuleGroupFirewallAdvancedThreatCategoryConfigFactory(Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedThreatCategoryConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedThreatCategoryConfig>
{

    protected override Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedThreatCategoryConfig Create()
    {
        var firewallAdvancedThreatCategoryConfigResult = CreateFirewallAdvancedThreatCategoryConfig();
        factoryAction?.Invoke(firewallAdvancedThreatCategoryConfigResult);

        return firewallAdvancedThreatCategoryConfigResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedThreatCategoryConfig CreateFirewallAdvancedThreatCategoryConfig()
    {
        var firewallAdvancedThreatCategoryConfigResult = new Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedThreatCategoryConfig();

        return firewallAdvancedThreatCategoryConfigResult;
    }

} // End Of Class

public static class InnerFirewallRuleGroupFirewallAdvancedThreatCategoryConfigFactoryExtensions
{
}
