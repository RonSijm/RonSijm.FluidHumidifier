// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class EmailAddressFactory(string resourceName = null, Action<Humidifier.Connect.EmailAddress> factoryAction = null) : ResourceFactory<Humidifier.Connect.EmailAddress>(resourceName)
{

    protected override Humidifier.Connect.EmailAddress Create()
    {
        var emailAddressResult = CreateEmailAddress();
        factoryAction?.Invoke(emailAddressResult);

        return emailAddressResult;
    }

    private Humidifier.Connect.EmailAddress CreateEmailAddress()
    {
        var emailAddressResult = new Humidifier.Connect.EmailAddress
        {
            GivenName = InputResourceName,
        };

        return emailAddressResult;
    }

} // End Of Class

public static class EmailAddressFactoryExtensions
{
}
