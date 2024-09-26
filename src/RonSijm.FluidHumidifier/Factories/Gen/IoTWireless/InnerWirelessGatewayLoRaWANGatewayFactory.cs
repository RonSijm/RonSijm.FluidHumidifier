// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerWirelessGatewayLoRaWANGatewayFactory(Action<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway>
{

    protected override Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway Create()
    {
        var loRaWANGatewayResult = CreateLoRaWANGateway();
        factoryAction?.Invoke(loRaWANGatewayResult);

        return loRaWANGatewayResult;
    }

    private Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway CreateLoRaWANGateway()
    {
        var loRaWANGatewayResult = new Humidifier.IoTWireless.WirelessGatewayTypes.LoRaWANGateway();

        return loRaWANGatewayResult;
    }

} // End Of Class

public static class InnerWirelessGatewayLoRaWANGatewayFactoryExtensions
{
}
