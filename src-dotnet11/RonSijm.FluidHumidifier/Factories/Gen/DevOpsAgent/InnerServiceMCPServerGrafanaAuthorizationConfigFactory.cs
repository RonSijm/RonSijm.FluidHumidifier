// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerGrafanaAuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig>
{

    internal InnerServiceBearerTokenDetailsFactory BearerTokenFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig Create()
    {
        var mCPServerGrafanaAuthorizationConfigResult = CreateMCPServerGrafanaAuthorizationConfig();
        factoryAction?.Invoke(mCPServerGrafanaAuthorizationConfigResult);

        return mCPServerGrafanaAuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig CreateMCPServerGrafanaAuthorizationConfig()
    {
        var mCPServerGrafanaAuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig();

        return mCPServerGrafanaAuthorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.BearerToken ??= BearerTokenFactory?.Build();
    }

} // End Of Class

public static class InnerServiceMCPServerGrafanaAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken(this InnerServiceMCPServerGrafanaAuthorizationConfigFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null)
    {
        parentFactory.BearerTokenFactory = new InnerServiceBearerTokenDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BearerTokenFactory);
    }

    public static CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1>(this CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1>(this CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, T2, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2>(this CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T2, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2>(this CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2>(this CombinedResult<T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, T2, T3, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T2, T3, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T3, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, T2, T3, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T2, T3, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T3, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T4, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerGrafanaAuthorizationConfigFactory, InnerServiceBearerTokenDetailsFactory> WithBearerToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBearerToken(combinedResult.T5, subFactoryAction).T2);
}
