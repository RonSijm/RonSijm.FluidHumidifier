// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPoolMandatoryKeywordsFactory(Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords>
{

    internal InnerPoolMandatoryKeywordFactory HELPFactory { get; set; }

    internal InnerPoolMandatoryKeywordFactory STOPFactory { get; set; }

    protected override Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords Create()
    {
        var mandatoryKeywordsResult = CreateMandatoryKeywords();
        factoryAction?.Invoke(mandatoryKeywordsResult);

        return mandatoryKeywordsResult;
    }

    private Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords CreateMandatoryKeywords()
    {
        var mandatoryKeywordsResult = new Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords();

        return mandatoryKeywordsResult;
    }
    public override void CreateChildren(Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords result)
    {
        base.CreateChildren(result);

        result.HELP ??= HELPFactory?.Build();
        result.STOP ??= STOPFactory?.Build();
    }

} // End Of Class

public static class InnerPoolMandatoryKeywordsFactoryExtensions
{
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithHELP(this InnerPoolMandatoryKeywordsFactory parentFactory, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null)
    {
        parentFactory.HELPFactory = new InnerPoolMandatoryKeywordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HELPFactory);
    }

    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithSTOP(this InnerPoolMandatoryKeywordsFactory parentFactory, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null)
    {
        parentFactory.STOPFactory = new InnerPoolMandatoryKeywordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.STOPFactory);
    }

    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, InnerPoolMandatoryKeywordFactory> WithHELP<T1>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithHELP<T1>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2>(this CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3, T4, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3, T4, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3, T4, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory, T4, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, InnerPoolMandatoryKeywordFactory> WithSTOP<T1>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithSTOP<T1>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2>(this CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3, T4, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<InnerPoolMandatoryKeywordsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3, T4, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, InnerPoolMandatoryKeywordsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3, T4, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPoolMandatoryKeywordsFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory, T4, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPoolMandatoryKeywordsFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPoolMandatoryKeywordsFactory, InnerPoolMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPoolMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T5, subFactoryAction).T2);
}
