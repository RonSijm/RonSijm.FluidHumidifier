// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerConnectorProfileApiKeyCredentialsFactory(Action<Humidifier.AppFlow.ConnectorProfileTypes.ApiKeyCredentials> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.ConnectorProfileTypes.ApiKeyCredentials>
{

    protected override Humidifier.AppFlow.ConnectorProfileTypes.ApiKeyCredentials Create()
    {
        var apiKeyCredentialsResult = CreateApiKeyCredentials();
        factoryAction?.Invoke(apiKeyCredentialsResult);

        return apiKeyCredentialsResult;
    }

    private Humidifier.AppFlow.ConnectorProfileTypes.ApiKeyCredentials CreateApiKeyCredentials()
    {
        var apiKeyCredentialsResult = new Humidifier.AppFlow.ConnectorProfileTypes.ApiKeyCredentials();

        return apiKeyCredentialsResult;
    }

} // End Of Class

public static class InnerConnectorProfileApiKeyCredentialsFactoryExtensions
{
}
