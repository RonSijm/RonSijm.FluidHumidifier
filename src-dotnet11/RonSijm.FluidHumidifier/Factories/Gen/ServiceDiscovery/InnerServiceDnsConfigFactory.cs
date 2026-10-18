// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerServiceDnsConfigFactory(Action<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig>
{

    protected override Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig Create()
    {
        var dnsConfigResult = CreateDnsConfig();
        factoryAction?.Invoke(dnsConfigResult);

        return dnsConfigResult;
    }

    private Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig CreateDnsConfig()
    {
        var dnsConfigResult = new Humidifier.ServiceDiscovery.ServiceTypes.DnsConfig();

        return dnsConfigResult;
    }

} // End Of Class

public static class InnerServiceDnsConfigFactoryExtensions
{
}
