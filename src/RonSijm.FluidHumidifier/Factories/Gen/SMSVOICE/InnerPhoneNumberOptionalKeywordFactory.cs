// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class InnerPhoneNumberOptionalKeywordFactory(Action<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> factoryAction = null) : SubResourceFactory<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword>
{

    protected override Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword Create()
    {
        var optionalKeywordResult = CreateOptionalKeyword();
        factoryAction?.Invoke(optionalKeywordResult);

        return optionalKeywordResult;
    }

    private Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword CreateOptionalKeyword()
    {
        var optionalKeywordResult = new Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword();

        return optionalKeywordResult;
    }

} // End Of Class

public static class InnerPhoneNumberOptionalKeywordFactoryExtensions
{
}
