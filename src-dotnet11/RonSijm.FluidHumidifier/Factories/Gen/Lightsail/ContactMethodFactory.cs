// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class ContactMethodFactory(string resourceName = null, Action<Humidifier.Lightsail.ContactMethod> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.ContactMethod>(resourceName)
{

    protected override Humidifier.Lightsail.ContactMethod Create()
    {
        var contactMethodResult = CreateContactMethod();
        factoryAction?.Invoke(contactMethodResult);

        return contactMethodResult;
    }

    private Humidifier.Lightsail.ContactMethod CreateContactMethod()
    {
        var contactMethodResult = new Humidifier.Lightsail.ContactMethod
        {
            GivenName = InputResourceName,
        };

        return contactMethodResult;
    }

} // End Of Class

public static class ContactMethodFactoryExtensions
{
}
