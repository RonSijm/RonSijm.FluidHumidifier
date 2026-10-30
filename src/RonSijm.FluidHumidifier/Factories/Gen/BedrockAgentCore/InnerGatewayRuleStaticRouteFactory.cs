// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleStaticRouteFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute>
{

    internal InnerGatewayRuleFallbackFactory FallbackFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute Create()
    {
        var staticRouteResult = CreateStaticRoute();
        factoryAction?.Invoke(staticRouteResult);

        return staticRouteResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute CreateStaticRoute()
    {
        var staticRouteResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute();

        return staticRouteResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute result)
    {
        base.CreateChildren(result);

        result.Fallback ??= FallbackFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRuleStaticRouteFactoryExtensions
{
    public static CombinedResult<InnerGatewayRuleStaticRouteFactory, InnerGatewayRuleFallbackFactory> WithFallback(this InnerGatewayRuleStaticRouteFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null)
    {
        parentFactory.FallbackFactory = new InnerGatewayRuleFallbackFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FallbackFactory);
    }

    public static CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, InnerGatewayRuleFallbackFactory> WithFallback<T1>(this CombinedResult<InnerGatewayRuleStaticRouteFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, WithFallback(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, InnerGatewayRuleFallbackFactory> WithFallback<T1>(this CombinedResult<T1, InnerGatewayRuleStaticRouteFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, WithFallback(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, T2, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2>(this CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, T2, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2>(this CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleStaticRouteFactory, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleStaticRouteFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, T2, T3, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3>(this CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, T2, T3, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleStaticRouteFactory, T3, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleStaticRouteFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleStaticRouteFactory, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleStaticRouteFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, T2, T3, T4, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleStaticRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, T2, T3, T4, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleStaticRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleStaticRouteFactory, T3, T4, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleStaticRouteFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleStaticRouteFactory, T4, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleStaticRouteFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleStaticRouteFactory, InnerGatewayRuleFallbackFactory> WithFallback<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleStaticRouteFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Fallback> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFallback(combinedResult.T5, subFactoryAction).T2);
}
