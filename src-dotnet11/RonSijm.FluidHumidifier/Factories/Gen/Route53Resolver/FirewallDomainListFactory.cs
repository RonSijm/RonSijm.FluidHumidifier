// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53Resolver;

public class FirewallDomainListFactory(string resourceName = null, Action<Humidifier.Route53Resolver.FirewallDomainList> factoryAction = null) : ResourceFactory<Humidifier.Route53Resolver.FirewallDomainList>(resourceName)
{

    protected override Humidifier.Route53Resolver.FirewallDomainList Create()
    {
        var firewallDomainListResult = CreateFirewallDomainList();
        factoryAction?.Invoke(firewallDomainListResult);

        return firewallDomainListResult;
    }

    private Humidifier.Route53Resolver.FirewallDomainList CreateFirewallDomainList()
    {
        var firewallDomainListResult = new Humidifier.Route53Resolver.FirewallDomainList
        {
            GivenName = InputResourceName,
        };

        return firewallDomainListResult;
    }

} // End Of Class

public static class FirewallDomainListFactoryExtensions
{
}
