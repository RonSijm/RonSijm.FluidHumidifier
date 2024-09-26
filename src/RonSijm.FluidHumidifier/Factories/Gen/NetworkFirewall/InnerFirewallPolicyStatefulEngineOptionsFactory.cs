// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerFirewallPolicyStatefulEngineOptionsFactory(Action<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions>
{

    protected override Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions Create()
    {
        var statefulEngineOptionsResult = CreateStatefulEngineOptions();
        factoryAction?.Invoke(statefulEngineOptionsResult);

        return statefulEngineOptionsResult;
    }

    private Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions CreateStatefulEngineOptions()
    {
        var statefulEngineOptionsResult = new Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions();

        return statefulEngineOptionsResult;
    }

} // End Of Class

public static class InnerFirewallPolicyStatefulEngineOptionsFactoryExtensions
{
}
