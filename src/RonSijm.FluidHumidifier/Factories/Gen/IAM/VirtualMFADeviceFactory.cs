// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class VirtualMFADeviceFactory(string resourceName = null, Action<Humidifier.IAM.VirtualMFADevice> factoryAction = null) : ResourceFactory<Humidifier.IAM.VirtualMFADevice>(resourceName)
{

    protected override Humidifier.IAM.VirtualMFADevice Create()
    {
        var virtualMFADeviceResult = CreateVirtualMFADevice();
        factoryAction?.Invoke(virtualMFADeviceResult);

        return virtualMFADeviceResult;
    }

    private Humidifier.IAM.VirtualMFADevice CreateVirtualMFADevice()
    {
        var virtualMFADeviceResult = new Humidifier.IAM.VirtualMFADevice
        {
            GivenName = InputResourceName,
        };

        return virtualMFADeviceResult;
    }

} // End Of Class

public static class VirtualMFADeviceFactoryExtensions
{
}
