// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata>
{

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata Create()
    {
        var oauth2AuthorizationServerMetadataResult = CreateOauth2AuthorizationServerMetadata();
        factoryAction?.Invoke(oauth2AuthorizationServerMetadataResult);

        return oauth2AuthorizationServerMetadataResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata CreateOauth2AuthorizationServerMetadata()
    {
        var oauth2AuthorizationServerMetadataResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata();

        return oauth2AuthorizationServerMetadataResult;
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderOauth2AuthorizationServerMetadataFactoryExtensions
{
}
