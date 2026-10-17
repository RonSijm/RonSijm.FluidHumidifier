// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceNewRelicAuthorizationConfigFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig>
{

    internal InnerServiceNewRelicApiKeyConfigFactory ApiKeyFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig Create()
    {
        var newRelicAuthorizationConfigResult = CreateNewRelicAuthorizationConfig();
        factoryAction?.Invoke(newRelicAuthorizationConfigResult);

        return newRelicAuthorizationConfigResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig CreateNewRelicAuthorizationConfig()
    {
        var newRelicAuthorizationConfigResult = new Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig();

        return newRelicAuthorizationConfigResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig result)
    {
        base.CreateChildren(result);

        result.ApiKey ??= ApiKeyFactory?.Build();
    }

} // End Of Class

public static class InnerServiceNewRelicAuthorizationConfigFactoryExtensions
{
    public static CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey(this InnerServiceNewRelicAuthorizationConfigFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null)
    {
        parentFactory.ApiKeyFactory = new InnerServiceNewRelicApiKeyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiKeyFactory);
    }

    public static CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1>(this CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1>(this CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, T2, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2>(this CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, T2, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2>(this CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceNewRelicAuthorizationConfigFactory, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2>(this CombinedResult<T1, T2, InnerServiceNewRelicAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, T2, T3, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3>(this CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, T2, T3, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3>(this CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceNewRelicAuthorizationConfigFactory, T3, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceNewRelicAuthorizationConfigFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceNewRelicAuthorizationConfigFactory, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceNewRelicAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, T2, T3, T4, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3, T4>(this CombinedResult<InnerServiceNewRelicAuthorizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, T2, T3, T4, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceNewRelicAuthorizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceNewRelicAuthorizationConfigFactory, T3, T4, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceNewRelicAuthorizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceNewRelicAuthorizationConfigFactory, T4, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceNewRelicAuthorizationConfigFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceNewRelicAuthorizationConfigFactory, InnerServiceNewRelicApiKeyConfigFactory> WithApiKey<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceNewRelicAuthorizationConfigFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiKey(combinedResult.T5, subFactoryAction).T2);
}
