// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerMulticastGroupLoRaWANFactory(Action<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN>
{

    protected override Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN Create()
    {
        var loRaWANResult = CreateLoRaWAN();
        factoryAction?.Invoke(loRaWANResult);

        return loRaWANResult;
    }

    private Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN CreateLoRaWAN()
    {
        var loRaWANResult = new Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN();

        return loRaWANResult;
    }

} // End Of Class

public static class InnerMulticastGroupLoRaWANFactoryExtensions
{
}
