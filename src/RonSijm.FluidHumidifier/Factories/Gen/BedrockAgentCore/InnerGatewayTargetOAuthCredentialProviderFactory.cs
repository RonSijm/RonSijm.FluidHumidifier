// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetOAuthCredentialProviderFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider Create()
    {
        var oAuthCredentialProviderResult = CreateOAuthCredentialProvider();
        factoryAction?.Invoke(oAuthCredentialProviderResult);

        return oAuthCredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider CreateOAuthCredentialProvider()
    {
        var oAuthCredentialProviderResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider();

        return oAuthCredentialProviderResult;
    }

} // End Of Class

public static class InnerGatewayTargetOAuthCredentialProviderFactoryExtensions
{
}
