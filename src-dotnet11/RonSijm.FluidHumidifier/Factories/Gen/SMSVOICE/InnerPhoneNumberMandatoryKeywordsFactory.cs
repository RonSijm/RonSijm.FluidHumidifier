// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPhoneNumberMandatoryKeywordsFactory(Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords>
{

    internal InnerPhoneNumberMandatoryKeywordFactory HELPFactory { get; set; }

    internal InnerPhoneNumberMandatoryKeywordFactory STOPFactory { get; set; }

    protected override Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords Create()
    {
        var mandatoryKeywordsResult = CreateMandatoryKeywords();
        factoryAction?.Invoke(mandatoryKeywordsResult);

        return mandatoryKeywordsResult;
    }

    private Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords CreateMandatoryKeywords()
    {
        var mandatoryKeywordsResult = new Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords();

        return mandatoryKeywordsResult;
    }
    public override void CreateChildren(Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords result)
    {
        base.CreateChildren(result);

        result.HELP ??= HELPFactory?.Build();
        result.STOP ??= STOPFactory?.Build();
    }

} // End Of Class

public static class InnerPhoneNumberMandatoryKeywordsFactoryExtensions
{
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithHELP(this InnerPhoneNumberMandatoryKeywordsFactory parentFactory, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null)
    {
        parentFactory.HELPFactory = new InnerPhoneNumberMandatoryKeywordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HELPFactory);
    }

    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP(this InnerPhoneNumberMandatoryKeywordsFactory parentFactory, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null)
    {
        parentFactory.STOPFactory = new InnerPhoneNumberMandatoryKeywordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.STOPFactory);
    }

    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2>(this CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3, T4, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3, T4, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory, T4, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithHELP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHELP(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2>(this CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<InnerPhoneNumberMandatoryKeywordsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3, T4, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, InnerPhoneNumberMandatoryKeywordsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3, T4, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPhoneNumberMandatoryKeywordsFactory, T3, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory, T4, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPhoneNumberMandatoryKeywordsFactory, T4> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory, InnerPhoneNumberMandatoryKeywordFactory> WithSTOP<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPhoneNumberMandatoryKeywordsFactory> combinedResult, Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSTOP(combinedResult.T5, subFactoryAction).T2);
}
