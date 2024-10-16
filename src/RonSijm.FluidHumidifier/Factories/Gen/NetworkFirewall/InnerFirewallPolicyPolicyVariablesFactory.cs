// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyPolicyVariablesFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PolicyVariables> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.PolicyVariables>
{

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.PolicyVariables Create()
    {
        var policyVariablesResult = CreatePolicyVariables();
        factoryAction?.Invoke(policyVariablesResult);

        return policyVariablesResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.PolicyVariables CreatePolicyVariables()
    {
        var policyVariablesResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.PolicyVariables();

        return policyVariablesResult;
    }

} // End Of Class

public static class InnerFirewallPolicyPolicyVariablesFactoryExtensions
{
}
