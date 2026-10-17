// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyFlowTimeoutsFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts>
{

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts Create()
    {
        var flowTimeoutsResult = CreateFlowTimeouts();
        factoryAction?.Invoke(flowTimeoutsResult);

        return flowTimeoutsResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts CreateFlowTimeouts()
    {
        var flowTimeoutsResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts();

        return flowTimeoutsResult;
    }

} // End Of Class

public static class InnerFirewallPolicyFlowTimeoutsFactoryExtensions
{
}
