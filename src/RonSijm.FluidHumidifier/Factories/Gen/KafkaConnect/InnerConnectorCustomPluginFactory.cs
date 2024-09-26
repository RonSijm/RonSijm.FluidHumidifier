// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorCustomPluginFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin Create()
    {
        var customPluginResult = CreateCustomPlugin();
        factoryAction?.Invoke(customPluginResult);

        return customPluginResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin CreateCustomPlugin()
    {
        var customPluginResult = new Humidifier.KafkaConnect.ConnectorTypes.CustomPlugin();

        return customPluginResult;
    }

} // End Of Class

public static class InnerConnectorCustomPluginFactoryExtensions
{
}
