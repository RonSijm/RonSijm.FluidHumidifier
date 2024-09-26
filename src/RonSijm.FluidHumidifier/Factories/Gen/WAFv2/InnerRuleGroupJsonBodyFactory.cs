// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupJsonBodyFactory(Action<Humidifier.WAFv2.RuleGroupTypes.JsonBody> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.JsonBody>
{

    internal InnerRuleGroupJsonMatchPatternFactory MatchPatternFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.JsonBody Create()
    {
        var jsonBodyResult = CreateJsonBody();
        factoryAction?.Invoke(jsonBodyResult);

        return jsonBodyResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.JsonBody CreateJsonBody()
    {
        var jsonBodyResult = new Humidifier.WAFv2.RuleGroupTypes.JsonBody();

        return jsonBodyResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.JsonBody result)
    {
        base.CreateChildren(result);

        result.MatchPattern ??= MatchPatternFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupJsonBodyFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupJsonBodyFactory, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern(this InnerRuleGroupJsonBodyFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null)
    {
        parentFactory.MatchPatternFactory = new InnerRuleGroupJsonMatchPatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPatternFactory);
    }

    public static CombinedResult<InnerRuleGroupJsonBodyFactory, T1, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<InnerRuleGroupJsonBodyFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupJsonBodyFactory, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<T1, InnerRuleGroupJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupJsonBodyFactory, T1, T2, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<InnerRuleGroupJsonBodyFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupJsonBodyFactory, T2, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, InnerRuleGroupJsonBodyFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupJsonBodyFactory, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupJsonBodyFactory, T1, T2, T3, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<InnerRuleGroupJsonBodyFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupJsonBodyFactory, T2, T3, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupJsonBodyFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupJsonBodyFactory, T3, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupJsonBodyFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupJsonBodyFactory, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupJsonBodyFactory, T1, T2, T3, T4, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupJsonBodyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupJsonBodyFactory, T2, T3, T4, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupJsonBodyFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupJsonBodyFactory, T3, T4, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupJsonBodyFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupJsonBodyFactory, T4, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupJsonBodyFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupJsonBodyFactory, InnerRuleGroupJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T5, subFactoryAction));
}
