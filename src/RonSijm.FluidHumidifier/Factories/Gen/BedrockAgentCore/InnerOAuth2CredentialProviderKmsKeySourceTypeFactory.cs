// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderKmsKeySourceTypeFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType>
{

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType Create()
    {
        var kmsKeySourceTypeResult = CreateKmsKeySourceType();
        factoryAction?.Invoke(kmsKeySourceTypeResult);

        return kmsKeySourceTypeResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType CreateKmsKeySourceType()
    {
        var kmsKeySourceTypeResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType();

        return kmsKeySourceTypeResult;
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderKmsKeySourceTypeFactoryExtensions
{
}
