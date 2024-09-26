// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerAddonInstanceFactory(string resourceName = null, Action<Humidifier.SES.MailManagerAddonInstance> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerAddonInstance>(resourceName)
{

    protected override Humidifier.SES.MailManagerAddonInstance Create()
    {
        var mailManagerAddonInstanceResult = CreateMailManagerAddonInstance();
        factoryAction?.Invoke(mailManagerAddonInstanceResult);

        return mailManagerAddonInstanceResult;
    }

    private Humidifier.SES.MailManagerAddonInstance CreateMailManagerAddonInstance()
    {
        var mailManagerAddonInstanceResult = new Humidifier.SES.MailManagerAddonInstance
        {
            GivenName = InputResourceName,
        };

        return mailManagerAddonInstanceResult;
    }

} // End Of Class

public static class MailManagerAddonInstanceFactoryExtensions
{
}
