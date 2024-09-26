// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupRegexMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement>
{

    internal InnerRuleGroupFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement Create()
    {
        var regexMatchStatementResult = CreateRegexMatchStatement();
        factoryAction?.Invoke(regexMatchStatementResult);

        return regexMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement CreateRegexMatchStatement()
    {
        var regexMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement();

        return regexMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.RegexMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupRegexMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupRegexMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch(this InnerRuleGroupRegexMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerRuleGroupFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRegexMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRegexMatchStatementFactory, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupRegexMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRegexMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupRegexMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupRegexMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRegexMatchStatementFactory, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupRegexMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRegexMatchStatementFactory, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupRegexMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupRegexMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupRegexMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
