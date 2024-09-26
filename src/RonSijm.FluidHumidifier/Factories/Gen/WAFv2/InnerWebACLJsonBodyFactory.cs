// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLJsonBodyFactory(Action<Humidifier.WAFv2.WebACLTypes.JsonBody> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.JsonBody>
{

    internal InnerWebACLJsonMatchPatternFactory MatchPatternFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.JsonBody Create()
    {
        var jsonBodyResult = CreateJsonBody();
        factoryAction?.Invoke(jsonBodyResult);

        return jsonBodyResult;
    }

    private Humidifier.WAFv2.WebACLTypes.JsonBody CreateJsonBody()
    {
        var jsonBodyResult = new Humidifier.WAFv2.WebACLTypes.JsonBody();

        return jsonBodyResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.JsonBody result)
    {
        base.CreateChildren(result);

        result.MatchPattern ??= MatchPatternFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLJsonBodyFactoryExtensions
{
    public static CombinedResult<InnerWebACLJsonBodyFactory, InnerWebACLJsonMatchPatternFactory> WithMatchPattern(this InnerWebACLJsonBodyFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null)
    {
        parentFactory.MatchPatternFactory = new InnerWebACLJsonMatchPatternFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPatternFactory);
    }

    public static CombinedResult<InnerWebACLJsonBodyFactory, T1, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<InnerWebACLJsonBodyFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLJsonBodyFactory, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1>(this CombinedResult<T1, InnerWebACLJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLJsonBodyFactory, T1, T2, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<InnerWebACLJsonBodyFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLJsonBodyFactory, T2, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, InnerWebACLJsonBodyFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLJsonBodyFactory, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2>(this CombinedResult<T1, T2, InnerWebACLJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLJsonBodyFactory, T1, T2, T3, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<InnerWebACLJsonBodyFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLJsonBodyFactory, T2, T3, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, InnerWebACLJsonBodyFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLJsonBodyFactory, T3, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLJsonBodyFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLJsonBodyFactory, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLJsonBodyFactory, T1, T2, T3, T4, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<InnerWebACLJsonBodyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLJsonBodyFactory, T2, T3, T4, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLJsonBodyFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLJsonBodyFactory, T3, T4, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLJsonBodyFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLJsonBodyFactory, T4, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLJsonBodyFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLJsonBodyFactory, InnerWebACLJsonMatchPatternFactory> WithMatchPattern<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLJsonBodyFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.JsonMatchPattern> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPattern(combinedResult.T5, subFactoryAction));
}
