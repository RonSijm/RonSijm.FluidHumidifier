// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class RateBasedRuleFactory(string resourceName = null, Action<Humidifier.WAFRegional.RateBasedRule> factoryAction = null) : ResourceFactory<Humidifier.WAFRegional.RateBasedRule>(resourceName)
{

    internal List<InnerRateBasedRulePredicateFactory> MatchPredicatesFactories { get; set; } = [];

    protected override Humidifier.WAFRegional.RateBasedRule Create()
    {
        var rateBasedRuleResult = CreateRateBasedRule();
        factoryAction?.Invoke(rateBasedRuleResult);

        return rateBasedRuleResult;
    }

    private Humidifier.WAFRegional.RateBasedRule CreateRateBasedRule()
    {
        var rateBasedRuleResult = new Humidifier.WAFRegional.RateBasedRule
        {
            GivenName = InputResourceName,
        };

        return rateBasedRuleResult;
    }
    public override void CreateChildren(Humidifier.WAFRegional.RateBasedRule result)
    {
        base.CreateChildren(result);

        result.MatchPredicates = MatchPredicatesFactories.Any() ? MatchPredicatesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RateBasedRuleFactoryExtensions
{
    public static CombinedResult<RateBasedRuleFactory, InnerRateBasedRulePredicateFactory> WithMatchPredicates(this RateBasedRuleFactory parentFactory, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null)
    {
        var factory = new InnerRateBasedRulePredicateFactory(subFactoryAction);
        parentFactory.MatchPredicatesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RateBasedRuleFactory, T1, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1>(this CombinedResult<RateBasedRuleFactory, T1> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RateBasedRuleFactory, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1>(this CombinedResult<T1, RateBasedRuleFactory> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RateBasedRuleFactory, T1, T2, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2>(this CombinedResult<RateBasedRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RateBasedRuleFactory, T2, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2>(this CombinedResult<T1, RateBasedRuleFactory, T2> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RateBasedRuleFactory, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2>(this CombinedResult<T1, T2, RateBasedRuleFactory> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RateBasedRuleFactory, T1, T2, T3, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3>(this CombinedResult<RateBasedRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RateBasedRuleFactory, T2, T3, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3>(this CombinedResult<T1, RateBasedRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RateBasedRuleFactory, T3, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3>(this CombinedResult<T1, T2, RateBasedRuleFactory, T3> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RateBasedRuleFactory, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3>(this CombinedResult<T1, T2, T3, RateBasedRuleFactory> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RateBasedRuleFactory, T1, T2, T3, T4, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3, T4>(this CombinedResult<RateBasedRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RateBasedRuleFactory, T2, T3, T4, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3, T4>(this CombinedResult<T1, RateBasedRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RateBasedRuleFactory, T3, T4, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3, T4>(this CombinedResult<T1, T2, RateBasedRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RateBasedRuleFactory, T4, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RateBasedRuleFactory, T4> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RateBasedRuleFactory, InnerRateBasedRulePredicateFactory> WithMatchPredicates<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RateBasedRuleFactory> combinedResult, Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPredicates(combinedResult.T5, subFactoryAction));
}
