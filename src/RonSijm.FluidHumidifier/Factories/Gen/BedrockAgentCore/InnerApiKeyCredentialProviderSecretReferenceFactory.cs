// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerApiKeyCredentialProviderSecretReferenceFactory(Action<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference>
{

    protected override Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference Create()
    {
        var secretReferenceResult = CreateSecretReference();
        factoryAction?.Invoke(secretReferenceResult);

        return secretReferenceResult;
    }

    private Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference CreateSecretReference()
    {
        var secretReferenceResult = new Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference();

        return secretReferenceResult;
    }

} // End Of Class

public static class InnerApiKeyCredentialProviderSecretReferenceFactoryExtensions
{
}
