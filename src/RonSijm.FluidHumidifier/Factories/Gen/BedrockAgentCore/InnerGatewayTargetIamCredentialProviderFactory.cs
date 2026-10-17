// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetIamCredentialProviderFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider Create()
    {
        var iamCredentialProviderResult = CreateIamCredentialProvider();
        factoryAction?.Invoke(iamCredentialProviderResult);

        return iamCredentialProviderResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider CreateIamCredentialProvider()
    {
        var iamCredentialProviderResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider();

        return iamCredentialProviderResult;
    }

} // End Of Class

public static class InnerGatewayTargetIamCredentialProviderFactoryExtensions
{
}
