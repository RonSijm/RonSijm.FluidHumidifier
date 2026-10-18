// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceNewRelicServiceDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails>
{

    internal InnerServiceNewRelicAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails Create()
    {
        var newRelicServiceDetailsResult = CreateNewRelicServiceDetails();
        factoryAction?.Invoke(newRelicServiceDetailsResult);

        return newRelicServiceDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails CreateNewRelicServiceDetails()
    {
        var newRelicServiceDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails();

        return newRelicServiceDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceNewRelicServiceDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceNewRelicServiceDetailsFactory, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceNewRelicServiceDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceNewRelicAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, T2, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, T2, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceNewRelicServiceDetailsFactory, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceNewRelicServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, T2, T3, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, T2, T3, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceNewRelicServiceDetailsFactory, T3, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceNewRelicServiceDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceNewRelicServiceDetailsFactory, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceNewRelicServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, T2, T3, T4, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceNewRelicServiceDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, T2, T3, T4, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceNewRelicServiceDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceNewRelicServiceDetailsFactory, T3, T4, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceNewRelicServiceDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceNewRelicServiceDetailsFactory, T4, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceNewRelicServiceDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceNewRelicServiceDetailsFactory, InnerServiceNewRelicAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceNewRelicServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
