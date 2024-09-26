// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCookiesFactory(Action<Humidifier.WAFv2.RuleGroupTypes.Cookies> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.Cookies>
{

    internal InnerRuleGroupCookieMatchPatternFactory MatchPatternFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.Cookies Create()
    {
        var cookiesResult = CreateCookies();
        factoryAction?.Invoke(cookiesResult);

        return cookiesResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.Cookies CreateCookies()
    {
        var cookiesResult = new Humidifier.WAFv2.RuleGroupTypes.Cookies();

        return cookiesResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.Cookies result)
    {
        base.CreateChildren(result);

        result.MatchPattern ??= MatchPatternFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupCookiesFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupCookiesFactory, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern(this InnerRuleGroupCookiesFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null)
    {
        parentFactory.MatchPatternFactory = new InnerRuleGroupCookieMatchPatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPatternFactory);
    }

    public static CombinedResult<InnerRuleGroupCookiesFactory, T1, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<InnerRuleGroupCookiesFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCookiesFactory, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<T1, InnerRuleGroupCookiesFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCookiesFactory, T1, T2, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<InnerRuleGroupCookiesFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCookiesFactory, T2, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, InnerRuleGroupCookiesFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCookiesFactory, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupCookiesFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCookiesFactory, T1, T2, T3, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<InnerRuleGroupCookiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCookiesFactory, T2, T3, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupCookiesFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCookiesFactory, T3, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupCookiesFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCookiesFactory, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupCookiesFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCookiesFactory, T1, T2, T3, T4, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupCookiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCookiesFactory, T2, T3, T4, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupCookiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCookiesFactory, T3, T4, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupCookiesFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCookiesFactory, T4, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupCookiesFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupCookiesFactory, InnerRuleGroupCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupCookiesFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T5, subFactoryAction));
}
