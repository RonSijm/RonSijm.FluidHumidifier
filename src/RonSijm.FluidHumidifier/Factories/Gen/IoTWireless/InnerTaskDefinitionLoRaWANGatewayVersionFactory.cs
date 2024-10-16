// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerTaskDefinitionLoRaWANGatewayVersionFactory(Action<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion>
{

    protected override Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion Create()
    {
        var loRaWANGatewayVersionResult = CreateLoRaWANGatewayVersion();
        factoryAction?.Invoke(loRaWANGatewayVersionResult);

        return loRaWANGatewayVersionResult;
    }

    private Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion CreateLoRaWANGatewayVersion()
    {
        var loRaWANGatewayVersionResult = new Humidifier.IoTWireless.TaskDefinitionTypes.LoRaWANGatewayVersion();

        return loRaWANGatewayVersionResult;
    }

} // End Of Class

public static class InnerTaskDefinitionLoRaWANGatewayVersionFactoryExtensions
{
}
