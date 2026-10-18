// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetApiKeyCredentialProviderFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider Create()
    {
        var apiKeyCredentialProviderResult = CreateApiKeyCredentialProvider();
        factoryAction?.Invoke(apiKeyCredentialProviderResult);

        return apiKeyCredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider CreateApiKeyCredentialProvider()
    {
        var apiKeyCredentialProviderResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider();

        return apiKeyCredentialProviderResult;
    }

} // End Of Class

public static class InnerGatewayTargetApiKeyCredentialProviderFactoryExtensions
{
}
