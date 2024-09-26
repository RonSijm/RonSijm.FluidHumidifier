// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupSizeConstraintStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement>
{

    internal InnerRuleGroupFieldToMatchFactory FieldToMatchFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement Create()
    {
        var sizeConstraintStatementResult = CreateSizeConstraintStatement();
        factoryAction?.Invoke(sizeConstraintStatementResult);

        return sizeConstraintStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement CreateSizeConstraintStatement()
    {
        var sizeConstraintStatementResult = new Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement();

        return sizeConstraintStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.SizeConstraintStatement result)
    {
        base.CreateChildren(result);

        result.FieldToMatch ??= FieldToMatchFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupSizeConstraintStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch(this InnerRuleGroupSizeConstraintStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null)
    {
        parentFactory.FieldToMatchFactory = new InnerRuleGroupFieldToMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FieldToMatchFactory);
    }

    public static CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1>(this CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, T2, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupSizeConstraintStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, T2, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupSizeConstraintStatementFactory, T3, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupSizeConstraintStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupSizeConstraintStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupSizeConstraintStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, T2, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupSizeConstraintStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupSizeConstraintStatementFactory, T3, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupSizeConstraintStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupSizeConstraintStatementFactory, T4, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupSizeConstraintStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupSizeConstraintStatementFactory, InnerRuleGroupFieldToMatchFactory> WithFieldToMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupSizeConstraintStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.FieldToMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFieldToMatch(combinedResult.T5, subFactoryAction));
}
