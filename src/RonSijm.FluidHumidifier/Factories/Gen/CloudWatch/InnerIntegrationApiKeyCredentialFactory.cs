// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerIntegrationApiKeyCredentialFactory(Action<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential>
{

    protected override Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential Create()
    {
        var apiKeyCredentialResult = CreateApiKeyCredential();
        factoryAction?.Invoke(apiKeyCredentialResult);

        return apiKeyCredentialResult;
    }

    private Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential CreateApiKeyCredential()
    {
        var apiKeyCredentialResult = new Humidifier.CloudWatch.IntegrationTypes.ApiKeyCredential();

        return apiKeyCredentialResult;
    }

} // End Of Class

public static class InnerIntegrationApiKeyCredentialFactoryExtensions
{
}
