// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class CoreDeviceFactory(string resourceName = null, Action<Humidifier.GreengrassV2.CoreDevice> factoryAction = null) : ResourceFactory<Humidifier.GreengrassV2.CoreDevice>(resourceName)
{

    protected override Humidifier.GreengrassV2.CoreDevice Create()
    {
        var coreDeviceResult = CreateCoreDevice();
        factoryAction?.Invoke(coreDeviceResult);

        return coreDeviceResult;
    }

    private Humidifier.GreengrassV2.CoreDevice CreateCoreDevice()
    {
        var coreDeviceResult = new Humidifier.GreengrassV2.CoreDevice
        {
            GivenName = InputResourceName,
        };

        return coreDeviceResult;
    }

} // End Of Class

public static class CoreDeviceFactoryExtensions
{
}
