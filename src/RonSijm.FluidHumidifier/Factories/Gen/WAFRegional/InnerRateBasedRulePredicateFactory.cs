// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerRateBasedRulePredicateFactory(Action<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate>
{

    protected override Humidifier.WAFRegional.RateBasedRuleTypes.Predicate Create()
    {
        var predicateResult = CreatePredicate();
        factoryAction?.Invoke(predicateResult);

        return predicateResult;
    }

    private Humidifier.WAFRegional.RateBasedRuleTypes.Predicate CreatePredicate()
    {
        var predicateResult = new Humidifier.WAFRegional.RateBasedRuleTypes.Predicate();

        return predicateResult;
    }

} // End Of Class

public static class InnerRateBasedRulePredicateFactoryExtensions
{
}
