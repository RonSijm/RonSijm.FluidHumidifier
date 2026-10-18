// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInterfaceIpv6PrefixSpecificationFactory(Action<Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification>
{

    protected override Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification Create()
    {
        var ipv6PrefixSpecificationResult = CreateIpv6PrefixSpecification();
        factoryAction?.Invoke(ipv6PrefixSpecificationResult);

        return ipv6PrefixSpecificationResult;
    }

    private Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification CreateIpv6PrefixSpecification()
    {
        var ipv6PrefixSpecificationResult = new Humidifier.EC2.NetworkInterfaceTypes.Ipv6PrefixSpecification();

        return ipv6PrefixSpecificationResult;
    }

} // End Of Class

public static class InnerNetworkInterfaceIpv6PrefixSpecificationFactoryExtensions
{
}
