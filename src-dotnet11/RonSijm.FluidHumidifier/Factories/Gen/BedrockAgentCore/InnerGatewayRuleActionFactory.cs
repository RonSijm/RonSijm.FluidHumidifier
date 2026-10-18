// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleActionFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action>
{

    internal InnerGatewayRuleRouteToTargetActionFactory RouteToTargetFactory { get; set; }

    internal InnerGatewayRuleConfigurationBundleActionFactory ConfigurationBundleFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRuleTypes.Action result)
    {
        base.CreateChildren(result);

        result.RouteToTarget ??= RouteToTargetFactory?.Build();
        result.ConfigurationBundle ??= ConfigurationBundleFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRuleActionFactoryExtensions
{
    public static CombinedResult<InnerGatewayRuleActionFactory, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget(this InnerGatewayRuleActionFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null)
    {
        parentFactory.RouteToTargetFactory = new InnerGatewayRuleRouteToTargetActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RouteToTargetFactory);
    }

    public static CombinedResult<InnerGatewayRuleActionFactory, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle(this InnerGatewayRuleActionFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null)
    {
        parentFactory.ConfigurationBundleFactory = new InnerGatewayRuleConfigurationBundleActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationBundleFactory);
    }

    public static CombinedResult<InnerGatewayRuleActionFactory, T1, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1>(this CombinedResult<InnerGatewayRuleActionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithRouteToTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1>(this CombinedResult<T1, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithRouteToTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, T2, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2>(this CombinedResult<InnerGatewayRuleActionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, T2, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2>(this CombinedResult<T1, InnerGatewayRuleActionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleActionFactory, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3>(this CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3, T4, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3, T4, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3, T4, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory, T4, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleActionFactory, InnerGatewayRuleRouteToTargetActionFactory> WithRouteToTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.RouteToTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRouteToTarget(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1>(this CombinedResult<InnerGatewayRuleActionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1>(this CombinedResult<T1, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, T2, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2>(this CombinedResult<InnerGatewayRuleActionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, T2, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2>(this CombinedResult<T1, InnerGatewayRuleActionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleActionFactory, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3>(this CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3, T4, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3, T4, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3, T4, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleActionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory, T4, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleActionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleActionFactory, InnerGatewayRuleConfigurationBundleActionFactory> WithConfigurationBundle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleActionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.ConfigurationBundleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationBundle(combinedResult.T5, subFactoryAction).T2);
}
