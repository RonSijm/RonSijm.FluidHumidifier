// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInterfaceIpv4PrefixSpecificationFactory(Action<Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification>
{

    protected override Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification Create()
    {
        var ipv4PrefixSpecificationResult = CreateIpv4PrefixSpecification();
        factoryAction?.Invoke(ipv4PrefixSpecificationResult);

        return ipv4PrefixSpecificationResult;
    }

    private Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification CreateIpv4PrefixSpecification()
    {
        var ipv4PrefixSpecificationResult = new Humidifier.EC2.NetworkInterfaceTypes.Ipv4PrefixSpecification();

        return ipv4PrefixSpecificationResult;
    }

} // End Of Class

public static class InnerNetworkInterfaceIpv4PrefixSpecificationFactoryExtensions
{
}
