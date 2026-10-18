// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConnectorV2JiraCloudProviderConfigurationFactory(Action<Humidifier.SecurityHub.ConnectorV2Types.JiraCloudProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConnectorV2Types.JiraCloudProviderConfiguration>
{

    protected override Humidifier.SecurityHub.ConnectorV2Types.JiraCloudProviderConfiguration Create()
    {
        var jiraCloudProviderConfigurationResult = CreateJiraCloudProviderConfiguration();
        factoryAction?.Invoke(jiraCloudProviderConfigurationResult);

        return jiraCloudProviderConfigurationResult;
    }

    private Humidifier.SecurityHub.ConnectorV2Types.JiraCloudProviderConfiguration CreateJiraCloudProviderConfiguration()
    {
        var jiraCloudProviderConfigurationResult = new Humidifier.SecurityHub.ConnectorV2Types.JiraCloudProviderConfiguration();

        return jiraCloudProviderConfigurationResult;
    }

} // End Of Class

public static class InnerConnectorV2JiraCloudProviderConfigurationFactoryExtensions
{
}
