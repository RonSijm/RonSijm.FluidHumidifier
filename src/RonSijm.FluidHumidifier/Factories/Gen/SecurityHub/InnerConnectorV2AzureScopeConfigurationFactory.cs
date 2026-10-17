// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorV2AzureScopeConfigurationFactory(Action<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration>
{

    protected override Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration Create()
    {
        var azureScopeConfigurationResult = CreateAzureScopeConfiguration();
        factoryAction?.Invoke(azureScopeConfigurationResult);

        return azureScopeConfigurationResult;
    }

    private Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration CreateAzureScopeConfiguration()
    {
        var azureScopeConfigurationResult = new Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration();

        return azureScopeConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorV2AzureScopeConfigurationFactoryExtensions
{
}
