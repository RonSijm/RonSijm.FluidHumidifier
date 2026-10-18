// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class PhoneNumberFactory(string resourceName = null, Action<Humidifier.SMSVOICE.PhoneNumber> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.PhoneNumber>(resourceName)
{

    internal List<InnerPhoneNumberOptionalKeywordFactory> OptionalKeywordsFactories { get; set; } = [];

    internal InnerPhoneNumberTwoWayFactory TwoWayFactory { get; set; }

    internal InnerPhoneNumberMandatoryKeywordsFactory MandatoryKeywordsFactory { get; set; }

    protected override Humidifier.SMSVOICE.PhoneNumber Create()
    {
        var phoneNumberResult = CreatePhoneNumber();
        factoryAction?.Invoke(phoneNumberResult);

        return phoneNumberResult;
    }

    private Humidifier.SMSVOICE.PhoneNumber CreatePhoneNumber()
    {
        var phoneNumberResult = new Humidifier.SMSVOICE.PhoneNumber
        {
            GivenName = InputResourceName,
        };

        return phoneNumberResult;
    }
    public override void CreateChildren(Humidifier.SMSVOICE.PhoneNumber result)
    {
        base.CreateChildren(result);

        result.OptionalKeywords = OptionalKeywordsFactories.Any() ? OptionalKeywordsFactories.Select(x => x.Build()).ToList() : null;
        result.TwoWay ??= TwoWayFactory?.Build();
        result.MandatoryKeywords ??= MandatoryKeywordsFactory?.Build();
    }

} // End Of Class

public static class PhoneNumberFactoryExtensions
{
    public static CombinedResult<PhoneNumberFactory, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords(this PhoneNumberFactory parentFactory, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null)
    {
        var factory = new InnerPhoneNumberOptionalKeywordFactory(subFactoryAction);
        parentFactory.OptionalKeywordsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PhoneNumberFactory, InnerPhoneNumberTwoWayFactory> WithTwoWay(this PhoneNumberFactory parentFactory, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null)
    {
        parentFactory.TwoWayFactory = new InnerPhoneNumberTwoWayFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TwoWayFactory);
    }

    public static CombinedResult<PhoneNumberFactory, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords(this PhoneNumberFactory parentFactory, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null)
    {
        parentFactory.MandatoryKeywordsFactory = new InnerPhoneNumberMandatoryKeywordsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MandatoryKeywordsFactory);
    }

    public static CombinedResult<PhoneNumberFactory, T1, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1>(this CombinedResult<PhoneNumberFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1>(this CombinedResult<T1, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2>(this CombinedResult<PhoneNumberFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2>(this CombinedResult<T1, PhoneNumberFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2>(this CombinedResult<T1, T2, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, T3, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<PhoneNumberFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, T3, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<T1, PhoneNumberFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, T3, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<T1, T2, PhoneNumberFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PhoneNumberFactory, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3>(this CombinedResult<T1, T2, T3, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, T3, T4, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<PhoneNumberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, T3, T4, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, PhoneNumberFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, T3, T4, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, PhoneNumberFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PhoneNumberFactory, T4, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PhoneNumberFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PhoneNumberFactory, InnerPhoneNumberOptionalKeywordFactory> WithOptionalKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionalKeywords(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1>(this CombinedResult<PhoneNumberFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1>(this CombinedResult<T1, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2>(this CombinedResult<PhoneNumberFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2>(this CombinedResult<T1, PhoneNumberFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2>(this CombinedResult<T1, T2, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, T3, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<PhoneNumberFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, T3, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<T1, PhoneNumberFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, T3, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<T1, T2, PhoneNumberFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PhoneNumberFactory, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3>(this CombinedResult<T1, T2, T3, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, T3, T4, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<PhoneNumberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, T3, T4, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, PhoneNumberFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, T3, T4, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, T2, PhoneNumberFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PhoneNumberFactory, T4, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PhoneNumberFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PhoneNumberFactory, InnerPhoneNumberTwoWayFactory> WithTwoWay<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTwoWay(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1>(this CombinedResult<PhoneNumberFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1>(this CombinedResult<T1, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2>(this CombinedResult<PhoneNumberFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2>(this CombinedResult<T1, PhoneNumberFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2>(this CombinedResult<T1, T2, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<PhoneNumberFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<T1, PhoneNumberFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, T3, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<T1, T2, PhoneNumberFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PhoneNumberFactory, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3>(this CombinedResult<T1, T2, T3, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PhoneNumberFactory, T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<PhoneNumberFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PhoneNumberFactory, T2, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, PhoneNumberFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PhoneNumberFactory, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, PhoneNumberFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PhoneNumberFactory, T4, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PhoneNumberFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PhoneNumberFactory, InnerPhoneNumberMandatoryKeywordsFactory> WithMandatoryKeywords<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PhoneNumberFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMandatoryKeywords(combinedResult.T5, subFactoryAction).T2);
}
