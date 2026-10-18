// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerServiceNetworkServiceAssociationDnsEntryFactory(Action<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry>
{

    protected override Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry Create()
    {
        var dnsEntryResult = CreateDnsEntry();
        factoryAction?.Invoke(dnsEntryResult);

        return dnsEntryResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry CreateDnsEntry()
    {
        var dnsEntryResult = new Humidifier.VpcLattice.ServiceNetworkServiceAssociationTypes.DnsEntry();

        return dnsEntryResult;
    }

} // End Of Class

public static class InnerServiceNetworkServiceAssociationDnsEntryFactoryExtensions
{
}
