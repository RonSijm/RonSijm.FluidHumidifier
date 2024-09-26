// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAF;

public class InnerRulePredicateFactory(Action<Humidifier.WAF.RuleTypes.Predicate> factoryAction = null) : SubResourceFactory<Humidifier.WAF.RuleTypes.Predicate>
{

    protected override Humidifier.WAF.RuleTypes.Predicate Create()
    {
        var predicateResult = CreatePredicate();
        factoryAction?.Invoke(predicateResult);

        return predicateResult;
    }

    private Humidifier.WAF.RuleTypes.Predicate CreatePredicate()
    {
        var predicateResult = new Humidifier.WAF.RuleTypes.Predicate();

        return predicateResult;
    }

} // End Of Class

public static class InnerRulePredicateFactoryExtensions
{
}
