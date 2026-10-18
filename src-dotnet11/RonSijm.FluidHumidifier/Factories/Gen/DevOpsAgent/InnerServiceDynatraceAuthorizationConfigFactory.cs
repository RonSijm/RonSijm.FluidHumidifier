// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceDynatraceAuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig>
{

    internal InnerServiceOAuthClientDetailsFactory OAuthClientCredentialsFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig Create()
    {
        var dynatraceAuthorizationConfigResult = CreateDynatraceAuthorizationConfig();
        factoryAction?.Invoke(dynatraceAuthorizationConfigResult);

        return dynatraceAuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig CreateDynatraceAuthorizationConfig()
    {
        var dynatraceAuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig();

        return dynatraceAuthorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.OAuthClientCredentials ??= OAuthClientCredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerServiceDynatraceAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials(this InnerServiceDynatraceAuthorizationConfigFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null)
    {
        parentFactory.OAuthClientCredentialsFactory = new InnerServiceOAuthClientDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OAuthClientCredentialsFactory);
    }

    public static CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1>(this CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1>(this CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, T2, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, T2, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDynatraceAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2>(this CombinedResult<T1, T2, InnerServiceDynatraceAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, T2, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, T2, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDynatraceAuthorizationConfigFactory, T3, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceDynatraceAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceDynatraceAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceDynatraceAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, T2, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<InnerServiceDynatraceAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, T2, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceDynatraceAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDynatraceAuthorizationConfigFactory, T3, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceDynatraceAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceDynatraceAuthorizationConfigFactory, T4, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceDynatraceAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceDynatraceAuthorizationConfigFactory, InnerServiceOAuthClientDetailsFactory> WithOAuthClientCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceDynatraceAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOAuthClientCredentials(combinedResult.T5, subFactoryAction).T2);
}
