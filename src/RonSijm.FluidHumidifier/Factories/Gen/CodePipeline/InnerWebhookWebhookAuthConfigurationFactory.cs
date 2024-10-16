// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerWebhookWebhookAuthConfigurationFactory(Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration>
{

    protected override Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration Create()
    {
        var webhookAuthConfigurationResult = CreateWebhookAuthConfiguration();
        factoryAction?.Invoke(webhookAuthConfigurationResult);

        return webhookAuthConfigurationResult;
    }

    private Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration CreateWebhookAuthConfiguration()
    {
        var webhookAuthConfigurationResult = new Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration();

        return webhookAuthConfigurationResult;
    }

} // End Of Class

public static class InnerWebhookWebhookAuthConfigurationFactoryExtensions
{
}
