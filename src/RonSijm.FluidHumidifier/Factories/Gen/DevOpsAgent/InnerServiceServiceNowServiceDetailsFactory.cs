// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceServiceNowServiceDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails>
{

    internal InnerServiceServiceNowAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails Create()
    {
        var serviceNowServiceDetailsResult = CreateServiceNowServiceDetails();
        factoryAction?.Invoke(serviceNowServiceDetailsResult);

        return serviceNowServiceDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails CreateServiceNowServiceDetails()
    {
        var serviceNowServiceDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails();

        return serviceNowServiceDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceServiceNowServiceDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceServiceNowServiceDetailsFactory, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceServiceNowServiceDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceServiceNowAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, T2, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, T2, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceServiceNowServiceDetailsFactory, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceServiceNowServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, T2, T3, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, T2, T3, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceServiceNowServiceDetailsFactory, T3, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceServiceNowServiceDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceServiceNowServiceDetailsFactory, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceServiceNowServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, T2, T3, T4, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceServiceNowServiceDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, T2, T3, T4, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceServiceNowServiceDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceServiceNowServiceDetailsFactory, T3, T4, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceServiceNowServiceDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceServiceNowServiceDetailsFactory, T4, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceServiceNowServiceDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceServiceNowServiceDetailsFactory, InnerServiceServiceNowAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceServiceNowServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
