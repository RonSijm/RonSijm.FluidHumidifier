// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleFallbackTriggersFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers Create()
    {
        var fallbackTriggersResult = CreateFallbackTriggers();
        factoryAction?.Invoke(fallbackTriggersResult);

        return fallbackTriggersResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers CreateFallbackTriggers()
    {
        var fallbackTriggersResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers();

        return fallbackTriggersResult;
    }

} // End Of Class

public static class InnerGatewayRuleFallbackTriggersFactoryExtensions
{
}
