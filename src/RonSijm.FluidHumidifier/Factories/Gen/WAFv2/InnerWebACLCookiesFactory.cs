// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCookiesFactory(Action<Humidifier.WAFv2.WebACLTypes.Cookies> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.Cookies>
{

    internal InnerWebACLCookieMatchPatternFactory MatchPatternFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.Cookies Create()
    {
        var cookiesResult = CreateCookies();
        factoryAction?.Invoke(cookiesResult);

        return cookiesResult;
    }

    private Humidifier.WAFv2.WebACLTypes.Cookies CreateCookies()
    {
        var cookiesResult = new Humidifier.WAFv2.WebACLTypes.Cookies();

        return cookiesResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.Cookies result)
    {
        base.CreateChildren(result);

        result.MatchPattern ??= MatchPatternFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLCookiesFactoryExtensions
{
    public static CombinedResult<InnerWebACLCookiesFactory, InnerWebACLCookieMatchPatternFactory> WithMatchPattern(this InnerWebACLCookiesFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null)
    {
        parentFactory.MatchPatternFactory = new InnerWebACLCookieMatchPatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPatternFactory);
    }

    public static CombinedResult<InnerWebACLCookiesFactory, T1, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<InnerWebACLCookiesFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCookiesFactory, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<T1, InnerWebACLCookiesFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLCookiesFactory, T1, T2, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<InnerWebACLCookiesFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCookiesFactory, T2, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, InnerWebACLCookiesFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCookiesFactory, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, T2, InnerWebACLCookiesFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLCookiesFactory, T1, T2, T3, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<InnerWebACLCookiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCookiesFactory, T2, T3, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, InnerWebACLCookiesFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCookiesFactory, T3, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLCookiesFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCookiesFactory, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLCookiesFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLCookiesFactory, T1, T2, T3, T4, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<InnerWebACLCookiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCookiesFactory, T2, T3, T4, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLCookiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCookiesFactory, T3, T4, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLCookiesFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCookiesFactory, T4, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLCookiesFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLCookiesFactory, InnerWebACLCookieMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLCookiesFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CookieMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T5, subFactoryAction));
}
