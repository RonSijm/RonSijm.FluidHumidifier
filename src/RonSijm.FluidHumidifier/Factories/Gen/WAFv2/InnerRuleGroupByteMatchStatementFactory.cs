// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupByteMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement>
{

    internal InnerRuleGroupFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement Create()
    {
        var byteMatchStatementResult = CreateByteMatchStatement();
        factoryAction?.Invoke(byteMatchStatementResult);

        return byteMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement CreateByteMatchStatement()
    {
        var byteMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement();

        return byteMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.ByteMatchStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupByteMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupByteMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch(this InnerRuleGroupByteMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerRuleGroupFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupByteMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupByteMatchStatementFactory, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupByteMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupByteMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupByteMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupByteMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupByteMatchStatementFactory, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupByteMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupByteMatchStatementFactory, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupByteMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupByteMatchStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupByteMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
