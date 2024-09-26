// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class RuleFactory(string resourceName = null, Action<Humidifier.Connect.Rule> factoryAction = null) : ResourceFactory<Humidifier.Connect.Rule>(resourceName)
{

    internal InnerRuleRuleTriggerEventSourceFactory TriggerEventSourceFactory { get; set; }

    internal InnerRuleActionsFactory ActionsFactory { get; set; }

    protected override Humidifier.Connect.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.Connect.Rule CreateRule()
    {
        var ruleResult = new Humidifier.Connect.Rule
        {
            GivenName = InputResourceName,
        };

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.Connect.Rule result)
    {
        base.CreateChildren(result);

        result.TriggerEventSource ??= TriggerEventSourceFactory?.Build();
        result.Actions ??= ActionsFactory?.Build();
    }

} // End Of Class

public static class RuleFactoryExtensions
{
    public static CombinedResult<RuleFactory, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource(this RuleFactory parentFactory, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null)
    {
        parentFactory.TriggerEventSourceFactory = new InnerRuleRuleTriggerEventSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TriggerEventSourceFactory);
    }

    public static CombinedResult<RuleFactory, InnerRuleActionsFactory> WithActions(this RuleFactory parentFactory, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null)
    {
        parentFactory.ActionsFactory = new InnerRuleActionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionsFactory);
    }

    public static CombinedResult<RuleFactory, T1, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleRuleTriggerEventSourceFactory> WithTriggerEventSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggerEventSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, InnerRuleActionsFactory> WithActions<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleActionsFactory> WithActions<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleActionsFactory> WithActions<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleActionsFactory> WithActions<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleActionsFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleActionsFactory> WithActions<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleActionsFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleActionsFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleActionsFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleActionsFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleActionsFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleActionsFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleActionsFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleActionsFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Connect.RuleTypes.Actions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction));
}
