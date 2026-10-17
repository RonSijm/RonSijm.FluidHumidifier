// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPhoneNumberMandatoryKeywordFactory(Action<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword>
{

    protected override Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword Create()
    {
        var mandatoryKeywordResult = CreateMandatoryKeyword();
        factoryAction?.Invoke(mandatoryKeywordResult);

        return mandatoryKeywordResult;
    }

    private Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword CreateMandatoryKeyword()
    {
        var mandatoryKeywordResult = new Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword();

        return mandatoryKeywordResult;
    }

} // End Of Class

public static class InnerPhoneNumberMandatoryKeywordFactoryExtensions
{
}
