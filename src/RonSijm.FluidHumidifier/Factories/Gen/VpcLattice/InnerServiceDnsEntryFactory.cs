// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerServiceDnsEntryFactory(Action<Humidifier.VpcLattice.ServiceTypes.DnsEntry> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ServiceTypes.DnsEntry>
{

    protected override Humidifier.VpcLattice.ServiceTypes.DnsEntry Create()
    {
        var dnsEntryResult = CreateDnsEntry();
        factoryAction?.Invoke(dnsEntryResult);

        return dnsEntryResult;
    }

    private Humidifier.VpcLattice.ServiceTypes.DnsEntry CreateDnsEntry()
    {
        var dnsEntryResult = new Humidifier.VpcLattice.ServiceTypes.DnsEntry();

        return dnsEntryResult;
    }

} // End Of Class

public static class InnerServiceDnsEntryFactoryExtensions
{
}
