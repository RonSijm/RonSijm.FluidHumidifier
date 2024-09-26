// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class ContactChannelFactory(string resourceName = null, Action<Humidifier.SSMContacts.ContactChannel> factoryAction = null) : ResourceFactory<Humidifier.SSMContacts.ContactChannel>(resourceName)
{

    protected override Humidifier.SSMContacts.ContactChannel Create()
    {
        var contactChannelResult = CreateContactChannel();
        factoryAction?.Invoke(contactChannelResult);

        return contactChannelResult;
    }

    private Humidifier.SSMContacts.ContactChannel CreateContactChannel()
    {
        var contactChannelResult = new Humidifier.SSMContacts.ContactChannel
        {
            GivenName = InputResourceName,
        };

        return contactChannelResult;
    }

} // End Of Class

public static class ContactChannelFactoryExtensions
{
}
