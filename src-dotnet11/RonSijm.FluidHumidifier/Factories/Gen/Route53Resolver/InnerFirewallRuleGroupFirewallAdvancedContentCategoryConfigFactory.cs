// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerFirewallRuleGroupFirewallAdvancedContentCategoryConfigFactory(Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedContentCategoryConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedContentCategoryConfig>
{

    protected override Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedContentCategoryConfig Create()
    {
        var firewallAdvancedContentCategoryConfigResult = CreateFirewallAdvancedContentCategoryConfig();
        factoryAction?.Invoke(firewallAdvancedContentCategoryConfigResult);

        return firewallAdvancedContentCategoryConfigResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedContentCategoryConfig CreateFirewallAdvancedContentCategoryConfig()
    {
        var firewallAdvancedContentCategoryConfigResult = new Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedContentCategoryConfig();

        return firewallAdvancedContentCategoryConfigResult;
    }

} // End Of Class

public static class InnerFirewallRuleGroupFirewallAdvancedContentCategoryConfigFactoryExtensions
{
}
