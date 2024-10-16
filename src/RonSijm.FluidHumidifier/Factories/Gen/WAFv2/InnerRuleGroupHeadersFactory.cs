// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupHeadersFactory(Action<Humidifier.WAFv2.RuleGroupTypes.Headers> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.Headers>
{

    internal InnerRuleGroupHeaderMatchPatternFactory MatchPatternFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.Headers Create()
    {
        var headersResult = CreateHeaders();
        factoryAction?.Invoke(headersResult);

        return headersResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.Headers CreateHeaders()
    {
        var headersResult = new Humidifier.WAFv2.RuleGroupTypes.Headers();

        return headersResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.Headers result)
    {
        base.CreateChildren(result);

        result.MatchPattern ??= MatchPatternFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupHeadersFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupHeadersFactory, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern(this InnerRuleGroupHeadersFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null)
    {
        parentFactory.MatchPatternFactory = new InnerRuleGroupHeaderMatchPatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPatternFactory);
    }

    public static CombinedResult<InnerRuleGroupHeadersFactory, T1, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<InnerRuleGroupHeadersFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupHeadersFactory, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<T1, InnerRuleGroupHeadersFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupHeadersFactory, T1, T2, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<InnerRuleGroupHeadersFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupHeadersFactory, T2, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, InnerRuleGroupHeadersFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupHeadersFactory, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupHeadersFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupHeadersFactory, T1, T2, T3, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<InnerRuleGroupHeadersFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupHeadersFactory, T2, T3, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupHeadersFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupHeadersFactory, T3, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupHeadersFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupHeadersFactory, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupHeadersFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupHeadersFactory, T1, T2, T3, T4, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupHeadersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupHeadersFactory, T2, T3, T4, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupHeadersFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupHeadersFactory, T3, T4, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupHeadersFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupHeadersFactory, T4, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupHeadersFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupHeadersFactory, InnerRuleGroupHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupHeadersFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T5, subFactoryAction));
}
