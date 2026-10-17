// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerSplunkDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails>
{

    internal InnerServiceMCPServerSplunkAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails Create()
    {
        var mCPServerSplunkDetailsResult = CreateMCPServerSplunkDetails();
        factoryAction?.Invoke(mCPServerSplunkDetailsResult);

        return mCPServerSplunkDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails CreateMCPServerSplunkDetails()
    {
        var mCPServerSplunkDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails();

        return mCPServerSplunkDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceMCPServerSplunkDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceMCPServerSplunkDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceMCPServerSplunkAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, T2, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSplunkDetailsFactory, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceMCPServerSplunkDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, T2, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, T2, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSplunkDetailsFactory, T3, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceMCPServerSplunkDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkDetailsFactory, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, T2, T3, T4, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceMCPServerSplunkDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, T2, T3, T4, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceMCPServerSplunkDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSplunkDetailsFactory, T3, T4, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceMCPServerSplunkDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkDetailsFactory, T4, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerSplunkDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerSplunkDetailsFactory, InnerServiceMCPServerSplunkAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerSplunkDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
