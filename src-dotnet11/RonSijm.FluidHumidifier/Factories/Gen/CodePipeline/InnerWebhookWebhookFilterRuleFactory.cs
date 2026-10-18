// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerWebhookWebhookFilterRuleFactory(Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule>
{

    protected override Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule Create()
    {
        var webhookFilterRuleResult = CreateWebhookFilterRule();
        factoryAction?.Invoke(webhookFilterRuleResult);

        return webhookFilterRuleResult;
    }

    private Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule CreateWebhookFilterRule()
    {
        var webhookFilterRuleResult = new Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule();

        return webhookFilterRuleResult;
    }

} // End Of Class

public static class InnerWebhookWebhookFilterRuleFactoryExtensions
{
}
