// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupSqliMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement>
{

    internal InnerRuleGroupFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement Create()
    {
        var sqliMatchStatementResult = CreateSqliMatchStatement();
        factoryAction?.Invoke(sqliMatchStatementResult);

        return sqliMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement CreateSqliMatchStatement()
    {
        var sqliMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement();

        return sqliMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.SqliMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupSqliMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupSqliMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch(this InnerRuleGroupSqliMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerRuleGroupFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupSqliMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupSqliMatchStatementFactory, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupSqliMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupSqliMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupSqliMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupSqliMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupSqliMatchStatementFactory, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupSqliMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupSqliMatchStatementFactory, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupSqliMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupSqliMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupSqliMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
