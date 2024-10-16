// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessDeviceOtaaV10xFactory(Action<Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV10x> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV10x>
{

    protected override Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV10x Create()
    {
        var otaaV10xResult = CreateOtaaV10x();
        factoryAction?.Invoke(otaaV10xResult);

        return otaaV10xResult;
    }

    private Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV10x CreateOtaaV10x()
    {
        var otaaV10xResult = new Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV10x();

        return otaaV10xResult;
    }

} // End Of Class

public static class InnerWirelessDeviceOtaaV10xFactoryExtensions
{
}
