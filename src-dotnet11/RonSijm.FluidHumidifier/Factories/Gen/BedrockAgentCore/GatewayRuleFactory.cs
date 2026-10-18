// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class GatewayRuleFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.GatewayRule> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.GatewayRule>(resourceName)
{

    internal List<InnerGatewayRuleActionFactory> ActionsFactories { get; set; } = [];

    internal List<InnerGatewayRuleConditionFactory> ConditionsFactories { get; set; } = [];

    protected override Humidifier.BedrockAgentCore.GatewayRule Create()
    {
        var gatewayRuleResult = CreateGatewayRule();
        factoryAction?.Invoke(gatewayRuleResult);

        return gatewayRuleResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRule CreateGatewayRule()
    {
        var gatewayRuleResult = new Humidifier.BedrockAgentCore.GatewayRule
        {
            GivenName = InputResourceName,
        };

        return gatewayRuleResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRule result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.Conditions = ConditionsFactories.Any() ? ConditionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class GatewayRuleFactoryExtensions
{
    public static CombinedResult<GatewayRuleFactory, InnerGatewayRuleActionFactory> WithActions(this GatewayRuleFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null)
    {
        var factory = new InnerGatewayRuleActionFactory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GatewayRuleFactory, InnerGatewayRuleConditionFactory> WithConditions(this GatewayRuleFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null)
    {
        var factory = new InnerGatewayRuleConditionFactory(subFactoryAction);
        parentFactory.ConditionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<GatewayRuleFactory, T1, InnerGatewayRuleActionFactory> WithActions<T1>(this CombinedResult<GatewayRuleFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, InnerGatewayRuleActionFactory> WithActions<T1>(this CombinedResult<T1, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, T2, InnerGatewayRuleActionFactory> WithActions<T1, T2>(this CombinedResult<GatewayRuleFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, T2, InnerGatewayRuleActionFactory> WithActions<T1, T2>(this CombinedResult<T1, GatewayRuleFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRuleFactory, InnerGatewayRuleActionFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, T2, T3, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<GatewayRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, T2, T3, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, GatewayRuleFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRuleFactory, T3, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, GatewayRuleFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayRuleFactory, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, T2, T3, T4, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<GatewayRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, T2, T3, T4, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, GatewayRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRuleFactory, T3, T4, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayRuleFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayRuleFactory, T4, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayRuleFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GatewayRuleFactory, InnerGatewayRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, InnerGatewayRuleConditionFactory> WithConditions<T1>(this CombinedResult<GatewayRuleFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, InnerGatewayRuleConditionFactory> WithConditions<T1>(this CombinedResult<T1, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, T2, InnerGatewayRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<GatewayRuleFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, T2, InnerGatewayRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, GatewayRuleFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRuleFactory, InnerGatewayRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, T2, T3, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<GatewayRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, T2, T3, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, GatewayRuleFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRuleFactory, T3, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, GatewayRuleFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayRuleFactory, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<GatewayRuleFactory, T1, T2, T3, T4, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<GatewayRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, GatewayRuleFactory, T2, T3, T4, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, GatewayRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, GatewayRuleFactory, T3, T4, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, GatewayRuleFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, GatewayRuleFactory, T4, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GatewayRuleFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, GatewayRuleFactory, InnerGatewayRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GatewayRuleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction).T2);
}
