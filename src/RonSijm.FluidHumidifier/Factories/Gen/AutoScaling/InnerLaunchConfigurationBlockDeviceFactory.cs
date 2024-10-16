// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerLaunchConfigurationBlockDeviceFactory(Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice>
{

    protected override Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice Create()
    {
        var blockDeviceResult = CreateBlockDevice();
        factoryAction?.Invoke(blockDeviceResult);

        return blockDeviceResult;
    }

    private Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice CreateBlockDevice()
    {
        var blockDeviceResult = new Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice();

        return blockDeviceResult;
    }

} // End Of Class

public static class InnerLaunchConfigurationBlockDeviceFactoryExtensions
{
}
