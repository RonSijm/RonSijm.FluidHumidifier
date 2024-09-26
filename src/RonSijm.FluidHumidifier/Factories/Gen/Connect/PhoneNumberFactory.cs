// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class PhoneNumberFactory(string resourceName = null, Action<Humidifier.Connect.PhoneNumber> factoryAction = null) : ResourceFactory<Humidifier.Connect.PhoneNumber>(resourceName)
{

    protected override Humidifier.Connect.PhoneNumber Create()
    {
        var phoneNumberResult = CreatePhoneNumber();
        factoryAction?.Invoke(phoneNumberResult);

        return phoneNumberResult;
    }

    private Humidifier.Connect.PhoneNumber CreatePhoneNumber()
    {
        var phoneNumberResult = new Humidifier.Connect.PhoneNumber
        {
            GivenName = InputResourceName,
        };

        return phoneNumberResult;
    }

} // End Of Class

public static class PhoneNumberFactoryExtensions
{
}
