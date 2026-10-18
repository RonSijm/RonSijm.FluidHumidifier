// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerServiceNetworkVpcAssociationDnsOptionsFactory(Action<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions>
{

    protected override Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions Create()
    {
        var dnsOptionsResult = CreateDnsOptions();
        factoryAction?.Invoke(dnsOptionsResult);

        return dnsOptionsResult;
    }

    private Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions CreateDnsOptions()
    {
        var dnsOptionsResult = new Humidifier.VpcLattice.ServiceNetworkVpcAssociationTypes.DnsOptions();

        return dnsOptionsResult;
    }

} // End Of Class

public static class InnerServiceNetworkVpcAssociationDnsOptionsFactoryExtensions
{
}
