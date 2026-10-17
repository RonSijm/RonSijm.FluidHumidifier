// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class InnerFirewallRuleGroupPartnerThreatProtectionConfigFactory(Action<Humidifier.Route53Resolver.FirewallRuleGroupTypes.PartnerThreatProtectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53Resolver.FirewallRuleGroupTypes.PartnerThreatProtectionConfig>
{

    protected override Humidifier.Route53Resolver.FirewallRuleGroupTypes.PartnerThreatProtectionConfig Create()
    {
        var partnerThreatProtectionConfigResult = CreatePartnerThreatProtectionConfig();
        factoryAction?.Invoke(partnerThreatProtectionConfigResult);

        return partnerThreatProtectionConfigResult;
    }

    private Humidifier.Route53Resolver.FirewallRuleGroupTypes.PartnerThreatProtectionConfig CreatePartnerThreatProtectionConfig()
    {
        var partnerThreatProtectionConfigResult = new Humidifier.Route53Resolver.FirewallRuleGroupTypes.PartnerThreatProtectionConfig();

        return partnerThreatProtectionConfigResult;
    }

} // End Of Class

public static class InnerFirewallRuleGroupPartnerThreatProtectionConfigFactoryExtensions
{
}
