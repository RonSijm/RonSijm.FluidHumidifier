// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceSessionKeysAbpV10xFactory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x>
{

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x Create()
    {
        var sessionKeysAbpV10xResult = CreateSessionKeysAbpV10x();
        factoryAction?.Invoke(sessionKeysAbpV10xResult);

        return sessionKeysAbpV10xResult;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x CreateSessionKeysAbpV10x()
    {
        var sessionKeysAbpV10xResult = new Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x();

        return sessionKeysAbpV10xResult;
    }

} // End Of Class

public static class InnerWirelessDeviceSessionKeysAbpV10xFactoryExtensions
{
}
