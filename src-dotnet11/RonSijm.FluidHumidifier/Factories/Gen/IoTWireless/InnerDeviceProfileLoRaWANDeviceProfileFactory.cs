// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerDeviceProfileLoRaWANDeviceProfileFactory(Action<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile>
{

    protected override Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile Create()
    {
        var loRaWANDeviceProfileResult = CreateLoRaWANDeviceProfile();
        factoryAction?.Invoke(loRaWANDeviceProfileResult);

        return loRaWANDeviceProfileResult;
    }

    private Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile CreateLoRaWANDeviceProfile()
    {
        var loRaWANDeviceProfileResult = new Humidifier.IoTWireless.DeviceProfileTypes.LoRaWANDeviceProfile();

        return loRaWANDeviceProfileResult;
    }

} // End Of Class

public static class InnerDeviceProfileLoRaWANDeviceProfileFactoryExtensions
{
}
