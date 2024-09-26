// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerFuotaTaskLoRaWANFactory(Action<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN>
{

    protected override Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN Create()
    {
        var loRaWANResult = CreateLoRaWAN();
        factoryAction?.Invoke(loRaWANResult);

        return loRaWANResult;
    }

    private Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN CreateLoRaWAN()
    {
        var loRaWANResult = new Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN();

        return loRaWANResult;
    }

} // End Of Class

public static class InnerFuotaTaskLoRaWANFactoryExtensions
{
}
