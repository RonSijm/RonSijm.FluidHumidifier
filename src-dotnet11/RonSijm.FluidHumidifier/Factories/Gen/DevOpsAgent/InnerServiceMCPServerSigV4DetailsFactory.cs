// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceMCPServerSigV4DetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details>
{

    internal InnerServiceMCPServerSigV4AuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details Create()
    {
        var mCPServerSigV4DetailsResult = CreateMCPServerSigV4Details();
        factoryAction?.Invoke(mCPServerSigV4DetailsResult);

        return mCPServerSigV4DetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details CreateMCPServerSigV4Details()
    {
        var mCPServerSigV4DetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details();

        return mCPServerSigV4DetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceMCPServerSigV4DetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceMCPServerSigV4DetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceMCPServerSigV4AuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, T2, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, T2, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSigV4DetailsFactory, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceMCPServerSigV4DetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, T2, T3, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, T2, T3, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSigV4DetailsFactory, T3, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceMCPServerSigV4DetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerSigV4DetailsFactory, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerSigV4DetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, T2, T3, T4, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceMCPServerSigV4DetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, T2, T3, T4, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceMCPServerSigV4DetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceMCPServerSigV4DetailsFactory, T3, T4, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceMCPServerSigV4DetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceMCPServerSigV4DetailsFactory, T4, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceMCPServerSigV4DetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerSigV4DetailsFactory, InnerServiceMCPServerSigV4AuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceMCPServerSigV4DetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
