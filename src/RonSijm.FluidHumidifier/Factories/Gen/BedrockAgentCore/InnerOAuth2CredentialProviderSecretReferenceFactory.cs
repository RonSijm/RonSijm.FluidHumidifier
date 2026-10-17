// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderSecretReferenceFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference>
{

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference Create()
    {
        var secretReferenceResult = CreateSecretReference();
        factoryAction?.Invoke(secretReferenceResult);

        return secretReferenceResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference CreateSecretReference()
    {
        var secretReferenceResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference();

        return secretReferenceResult;
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderSecretReferenceFactoryExtensions
{
}
