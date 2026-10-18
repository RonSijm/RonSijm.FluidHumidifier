// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyStatefulRuleGroupOverrideFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride>
{

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride Create()
    {
        var statefulRuleGroupOverrideResult = CreateStatefulRuleGroupOverride();
        factoryAction?.Invoke(statefulRuleGroupOverrideResult);

        return statefulRuleGroupOverrideResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride CreateStatefulRuleGroupOverride()
    {
        var statefulRuleGroupOverrideResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride();

        return statefulRuleGroupOverrideResult;
    }

} // End Of Class

public static class InnerFirewallPolicyStatefulRuleGroupOverrideFactoryExtensions
{
}
