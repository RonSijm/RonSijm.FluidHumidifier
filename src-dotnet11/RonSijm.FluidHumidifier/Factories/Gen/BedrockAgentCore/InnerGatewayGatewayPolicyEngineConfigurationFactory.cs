// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayGatewayPolicyEngineConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.GatewayPolicyEngineConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.GatewayPolicyEngineConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.GatewayPolicyEngineConfiguration Create()
    {
        var gatewayPolicyEngineConfigurationResult = CreateGatewayPolicyEngineConfiguration();
        factoryAction?.Invoke(gatewayPolicyEngineConfigurationResult);

        return gatewayPolicyEngineConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.GatewayPolicyEngineConfiguration CreateGatewayPolicyEngineConfiguration()
    {
        var gatewayPolicyEngineConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.GatewayPolicyEngineConfiguration();

        return gatewayPolicyEngineConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayGatewayPolicyEngineConfigurationFactoryExtensions
{
}
