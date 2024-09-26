// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupXssMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement>
{

    internal InnerRuleGroupFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement Create()
    {
        var xssMatchStatementResult = CreateXssMatchStatement();
        factoryAction?.Invoke(xssMatchStatementResult);

        return xssMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement CreateXssMatchStatement()
    {
        var xssMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement();

        return xssMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.XssMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupXssMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupXssMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch(this InnerRuleGroupXssMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerRuleGroupFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupXssMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupXssMatchStatementFactory, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupXssMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupXssMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupXssMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupXssMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupXssMatchStatementFactory, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupXssMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupXssMatchStatementFactory, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupXssMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupXssMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupXssMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
