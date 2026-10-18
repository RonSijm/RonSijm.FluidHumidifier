// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerNetworkInterfacePrivateIpAddressSpecificationFactory(Action<Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification>
{

    protected override Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification Create()
    {
        var privateIpAddressSpecificationResult = CreatePrivateIpAddressSpecification();
        factoryAction?.Invoke(privateIpAddressSpecificationResult);

        return privateIpAddressSpecificationResult;
    }

    private Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification CreatePrivateIpAddressSpecification()
    {
        var privateIpAddressSpecificationResult = new Humidifier.EC2.NetworkInterfaceTypes.PrivateIpAddressSpecification();

        return privateIpAddressSpecificationResult;
    }

} // End Of Class

public static class InnerNetworkInterfacePrivateIpAddressSpecificationFactoryExtensions
{
}
