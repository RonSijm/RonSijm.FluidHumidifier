// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class FirewallDomainListFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.FirewallDomainList> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.FirewallDomainList>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.FirewallDomainList Create()
    {
        var firewallDomainListResult = CreateFirewallDomainList();
        factoryAction?.Invoke(firewallDomainListResult);

        return firewallDomainListResult;
    }

    private Humidifier.Route53GlobalResolver.FirewallDomainList CreateFirewallDomainList()
    {
        var firewallDomainListResult = new Humidifier.Route53GlobalResolver.FirewallDomainList
        {
            GivenName = InputResourceName,
        };

        return firewallDomainListResult;
    }

} // End Of Class

public static class FirewallDomainListFactoryExtensions
{
}
