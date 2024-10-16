// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceOtaaV11Factory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV11> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV11>
{

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV11 Create()
    {
        var otaaV11Result = CreateOtaaV11();
        factoryAction?.Invoke(otaaV11Result);

        return otaaV11Result;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV11 CreateOtaaV11()
    {
        var otaaV11Result = new Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV11();

        return otaaV11Result;
    }

} // End Of Class

public static class InnerWirelessDeviceOtaaV11FactoryExtensions
{
}
