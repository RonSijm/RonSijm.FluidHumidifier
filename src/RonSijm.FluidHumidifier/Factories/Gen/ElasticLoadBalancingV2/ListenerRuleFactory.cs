// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class ListenerRuleFactory(string resourceName = null, Action<Humidifier.ElasticLoadBalancingV2.ListenerRule> factoryAction = null) : ResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRule>(resourceName)
{

    internal List<InnerListenerRuleActionFactory> ActionsFactories { get; set; } = [];

    internal List<InnerListenerRuleRuleConditionFactory> ConditionsFactories { get; set; } = [];

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRule Create()
    {
        var listenerRuleResult = CreateListenerRule();
        factoryAction?.Invoke(listenerRuleResult);

        return listenerRuleResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRule CreateListenerRule()
    {
        var listenerRuleResult = new Humidifier.ElasticLoadBalancingV2.ListenerRule
        {
            GivenName = InputResourceName,
        };

        return listenerRuleResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.ListenerRule result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.Conditions = ConditionsFactories.Any() ? ConditionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ListenerRuleFactoryExtensions
{
    public static CombinedResult<ListenerRuleFactory, InnerListenerRuleActionFactory> WithActions(this ListenerRuleFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null)
    {
        var factory = new InnerListenerRuleActionFactory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ListenerRuleFactory, InnerListenerRuleRuleConditionFactory> WithConditions(this ListenerRuleFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null)
    {
        var factory = new InnerListenerRuleRuleConditionFactory(subFactoryAction);
        parentFactory.ConditionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ListenerRuleFactory, T1, InnerListenerRuleActionFactory> WithActions<T1>(this CombinedResult<ListenerRuleFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, InnerListenerRuleActionFactory> WithActions<T1>(this CombinedResult<T1, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, T2, InnerListenerRuleActionFactory> WithActions<T1, T2>(this CombinedResult<ListenerRuleFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, T2, InnerListenerRuleActionFactory> WithActions<T1, T2>(this CombinedResult<T1, ListenerRuleFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerRuleFactory, InnerListenerRuleActionFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, T2, T3, InnerListenerRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<ListenerRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, T2, T3, InnerListenerRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, ListenerRuleFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerRuleFactory, T3, InnerListenerRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, ListenerRuleFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerRuleFactory, InnerListenerRuleActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, T2, T3, T4, InnerListenerRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<ListenerRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, T2, T3, T4, InnerListenerRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, ListenerRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerRuleFactory, T3, T4, InnerListenerRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ListenerRuleFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerRuleFactory, T4, InnerListenerRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ListenerRuleFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ListenerRuleFactory, InnerListenerRuleActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, InnerListenerRuleRuleConditionFactory> WithConditions<T1>(this CombinedResult<ListenerRuleFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, InnerListenerRuleRuleConditionFactory> WithConditions<T1>(this CombinedResult<T1, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, T2, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<ListenerRuleFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, T2, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, ListenerRuleFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerRuleFactory, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2>(this CombinedResult<T1, T2, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, T2, T3, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<ListenerRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, T2, T3, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, ListenerRuleFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerRuleFactory, T3, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, ListenerRuleFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerRuleFactory, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ListenerRuleFactory, T1, T2, T3, T4, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<ListenerRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ListenerRuleFactory, T2, T3, T4, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, ListenerRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ListenerRuleFactory, T3, T4, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ListenerRuleFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ListenerRuleFactory, T4, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ListenerRuleFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ListenerRuleFactory, InnerListenerRuleRuleConditionFactory> WithConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ListenerRuleFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConditions(combinedResult.T5, subFactoryAction));
}
