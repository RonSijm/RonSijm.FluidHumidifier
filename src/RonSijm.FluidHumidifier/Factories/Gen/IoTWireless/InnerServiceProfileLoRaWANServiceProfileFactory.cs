// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerServiceProfileLoRaWANServiceProfileFactory(Action<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile>
{

    protected override Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile Create()
    {
        var loRaWANServiceProfileResult = CreateLoRaWANServiceProfile();
        factoryAction?.Invoke(loRaWANServiceProfileResult);

        return loRaWANServiceProfileResult;
    }

    private Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile CreateLoRaWANServiceProfile()
    {
        var loRaWANServiceProfileResult = new Humidifier.IoTWireless.ServiceProfileTypes.LoRaWANServiceProfile();

        return loRaWANServiceProfileResult;
    }

} // End Of Class

public static class InnerServiceProfileLoRaWANServiceProfileFactoryExtensions
{
}
