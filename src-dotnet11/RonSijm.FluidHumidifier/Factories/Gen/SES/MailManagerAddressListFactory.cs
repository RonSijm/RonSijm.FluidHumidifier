// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerAddressListFactory(string resourceName = null, Action<Humidifier.SES.MailManagerAddressList> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerAddressList>(resourceName)
{

    protected override Humidifier.SES.MailManagerAddressList Create()
    {
        var mailManagerAddressListResult = CreateMailManagerAddressList();
        factoryAction?.Invoke(mailManagerAddressListResult);

        return mailManagerAddressListResult;
    }

    private Humidifier.SES.MailManagerAddressList CreateMailManagerAddressList()
    {
        var mailManagerAddressListResult = new Humidifier.SES.MailManagerAddressList
        {
            GivenName = InputResourceName,
        };

        return mailManagerAddressListResult;
    }

} // End Of Class

public static class MailManagerAddressListFactoryExtensions
{
}
