// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerRulePredicateFactory(Action<Humidifier.WAFRegional.RuleTypes.Predicate> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.RuleTypes.Predicate>
{

    protected override Humidifier.WAFRegional.RuleTypes.Predicate Create()
    {
        var predicateResult = CreatePredicate();
        factoryAction?.Invoke(predicateResult);

        return predicateResult;
    }

    private Humidifier.WAFRegional.RuleTypes.Predicate CreatePredicate()
    {
        var predicateResult = new Humidifier.WAFRegional.RuleTypes.Predicate();

        return predicateResult;
    }

} // End Of Class

public static class InnerRulePredicateFactoryExtensions
{
}
