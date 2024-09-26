// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstancePrivateIpAddressSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification>
{

    protected override Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification Create()
    {
        var privateIpAddressSpecificationResult = CreatePrivateIpAddressSpecification();
        factoryAction?.Invoke(privateIpAddressSpecificationResult);

        return privateIpAddressSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification CreatePrivateIpAddressSpecification()
    {
        var privateIpAddressSpecificationResult = new Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification();

        return privateIpAddressSpecificationResult;
    }

} // End Of Class

public static class InnerInstancePrivateIpAddressSpecificationFactoryExtensions
{
}
