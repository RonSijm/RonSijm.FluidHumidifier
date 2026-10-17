// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServicePagerDutyAuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig>
{

    internal InnerServiceOAuthClientDetailsFactory OAuthClientCredentialsFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig Create()
    {
        var pagerDutyAuthorizationConfigResult = CreatePagerDutyAuthorizationConfig();
        factoryAction?.Invoke(pagerDutyAuthorizationConfigResult);

        return pagerDutyAuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig CreatePagerDutyAuthorizationConfig()
    {
        var pagerDutyAuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig();

        return pagerDutyAuthorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.OAuthClientCredentials ??= OAuthClientCredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerServicePagerDutyAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials(this InnerServicePagerDutyAuthorizationConfigFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null)
    {
        parentFactory.OAuthClientCredentialsFactory = new InnerServiceOAuthClientDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthClientCredentialsFactory);
    }

    public static CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1>(this CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1>(this CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, T2, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, T2, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServicePagerDutyAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<T1, T2, InnerServicePagerDutyAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, T2, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, T2, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServicePagerDutyAuthorizationConfigFactory, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerServicePagerDutyAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServicePagerDutyAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServicePagerDutyAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, T2, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<InnerServicePagerDutyAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, T2, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerServicePagerDutyAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServicePagerDutyAuthorizationConfigFactory, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServicePagerDutyAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServicePagerDutyAuthorizationConfigFactory, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServicePagerDutyAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServicePagerDutyAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServicePagerDutyAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T5, subFactoryAction).T2);
}
