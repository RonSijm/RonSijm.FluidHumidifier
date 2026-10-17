// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessOAuthCredentialProviderFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider Create()
    {
        var oAuthCredentialProviderResult = CreateOAuthCredentialProvider();
        factoryAction?.Invoke(oAuthCredentialProviderResult);

        return oAuthCredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider CreateOAuthCredentialProvider()
    {
        var oAuthCredentialProviderResult = new Humidifier.BedrockAgentCore.HarnessTypes.OAuthCredentialProvider();

        return oAuthCredentialProviderResult;
    }

} // End Of Class

public static class InnerHarnessOAuthCredentialProviderFactoryExtensions
{
}
