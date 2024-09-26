// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstancePrivateDnsNameOptionsFactory(Action<Humidifier.EC2.InstanceTypes.PrivateDnsNameOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.PrivateDnsNameOptions>
{

    protected override Humidifier.EC2.InstanceTypes.PrivateDnsNameOptions Create()
    {
        var privateDnsNameOptionsResult = CreatePrivateDnsNameOptions();
        factoryAction?.Invoke(privateDnsNameOptionsResult);

        return privateDnsNameOptionsResult;
    }

    private Humidifier.EC2.InstanceTypes.PrivateDnsNameOptions CreatePrivateDnsNameOptions()
    {
        var privateDnsNameOptionsResult = new Humidifier.EC2.InstanceTypes.PrivateDnsNameOptions();

        return privateDnsNameOptionsResult;
    }

} // End Of Class

public static class InnerInstancePrivateDnsNameOptionsFactoryExtensions
{
}
