// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerAppAuthorizationApiKeyCredentialFactory(Action<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential>
{

    protected override Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential Create()
    {
        var apiKeyCredentialResult = CreateApiKeyCredential();
        factoryAction?.Invoke(apiKeyCredentialResult);

        return apiKeyCredentialResult;
    }

    private Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential CreateApiKeyCredential()
    {
        var apiKeyCredentialResult = new Humidifier.AppFabric.AppAuthorizationTypes.ApiKeyCredential();

        return apiKeyCredentialResult;
    }

} // End Of Class

public static class InnerAppAuthorizationApiKeyCredentialFactoryExtensions
{
}
