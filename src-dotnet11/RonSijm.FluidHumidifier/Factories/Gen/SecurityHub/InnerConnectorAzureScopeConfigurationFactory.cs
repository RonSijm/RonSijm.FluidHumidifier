// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorAzureScopeConfigurationFactory(Action<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration>
{

    protected override Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration Create()
    {
        var azureScopeConfigurationResult = CreateAzureScopeConfiguration();
        factoryAction?.Invoke(azureScopeConfigurationResult);

        return azureScopeConfigurationResult;
    }

    private Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration CreateAzureScopeConfiguration()
    {
        var azureScopeConfigurationResult = new Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration();

        return azureScopeConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorAzureScopeConfigurationFactoryExtensions
{
}
