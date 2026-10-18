// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateNetworkInterfaceCountFactory(Action<Humidifier.EC2.LaunchTemplateTypes.NetworkInterfaceCount> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.NetworkInterfaceCount>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.NetworkInterfaceCount Create()
    {
        var networkInterfaceCountResult = CreateNetworkInterfaceCount();
        factoryAction?.Invoke(networkInterfaceCountResult);

        return networkInterfaceCountResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.NetworkInterfaceCount CreateNetworkInterfaceCount()
    {
        var networkInterfaceCountResult = new Humidifier.EC2.LaunchTemplateTypes.NetworkInterfaceCount();

        return networkInterfaceCountResult;
    }

} // End Of Class

public static class InnerLaunchTemplateNetworkInterfaceCountFactoryExtensions
{
}
