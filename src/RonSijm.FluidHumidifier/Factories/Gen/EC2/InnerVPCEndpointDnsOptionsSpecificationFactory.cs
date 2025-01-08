// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPCEndpointDnsOptionsSpecificationFactory(Action<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification>
{

    protected override Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification Create()
    {
        var dnsOptionsSpecificationResult = CreateDnsOptionsSpecification();
        factoryAction?.Invoke(dnsOptionsSpecificationResult);

        return dnsOptionsSpecificationResult;
    }

    private Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification CreateDnsOptionsSpecification()
    {
        var dnsOptionsSpecificationResult = new Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification();

        return dnsOptionsSpecificationResult;
    }

} // End Of Class

public static class InnerVPCEndpointDnsOptionsSpecificationFactoryExtensions
{
}
