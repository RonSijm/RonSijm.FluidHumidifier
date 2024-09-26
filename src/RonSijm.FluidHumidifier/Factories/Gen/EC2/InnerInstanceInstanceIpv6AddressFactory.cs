// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceInstanceIpv6AddressFactory(Action<Humidifier.EC2.InstanceTypes.InstanceIpv6Address> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.InstanceIpv6Address>
{

    protected override Humidifier.EC2.InstanceTypes.InstanceIpv6Address Create()
    {
        var instanceIpv6AddressResult = CreateInstanceIpv6Address();
        factoryAction?.Invoke(instanceIpv6AddressResult);

        return instanceIpv6AddressResult;
    }

    private Humidifier.EC2.InstanceTypes.InstanceIpv6Address CreateInstanceIpv6Address()
    {
        var instanceIpv6AddressResult = new Humidifier.EC2.InstanceTypes.InstanceIpv6Address();

        return instanceIpv6AddressResult;
    }

} // End Of Class

public static class InnerInstanceInstanceIpv6AddressFactoryExtensions
{
}
