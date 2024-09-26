// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class RuleFactory(string resourceName = null, Action<Humidifier.Events.Rule> factoryAction = null) : ResourceFactory<Humidifier.Events.Rule>(resourceName)
{

    internal List<InnerRuleTargetFactory> TargetsFactories { get; set; } = [];

    protected override Humidifier.Events.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.Events.Rule CreateRule()
    {
        var ruleResult = new Humidifier.Events.Rule
        {
            GivenName = InputResourceName,
        };

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.Events.Rule result)
    {
        base.CreateChildren(result);

        result.Targets = TargetsFactories.Any() ? TargetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RuleFactoryExtensions
{
    public static CombinedResult<RuleFactory, InnerRuleTargetFactory> WithTargets(this RuleFactory parentFactory, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null)
    {
        var factory = new InnerRuleTargetFactory(subFactoryAction);
        parentFactory.TargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleFactory, T1, InnerRuleTargetFactory> WithTargets<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleTargetFactory> WithTargets<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleTargetFactory> WithTargets<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleTargetFactory> WithTargets<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleTargetFactory> WithTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleTargetFactory> WithTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Events.RuleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargets(combinedResult.T5, subFactoryAction));
}
