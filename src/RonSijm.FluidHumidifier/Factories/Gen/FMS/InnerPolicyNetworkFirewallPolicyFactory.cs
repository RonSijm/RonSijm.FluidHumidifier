// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerPolicyNetworkFirewallPolicyFactory(Action<Humidifier.FMS.PolicyTypes.NetworkFirewallPolicy> factoryAction = null) : SubResourceFactory<Humidifier.FMS.PolicyTypes.NetworkFirewallPolicy>
{

    protected override Humidifier.FMS.PolicyTypes.NetworkFirewallPolicy Create()
    {
        var networkFirewallPolicyResult = CreateNetworkFirewallPolicy();
        factoryAction?.Invoke(networkFirewallPolicyResult);

        return networkFirewallPolicyResult;
    }

    private Humidifier.FMS.PolicyTypes.NetworkFirewallPolicy CreateNetworkFirewallPolicy()
    {
        var networkFirewallPolicyResult = new Humidifier.FMS.PolicyTypes.NetworkFirewallPolicy();

        return networkFirewallPolicyResult;
    }

} // End Of Class

public static class InnerPolicyNetworkFirewallPolicyFactoryExtensions
{
}
