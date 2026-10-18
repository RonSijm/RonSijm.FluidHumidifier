// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleRouteToTargetActionFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction>
{

    internal InnerGatewayRuleStaticRouteFactory StaticRouteFactory { get; set; }

    internal InnerGatewayRuleWeightedRouteFactory WeightedRouteFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction Create()
    {
        var routeToTargetActionResult = CreateRouteToTargetAction();
        factoryAction?.Invoke(routeToTargetActionResult);

        return routeToTargetActionResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction CreateRouteToTargetAction()
    {
        var routeToTargetActionResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction();

        return routeToTargetActionResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction result)
    {
        base.CreateChildren(result);

        result.StaticRoute ??= StaticRouteFactory?.Build();
        result.WeightedRoute ??= WeightedRouteFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRuleRouteToTargetActionFactoryExtensions
{
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleStaticRouteFactory> WithStaticRoute(this InnerGatewayRuleRouteToTargetActionFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null)
    {
        parentFactory.StaticRouteFactory = new InnerGatewayRuleStaticRouteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StaticRouteFactory);
    }

    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute(this InnerGatewayRuleRouteToTargetActionFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null)
    {
        parentFactory.WeightedRouteFactory = new InnerGatewayRuleWeightedRouteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WeightedRouteFactory);
    }

    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, WithStaticRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, WithStaticRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3, T4, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3, T4, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3, T4, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory, T4, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleStaticRouteFactory> WithStaticRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStaticRoute(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, WithWeightedRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, WithWeightedRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3, T4, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleRouteToTargetActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3, T4, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleRouteToTargetActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3, T4, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleRouteToTargetActionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory, T4, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleRouteToTargetActionFactory, InnerGatewayRuleWeightedRouteFactory> WithWeightedRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleRouteToTargetActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWeightedRoute(combinedResult.T5, subFactoryAction).T2);
}
