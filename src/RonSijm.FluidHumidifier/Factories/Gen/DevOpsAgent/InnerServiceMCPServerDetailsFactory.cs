// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails>
{

    internal InnerServiceMCPServerAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails Create()
    {
        var mCPServerDetailsResult = CreateMCPServerDetails();
        factoryAction?.Invoke(mCPServerDetailsResult);

        return mCPServerDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails CreateMCPServerDetails()
    {
        var mCPServerDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails();

        return mCPServerDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceMCPServerDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceMCPServerDetailsFactory, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceMCPServerDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceMCPServerAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceMCPServerDetailsFactory, T1, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceMCPServerDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerDetailsFactory, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceMCPServerDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerDetailsFactory, T1, T2, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceMCPServerDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerDetailsFactory, T2, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceMCPServerDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerDetailsFactory, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceMCPServerDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerDetailsFactory, T1, T2, T3, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceMCPServerDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerDetailsFactory, T2, T3, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceMCPServerDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerDetailsFactory, T3, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceMCPServerDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerDetailsFactory, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerDetailsFactory, T1, T2, T3, T4, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceMCPServerDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerDetailsFactory, T2, T3, T4, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceMCPServerDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerDetailsFactory, T3, T4, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceMCPServerDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerDetailsFactory, T4, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerDetailsFactory, InnerServiceMCPServerAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
