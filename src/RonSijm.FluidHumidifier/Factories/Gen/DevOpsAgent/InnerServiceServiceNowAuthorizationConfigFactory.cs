// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceServiceNowAuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig>
{

    internal InnerServiceOAuthClientDetailsFactory OAuthClientCredentialsFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig Create()
    {
        var serviceNowAuthorizationConfigResult = CreateServiceNowAuthorizationConfig();
        factoryAction?.Invoke(serviceNowAuthorizationConfigResult);

        return serviceNowAuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig CreateServiceNowAuthorizationConfig()
    {
        var serviceNowAuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig();

        return serviceNowAuthorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.OAuthClientCredentials ??= OAuthClientCredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerServiceServiceNowAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials(this InnerServiceServiceNowAuthorizationConfigFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null)
    {
        parentFactory.OAuthClientCredentialsFactory = new InnerServiceOAuthClientDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthClientCredentialsFactory);
    }

    public static CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1>(this CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1>(this CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, T2, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, T2, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceServiceNowAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<T1, T2, InnerServiceServiceNowAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, T2, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, T2, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceServiceNowAuthorizationConfigFactory, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceServiceNowAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceServiceNowAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceServiceNowAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, T2, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<InnerServiceServiceNowAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, T2, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceServiceNowAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceServiceNowAuthorizationConfigFactory, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceServiceNowAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceServiceNowAuthorizationConfigFactory, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceServiceNowAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceServiceNowAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceServiceNowAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T5, subFactoryAction).T2);
}
