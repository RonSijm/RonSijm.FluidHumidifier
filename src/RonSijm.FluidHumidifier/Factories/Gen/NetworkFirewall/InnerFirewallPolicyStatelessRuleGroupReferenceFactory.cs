// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyStatelessRuleGroupReferenceFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference>
{

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference Create()
    {
        var statelessRuleGroupReferenceResult = CreateStatelessRuleGroupReference();
        factoryAction?.Invoke(statelessRuleGroupReferenceResult);

        return statelessRuleGroupReferenceResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference CreateStatelessRuleGroupReference()
    {
        var statelessRuleGroupReferenceResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference();

        return statelessRuleGroupReferenceResult;
    }

} // End Of Class

public static class InnerFirewallPolicyStatelessRuleGroupReferenceFactoryExtensions
{
}
