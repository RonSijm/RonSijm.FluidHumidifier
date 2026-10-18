// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerGrafanaDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails>
{

    internal InnerServiceMCPServerGrafanaAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails Create()
    {
        var mCPServerGrafanaDetailsResult = CreateMCPServerGrafanaDetails();
        factoryAction?.Invoke(mCPServerGrafanaDetailsResult);

        return mCPServerGrafanaDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails CreateMCPServerGrafanaDetails()
    {
        var mCPServerGrafanaDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails();

        return mCPServerGrafanaDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceMCPServerGrafanaDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceMCPServerGrafanaDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceMCPServerGrafanaAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, T2, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerGrafanaDetailsFactory, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceMCPServerGrafanaDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, T2, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, T2, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerGrafanaDetailsFactory, T3, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceMCPServerGrafanaDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaDetailsFactory, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, T2, T3, T4, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceMCPServerGrafanaDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, T2, T3, T4, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceMCPServerGrafanaDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerGrafanaDetailsFactory, T3, T4, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceMCPServerGrafanaDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaDetailsFactory, T4, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerGrafanaDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerGrafanaDetailsFactory, InnerServiceMCPServerGrafanaAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerGrafanaDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
