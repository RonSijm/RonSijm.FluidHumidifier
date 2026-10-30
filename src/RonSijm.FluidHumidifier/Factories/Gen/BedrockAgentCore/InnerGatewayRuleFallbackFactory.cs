// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleFallbackFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback>
{

    internal InnerGatewayRuleFallbackTriggersFactory TriggerOnFactory { get; set; }

    internal InnerGatewayRuleCircuitBreakerConfigurationFactory CircuitBreakerFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback Create()
    {
        var fallbackResult = CreateFallback();
        factoryAction?.Invoke(fallbackResult);

        return fallbackResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback CreateFallback()
    {
        var fallbackResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback();

        return fallbackResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback result)
    {
        base.CreateChildren(result);

        result.TriggerOn ??= TriggerOnFactory?.Build();
        result.CircuitBreaker ??= CircuitBreakerFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRuleFallbackFactoryExtensions
{
    public static CombinedResult<InnerGatewayRuleFallbackFactory, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn(this InnerGatewayRuleFallbackFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null)
    {
        parentFactory.TriggerOnFactory = new InnerGatewayRuleFallbackTriggersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TriggerOnFactory);
    }

    public static CombinedResult<InnerGatewayRuleFallbackFactory, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker(this InnerGatewayRuleFallbackFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null)
    {
        parentFactory.CircuitBreakerFactory = new InnerGatewayRuleCircuitBreakerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CircuitBreakerFactory);
    }

    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerOn(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerOn(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3, T4, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3, T4, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3, T4, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory, T4, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleFallbackFactory, InnerGatewayRuleFallbackTriggersFactory> WithTriggerOn<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.FallbackTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerOn(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3, T4, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleFallbackFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3, T4, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleFallbackFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3, T4, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleFallbackFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory, T4, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleFallbackFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleFallbackFactory, InnerGatewayRuleCircuitBreakerConfigurationFactory> WithCircuitBreaker<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleFallbackFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.CircuitBreakerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCircuitBreaker(combinedResult.T5, subFactoryAction).T2);
}
