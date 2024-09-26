// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeDnsServiceDiscoveryFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery>
{

    protected override Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery Create()
    {
        var dnsServiceDiscoveryResult = CreateDnsServiceDiscovery();
        factoryAction?.Invoke(dnsServiceDiscoveryResult);

        return dnsServiceDiscoveryResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery CreateDnsServiceDiscovery()
    {
        var dnsServiceDiscoveryResult = new Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery();

        return dnsServiceDiscoveryResult;
    }

} // End Of Class

public static class InnerVirtualNodeDnsServiceDiscoveryFactoryExtensions
{
}
