// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cases;

public class CaseRuleFactory(string resourceName = null, Action<Humidifier.Cases.CaseRule> factoryAction = null) : ResourceFactory<Humidifier.Cases.CaseRule>(resourceName)
{

    internal InnerCaseRuleCaseRuleDetailsFactory RuleFactory { get; set; }

    protected override Humidifier.Cases.CaseRule Create()
    {
        var caseRuleResult = CreateCaseRule();
        factoryAction?.Invoke(caseRuleResult);

        return caseRuleResult;
    }

    private Humidifier.Cases.CaseRule CreateCaseRule()
    {
        var caseRuleResult = new Humidifier.Cases.CaseRule
        {
            GivenName = InputResourceName,
        };

        return caseRuleResult;
    }
    public override void CreateChildren(Humidifier.Cases.CaseRule result)
    {
        base.CreateChildren(result);

        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class CaseRuleFactoryExtensions
{
    public static CombinedResult<CaseRuleFactory, InnerCaseRuleCaseRuleDetailsFactory> WithRule(this CaseRuleFactory parentFactory, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerCaseRuleCaseRuleDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<CaseRuleFactory, T1, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1>(this CombinedResult<CaseRuleFactory, T1> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CaseRuleFactory, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1>(this CombinedResult<T1, CaseRuleFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CaseRuleFactory, T1, T2, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2>(this CombinedResult<CaseRuleFactory, T1, T2> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CaseRuleFactory, T2, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2>(this CombinedResult<T1, CaseRuleFactory, T2> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CaseRuleFactory, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, CaseRuleFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CaseRuleFactory, T1, T2, T3, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3>(this CombinedResult<CaseRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CaseRuleFactory, T2, T3, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, CaseRuleFactory, T2, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CaseRuleFactory, T3, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, CaseRuleFactory, T3> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CaseRuleFactory, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, CaseRuleFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CaseRuleFactory, T1, T2, T3, T4, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<CaseRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CaseRuleFactory, T2, T3, T4, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, CaseRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CaseRuleFactory, T3, T4, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, CaseRuleFactory, T3, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CaseRuleFactory, T4, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CaseRuleFactory, T4> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CaseRuleFactory, InnerCaseRuleCaseRuleDetailsFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CaseRuleFactory> combinedResult, Action<Humidifier.Cases.CaseRuleTypes.CaseRuleDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction).T2);
}
