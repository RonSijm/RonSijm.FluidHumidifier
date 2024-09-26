// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MailManagerAddonSubscriptionFactory(string resourceName = null, Action<Humidifier.SES.MailManagerAddonSubscription> factoryAction = null) : ResourceFactory<Humidifier.SES.MailManagerAddonSubscription>(resourceName)
{

    protected override Humidifier.SES.MailManagerAddonSubscription Create()
    {
        var mailManagerAddonSubscriptionResult = CreateMailManagerAddonSubscription();
        factoryAction?.Invoke(mailManagerAddonSubscriptionResult);

        return mailManagerAddonSubscriptionResult;
    }

    private Humidifier.SES.MailManagerAddonSubscription CreateMailManagerAddonSubscription()
    {
        var mailManagerAddonSubscriptionResult = new Humidifier.SES.MailManagerAddonSubscription
        {
            GivenName = InputResourceName,
        };

        return mailManagerAddonSubscriptionResult;
    }

} // End Of Class

public static class MailManagerAddonSubscriptionFactoryExtensions
{
}
