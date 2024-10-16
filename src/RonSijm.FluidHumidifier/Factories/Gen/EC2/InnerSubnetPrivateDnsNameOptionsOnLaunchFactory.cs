// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSubnetPrivateDnsNameOptionsOnLaunchFactory(Action<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch>
{

    protected override Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch Create()
    {
        var privateDnsNameOptionsOnLaunchResult = CreatePrivateDnsNameOptionsOnLaunch();
        factoryAction?.Invoke(privateDnsNameOptionsOnLaunchResult);

        return privateDnsNameOptionsOnLaunchResult;
    }

    private Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch CreatePrivateDnsNameOptionsOnLaunch()
    {
        var privateDnsNameOptionsOnLaunchResult = new Humidifier.EC2.SubnetTypes.PrivateDnsNameOptionsOnLaunch();

        return privateDnsNameOptionsOnLaunchResult;
    }

} // End Of Class

public static class InnerSubnetPrivateDnsNameOptionsOnLaunchFactoryExtensions
{
}
