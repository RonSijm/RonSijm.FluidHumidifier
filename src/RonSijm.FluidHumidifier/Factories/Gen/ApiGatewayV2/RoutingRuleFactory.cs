// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class RoutingRuleFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.RoutingRule> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.RoutingRule>(resourceName)
{

    internal List<InnerRoutingRuleActionFactory> ActionsFactories { get; set; } = [];

    internal List<InnerRoutingRuleConditionFactory> ConditionsFactories { get; set; } = [];

    protected override Humidifier.ApiGatewayV2.RoutingRule Create()
    {
        var routingRuleResult = CreateRoutingRule();
        factoryAction?.Invoke(routingRuleResult);

        return routingRuleResult;
    }

    private Humidifier.ApiGatewayV2.RoutingRule CreateRoutingRule()
    {
        var routingRuleResult = new Humidifier.ApiGatewayV2.RoutingRule
        {
            GivenName = InputResourceName,
        };

        return routingRuleResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.RoutingRule result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.Conditions = ConditionsFactories.Any() ? ConditionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RoutingRuleFactoryExtensions
{
    public static CombinedResult<RoutingRuleFactory, InnerRoutingRuleActionFactory> WithActions(this RoutingRuleFactory parentFactory, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null)
    {
        var factory = new InnerRoutingRuleActionFactory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RoutingRuleFactory, InnerRoutingRuleConditionFactory> WithConditions(this RoutingRuleFactory parentFactory, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null)
    {
        var factory = new InnerRoutingRuleConditionFactory(subFactoryAction);
        parentFactory.ConditionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RoutingRuleFactory, T1, InnerRoutingRuleActionFactory> WithActions<T1>(this CombinedResult<RoutingRuleFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, InnerRoutingRuleActionFactory> WithActions<T1>(this CombinedResult<T1, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, T2, InnerRoutingRuleActionFactory> WithActions<T1, T2>(this CombinedResult<RoutingRuleFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, T2, InnerRoutingRuleActionFactory> WithActions<T1, T2>(this CombinedResult<T1, RoutingRuleFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RoutingRuleFactory, InnerRoutingRuleActionFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, T2, T3, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<RoutingRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, T2, T3, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, RoutingRuleFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RoutingRuleFactory, T3, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, RoutingRuleFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RoutingRuleFactory, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, T2, T3, T4, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<RoutingRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, T2, T3, T4, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, RoutingRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RoutingRuleFactory, T3, T4, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, RoutingRuleFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RoutingRuleFactory, T4, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RoutingRuleFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RoutingRuleFactory, InnerRoutingRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, InnerRoutingRuleConditionFactory> WithConditions<T1>(this CombinedResult<RoutingRuleFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, InnerRoutingRuleConditionFactory> WithConditions<T1>(this CombinedResult<T1, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, T2, InnerRoutingRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<RoutingRuleFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, T2, InnerRoutingRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, RoutingRuleFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RoutingRuleFactory, InnerRoutingRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, T2, T3, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<RoutingRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, T2, T3, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, RoutingRuleFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RoutingRuleFactory, T3, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, RoutingRuleFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RoutingRuleFactory, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<RoutingRuleFactory, T1, T2, T3, T4, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<RoutingRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, RoutingRuleFactory, T2, T3, T4, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, RoutingRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, RoutingRuleFactory, T3, T4, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, RoutingRuleFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, RoutingRuleFactory, T4, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RoutingRuleFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, RoutingRuleFactory, InnerRoutingRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RoutingRuleFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction).T2);
}
