// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NotificationsContacts;

public class EmailContactFactory(string resourceName = null, Action<Humidifier.NotificationsContacts.EmailContact> factoryAction = null) : ResourceFactory<Humidifier.NotificationsContacts.EmailContact>(resourceName)
{

    protected override Humidifier.NotificationsContacts.EmailContact Create()
    {
        var emailContactResult = CreateEmailContact();
        factoryAction?.Invoke(emailContactResult);

        return emailContactResult;
    }

    private Humidifier.NotificationsContacts.EmailContact CreateEmailContact()
    {
        var emailContactResult = new Humidifier.NotificationsContacts.EmailContact
        {
            GivenName = InputResourceName,
        };

        return emailContactResult;
    }

} // End Of Class

public static class EmailContactFactoryExtensions
{
}
