// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceSessionKeysAbpV11Factory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11>
{

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11 Create()
    {
        var sessionKeysAbpV11Result = CreateSessionKeysAbpV11();
        factoryAction?.Invoke(sessionKeysAbpV11Result);

        return sessionKeysAbpV11Result;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11 CreateSessionKeysAbpV11()
    {
        var sessionKeysAbpV11Result = new Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11();

        return sessionKeysAbpV11Result;
    }

} // End Of Class

public static class InnerWirelessDeviceSessionKeysAbpV11FactoryExtensions
{
}
