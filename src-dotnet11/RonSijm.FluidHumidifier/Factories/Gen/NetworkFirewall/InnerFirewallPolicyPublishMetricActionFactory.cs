// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyPublishMetricActionFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction>
{

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction Create()
    {
        var publishMetricActionResult = CreatePublishMetricAction();
        factoryAction?.Invoke(publishMetricActionResult);

        return publishMetricActionResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction CreatePublishMetricAction()
    {
        var publishMetricActionResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction();

        return publishMetricActionResult;
    }

} // End Of Class

public static class InnerFirewallPolicyPublishMetricActionFactoryExtensions
{
}
