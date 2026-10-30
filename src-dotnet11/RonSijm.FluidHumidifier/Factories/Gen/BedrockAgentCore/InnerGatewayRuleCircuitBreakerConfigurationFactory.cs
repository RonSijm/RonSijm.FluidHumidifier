// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleCircuitBreakerConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration Create()
    {
        var circuitBreakerConfigurationResult = CreateCircuitBreakerConfiguration();
        factoryAction?.Invoke(circuitBreakerConfigurationResult);

        return circuitBreakerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration CreateCircuitBreakerConfiguration()
    {
        var circuitBreakerConfigurationResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration();

        return circuitBreakerConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayRuleCircuitBreakerConfigurationFactoryExtensions
{
}
