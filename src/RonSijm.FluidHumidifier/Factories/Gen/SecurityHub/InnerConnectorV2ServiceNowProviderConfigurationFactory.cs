// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorV2ServiceNowProviderConfigurationFactory(Action<Humidifier.SecurityHub.ConnectorV2Types.ServiceNowProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorV2Types.ServiceNowProviderConfiguration>
{

    protected override Humidifier.SecurityHub.ConnectorV2Types.ServiceNowProviderConfiguration Create()
    {
        var serviceNowProviderConfigurationResult = CreateServiceNowProviderConfiguration();
        factoryAction?.Invoke(serviceNowProviderConfigurationResult);

        return serviceNowProviderConfigurationResult;
    }

    private Humidifier.SecurityHub.ConnectorV2Types.ServiceNowProviderConfiguration CreateServiceNowProviderConfiguration()
    {
        var serviceNowProviderConfigurationResult = new Humidifier.SecurityHub.ConnectorV2Types.ServiceNowProviderConfiguration();

        return serviceNowProviderConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorV2ServiceNowProviderConfigurationFactoryExtensions
{
}
