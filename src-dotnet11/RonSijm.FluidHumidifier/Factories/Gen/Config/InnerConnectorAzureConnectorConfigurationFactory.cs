// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConnectorAzureConnectorConfigurationFactory(Action<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration>
{

    protected override Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration Create()
    {
        var azureConnectorConfigurationResult = CreateAzureConnectorConfiguration();
        factoryAction?.Invoke(azureConnectorConfigurationResult);

        return azureConnectorConfigurationResult;
    }

    private Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration CreateAzureConnectorConfiguration()
    {
        var azureConnectorConfigurationResult = new Humidifier.Config.ConnectorTypes.AzureConnectorConfiguration();

        return azureConnectorConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorAzureConnectorConfigurationFactoryExtensions
{
}
