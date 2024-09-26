// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceFPortsFactory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.FPorts> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.FPorts>
{

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.FPorts Create()
    {
        var fPortsResult = CreateFPorts();
        factoryAction?.Invoke(fPortsResult);

        return fPortsResult;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.FPorts CreateFPorts()
    {
        var fPortsResult = new Humidifier.IoTWireless.WirelessDeviceTypes.FPorts();

        return fPortsResult;
    }

} // End Of Class

public static class InnerWirelessDeviceFPortsFactoryExtensions
{
}
