// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53GlobalResolver;

public class DnsViewFactory(string resourceName = null, Action<Humidifier.Route53GlobalResolver.DnsView> factoryAction = null) : ResourceFactory<Humidifier.Route53GlobalResolver.DnsView>(resourceName)
{

    protected override Humidifier.Route53GlobalResolver.DnsView Create()
    {
        var dnsViewResult = CreateDnsView();
        factoryAction?.Invoke(dnsViewResult);

        return dnsViewResult;
    }

    private Humidifier.Route53GlobalResolver.DnsView CreateDnsView()
    {
        var dnsViewResult = new Humidifier.Route53GlobalResolver.DnsView
        {
            GivenName = InputResourceName,
        };

        return dnsViewResult;
    }

} // End Of Class

public static class DnsViewFactoryExtensions
{
}
