// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class WebhookFactory(string resourceName = null, Action<Humidifier.CodePipeline.Webhook> factoryAction = null) : ResourceFactory<Humidifier.CodePipeline.Webhook>(resourceName)
{

    internal List<InnerWebhookWebhookFilterRuleFactory> FiltersFactories { get; set; } = [];

    internal InnerWebhookWebhookAuthConfigurationFactory AuthenticationConfigurationFactory { get; set; }

    protected override Humidifier.CodePipeline.Webhook Create()
    {
        var webhookResult = CreateWebhook();
        factoryAction?.Invoke(webhookResult);

        return webhookResult;
    }

    private Humidifier.CodePipeline.Webhook CreateWebhook()
    {
        var webhookResult = new Humidifier.CodePipeline.Webhook
        {
            GivenName = InputResourceName,
        };

        return webhookResult;
    }
    public override void CreateChildren(Humidifier.CodePipeline.Webhook result)
    {
        base.CreateChildren(result);

        result.Filters = FiltersFactories.Any() ? FiltersFactories.Select(x => x.Build()).ToList() : null;
        result.AuthenticationConfiguration ??= AuthenticationConfigurationFactory?.Build();
    }

} // End Of Class

public static class WebhookFactoryExtensions
{
    public static CombinedResult<WebhookFactory, InnerWebhookWebhookFilterRuleFactory> WithFilters(this WebhookFactory parentFactory, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null)
    {
        var factory = new InnerWebhookWebhookFilterRuleFactory(subFactoryAction);
        parentFactory.FiltersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WebhookFactory, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration(this WebhookFactory parentFactory, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthenticationConfigurationFactory = new InnerWebhookWebhookAuthConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationConfigurationFactory);
    }

    public static CombinedResult<WebhookFactory, T1, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1>(this CombinedResult<WebhookFactory, T1> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1>(this CombinedResult<T1, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, T2, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2>(this CombinedResult<WebhookFactory, T1, T2> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, T2, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2>(this CombinedResult<T1, WebhookFactory, T2> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebhookFactory, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2>(this CombinedResult<T1, T2, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, T2, T3, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3>(this CombinedResult<WebhookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, T2, T3, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, WebhookFactory, T2, T3> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebhookFactory, T3, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, WebhookFactory, T3> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebhookFactory, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, T2, T3, T4, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<WebhookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, T2, T3, T4, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, WebhookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebhookFactory, T3, T4, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebhookFactory, T3, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebhookFactory, T4, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebhookFactory, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebhookFactory, InnerWebhookWebhookFilterRuleFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<WebhookFactory, T1> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<T1, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, T2, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<WebhookFactory, T1, T2> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, T2, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, WebhookFactory, T2> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebhookFactory, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, T2, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, T2, T3, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<WebhookFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, T2, T3, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, WebhookFactory, T2, T3> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebhookFactory, T3, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WebhookFactory, T3> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebhookFactory, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebhookFactory, T1, T2, T3, T4, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<WebhookFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebhookFactory, T2, T3, T4, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WebhookFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebhookFactory, T3, T4, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebhookFactory, T3, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebhookFactory, T4, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebhookFactory, T4> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebhookFactory, InnerWebhookWebhookAuthConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebhookFactory> combinedResult, Action<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T5, subFactoryAction));
}
