// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class PoolFactory(string resourceName = null, Action<Humidifier.SMSVOICE.Pool> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.Pool>(resourceName)
{

    internal List<InnerPoolOptionalKeywordFactory> OptionalKeywordsFactories { get; set; } = [];

    internal InnerPoolTwoWayFactory TwoWayFactory { get; set; }

    internal InnerPoolMandatoryKeywordsFactory MandatoryKeywordsFactory { get; set; }

    protected override Humidifier.SMSVOICE.Pool Create()
    {
        var poolResult = CreatePool();
        factoryAction?.Invoke(poolResult);

        return poolResult;
    }

    private Humidifier.SMSVOICE.Pool CreatePool()
    {
        var poolResult = new Humidifier.SMSVOICE.Pool
        {
            GivenName = InputResourceName,
        };

        return poolResult;
    }
    public override void CreateChildren(Humidifier.SMSVOICE.Pool result)
    {
        base.CreateChildren(result);

        result.OptionalKeywords = OptionalKeywordsFactories.Any() ? OptionalKeywordsFactories.Select(x => x.Build()).ToList() : null;
        result.TwoWay ??= TwoWayFactory?.Build();
        result.MandatoryKeywords ??= MandatoryKeywordsFactory?.Build();
    }

} // End Of Class

public static class PoolFactoryExtensions
{
    public static CombinedResult<PoolFactory, InnerPoolOptionalKeywordFactory> WithOptionalKeywords(this PoolFactory parentFactory, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null)
    {
        var factory = new InnerPoolOptionalKeywordFactory(subFactoryAction);
        parentFactory.OptionalKeywordsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PoolFactory, InnerPoolTwoWayFactory> WithTwoWay(this PoolFactory parentFactory, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null)
    {
        parentFactory.TwoWayFactory = new InnerPoolTwoWayFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TwoWayFactory);
    }

    public static CombinedResult<PoolFactory, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords(this PoolFactory parentFactory, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null)
    {
        parentFactory.MandatoryKeywordsFactory = new InnerPoolMandatoryKeywordsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MandatoryKeywordsFactory);
    }

    public static CombinedResult<PoolFactory, T1, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1>(this CombinedResult<PoolFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1>(this CombinedResult<T1, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2>(this CombinedResult<PoolFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2>(this CombinedResult<T1, PoolFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2>(this CombinedResult<T1, T2, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, T3, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<PoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, T3, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<T1, PoolFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, T3, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<T1, T2, PoolFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PoolFactory, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<T1, T2, T3, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, T3, T4, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<PoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, T3, T4, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, PoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, T3, T4, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, PoolFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PoolFactory, T4, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PoolFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PoolFactory, InnerPoolOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, InnerPoolTwoWayFactory> WithTwoWay<T1>(this CombinedResult<PoolFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, InnerPoolTwoWayFactory> WithTwoWay<T1>(this CombinedResult<T1, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, InnerPoolTwoWayFactory> WithTwoWay<T1, T2>(this CombinedResult<PoolFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, InnerPoolTwoWayFactory> WithTwoWay<T1, T2>(this CombinedResult<T1, PoolFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, InnerPoolTwoWayFactory> WithTwoWay<T1, T2>(this CombinedResult<T1, T2, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, T3, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<PoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, T3, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<T1, PoolFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, T3, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<T1, T2, PoolFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PoolFactory, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<T1, T2, T3, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, T3, T4, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<PoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, T3, T4, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, PoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, T3, T4, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, T2, PoolFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PoolFactory, T4, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PoolFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PoolFactory, InnerPoolTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1>(this CombinedResult<PoolFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1>(this CombinedResult<T1, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2>(this CombinedResult<PoolFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2>(this CombinedResult<T1, PoolFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2>(this CombinedResult<T1, T2, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, T3, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<PoolFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, T3, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<T1, PoolFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, T3, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<T1, T2, PoolFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PoolFactory, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<T1, T2, T3, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PoolFactory, T1, T2, T3, T4, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<PoolFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PoolFactory, T2, T3, T4, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, PoolFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PoolFactory, T3, T4, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, PoolFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PoolFactory, T4, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PoolFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PoolFactory, InnerPoolMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PoolFactory> combinedResult, Action<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T5, subFactoryAction).T2);
}
