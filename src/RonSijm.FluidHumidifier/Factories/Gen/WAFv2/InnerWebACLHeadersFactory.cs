// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLHeadersFactory(Action<Humidifier.WAFv2.WebACLTypes.Headers> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.Headers>
{

    internal InnerWebACLHeaderMatchPatternFactory MatchPatternFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.Headers Create()
    {
        var headersResult = CreateHeaders();
        factoryAction?.Invoke(headersResult);

        return headersResult;
    }

    private Humidifier.WAFv2.WebACLTypes.Headers CreateHeaders()
    {
        var headersResult = new Humidifier.WAFv2.WebACLTypes.Headers();

        return headersResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.Headers result)
    {
        base.CreateChildren(result);

        result.MatchPattern ??= MatchPatternFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLHeadersFactoryExtensions
{
    public static CombinedResult<InnerWebACLHeadersFactory, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern(this InnerWebACLHeadersFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null)
    {
        parentFactory.MatchPatternFactory = new InnerWebACLHeaderMatchPatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPatternFactory);
    }

    public static CombinedResult<InnerWebACLHeadersFactory, T1, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<InnerWebACLHeadersFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLHeadersFactory, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<T1, InnerWebACLHeadersFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLHeadersFactory, T1, T2, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<InnerWebACLHeadersFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLHeadersFactory, T2, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, InnerWebACLHeadersFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLHeadersFactory, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, T2, InnerWebACLHeadersFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLHeadersFactory, T1, T2, T3, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<InnerWebACLHeadersFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLHeadersFactory, T2, T3, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, InnerWebACLHeadersFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLHeadersFactory, T3, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLHeadersFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLHeadersFactory, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLHeadersFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLHeadersFactory, T1, T2, T3, T4, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<InnerWebACLHeadersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLHeadersFactory, T2, T3, T4, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLHeadersFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLHeadersFactory, T3, T4, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLHeadersFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLHeadersFactory, T4, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLHeadersFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLHeadersFactory, InnerWebACLHeaderMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLHeadersFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.HeaderMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T5, subFactoryAction));
}
