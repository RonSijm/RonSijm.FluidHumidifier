// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class RuleFactory(string resourceName = null, Action<Humidifier.WAFRegional.Rule> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.Rule>(resourceName)
{

    internal List<InnerRulePredicateFactory> PredicatesFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.WAFRegional.Rule CreateRule()
    {
        var ruleResult = new Humidifier.WAFRegional.Rule
        {
            GivenName = InputResourceName,
        };

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.Rule result)
    {
        base.CreateChildren(result);

        result.Predicates = PredicatesFactories.Any() ? PredicatesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RuleFactoryExtensions
{
    public static CombinedResult<RuleFactory, InnerRulePredicateFactory> WithPredicates(this RuleFactory parentFactory, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null)
    {
        var factory = new InnerRulePredicateFactory(subFactoryAction);
        parentFactory.PredicatesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleFactory, T1, InnerRulePredicateFactory> WithPredicates<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRulePredicateFactory> WithPredicates<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRulePredicateFactory> WithPredicates<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRulePredicateFactory> WithPredicates<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRulePredicateFactory> WithPredicates<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRulePredicateFactory> WithPredicates<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRulePredicateFactory> WithPredicates<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRulePredicateFactory> WithPredicates<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRulePredicateFactory> WithPredicates<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRulePredicateFactory> WithPredicates<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRulePredicateFactory> WithPredicates<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRulePredicateFactory> WithPredicates<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRulePredicateFactory> WithPredicates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRulePredicateFactory> WithPredicates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.WAFRegional.RuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicates(combinedResult.T5, subFactoryAction));
}
