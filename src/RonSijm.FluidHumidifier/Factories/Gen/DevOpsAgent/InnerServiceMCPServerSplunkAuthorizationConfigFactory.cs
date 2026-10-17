// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerSplunkAuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig>
{

    internal InnerServiceBearerTokenDetailsFactory BearerTokenFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig Create()
    {
        var mCPServerSplunkAuthorizationConfigResult = CreateMCPServerSplunkAuthorizationConfig();
        factoryAction?.Invoke(mCPServerSplunkAuthorizationConfigResult);

        return mCPServerSplunkAuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig CreateMCPServerSplunkAuthorizationConfig()
    {
        var mCPServerSplunkAuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig();

        return mCPServerSplunkAuthorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.BearerToken ??= BearerTokenFactory?.Build();
    }

} // End Of Class

public static class InnerServiceMCPServerSplunkAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken(this InnerServiceMCPServerSplunkAuthorizationConfigFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null)
    {
        parentFactory.BearerTokenFactory = new InnerServiceBearerTokenDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BearerTokenFactory);
    }

    public static CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1>(this CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1>(this CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, T2, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2>(this CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T2, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2>(this CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2>(this CombinedResult<T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, T2, T3, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T2, T3, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T3, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, T2, T3, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<InnerServiceMCPServerSplunkAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T2, T3, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T3, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerSplunkAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerSplunkAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T5, subFactoryAction).T2);
}
