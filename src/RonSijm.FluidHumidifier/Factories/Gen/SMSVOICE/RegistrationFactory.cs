// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class RegistrationFactory(string resourceName = null, Action<Humidifier.SMSVOICE.Registration> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.Registration>(resourceName)
{

    protected override Humidifier.SMSVOICE.Registration Create()
    {
        var registrationResult = CreateRegistration();
        factoryAction?.Invoke(registrationResult);

        return registrationResult;
    }

    private Humidifier.SMSVOICE.Registration CreateRegistration()
    {
        var registrationResult = new Humidifier.SMSVOICE.Registration
        {
            GivenName = InputResourceName,
        };

        return registrationResult;
    }

} // End Of Class

public static class RegistrationFactoryExtensions
{
}
