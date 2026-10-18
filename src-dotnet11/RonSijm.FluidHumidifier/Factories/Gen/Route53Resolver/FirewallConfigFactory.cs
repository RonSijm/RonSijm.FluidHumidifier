// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class FirewallConfigFactory(string resourceName = null, Action<Humidifier.Route53Resolver.FirewallConfig> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.FirewallConfig>(resourceName)
{

    protected override Humidifier.Route53Resolver.FirewallConfig Create()
    {
        var firewallConfigResult = CreateFirewallConfig();
        factoryAction?.Invoke(firewallConfigResult);

        return firewallConfigResult;
    }

    private Humidifier.Route53Resolver.FirewallConfig CreateFirewallConfig()
    {
        var firewallConfigResult = new Humidifier.Route53Resolver.FirewallConfig
        {
            GivenName = InputResourceName,
        };

        return firewallConfigResult;
    }

} // End Of Class

public static class FirewallConfigFactoryExtensions
{
}
