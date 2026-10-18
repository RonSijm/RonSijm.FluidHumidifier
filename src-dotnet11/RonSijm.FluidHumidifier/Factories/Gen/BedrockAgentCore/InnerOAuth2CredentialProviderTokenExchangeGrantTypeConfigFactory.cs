// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactory(Action<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig>
{

    protected override Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig Create()
    {
        var tokenExchangeGrantTypeConfigResult = CreateTokenExchangeGrantTypeConfig();
        factoryAction?.Invoke(tokenExchangeGrantTypeConfigResult);

        return tokenExchangeGrantTypeConfigResult;
    }

    private Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig CreateTokenExchangeGrantTypeConfig()
    {
        var tokenExchangeGrantTypeConfigResult = new Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig();

        return tokenExchangeGrantTypeConfigResult;
    }

} // End Of Class

public static class InnerOAuth2CredentialProviderTokenExchangeGrantTypeConfigFactoryExtensions
{
}
