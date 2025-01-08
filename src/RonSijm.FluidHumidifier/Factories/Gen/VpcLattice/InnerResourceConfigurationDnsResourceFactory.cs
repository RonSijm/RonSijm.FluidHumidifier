// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerResourceConfigurationDnsResourceFactory(Action<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource>
{

    protected override Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource Create()
    {
        var dnsResourceResult = CreateDnsResource();
        factoryAction?.Invoke(dnsResourceResult);

        return dnsResourceResult;
    }

    private Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource CreateDnsResource()
    {
        var dnsResourceResult = new Humidifier.VpcLattice.ResourceConfigurationTypes.DnsResource();

        return dnsResourceResult;
    }

} // End Of Class

public static class InnerResourceConfigurationDnsResourceFactoryExtensions
{
}
