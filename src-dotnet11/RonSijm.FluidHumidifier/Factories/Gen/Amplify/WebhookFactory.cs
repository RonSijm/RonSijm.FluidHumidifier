// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class WebhookFactory(string resourceName = null, Action<Humidifier.Amplify.Webhook> factoryAction = null) : ResourceFactory<Humidifier.Amplify.Webhook>(resourceName)
{

    protected override Humidifier.Amplify.Webhook Create()
    {
        var webhookResult = CreateWebhook();
        factoryAction?.Invoke(webhookResult);

        return webhookResult;
    }

    private Humidifier.Amplify.Webhook CreateWebhook()
    {
        var webhookResult = new Humidifier.Amplify.Webhook
        {
            GivenName = InputResourceName,
        };

        return webhookResult;
    }

} // End Of Class

public static class WebhookFactoryExtensions
{
}
