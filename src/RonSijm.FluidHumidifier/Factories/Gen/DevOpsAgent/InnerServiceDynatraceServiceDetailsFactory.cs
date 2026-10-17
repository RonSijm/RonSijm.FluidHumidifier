// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServiceDynatraceServiceDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails>
{

    internal InnerServiceDynatraceAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails Create()
    {
        var dynatraceServiceDetailsResult = CreateDynatraceServiceDetails();
        factoryAction?.Invoke(dynatraceServiceDetailsResult);

        return dynatraceServiceDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails CreateDynatraceServiceDetails()
    {
        var dynatraceServiceDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails();

        return dynatraceServiceDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServiceDynatraceServiceDetailsFactoryExtensions
{
    public static CombinedResult<InnerServiceDynatraceServiceDetailsFactory, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServiceDynatraceServiceDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServiceDynatraceAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, T2, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, T2, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDynatraceServiceDetailsFactory, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServiceDynatraceServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, T2, T3, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, T2, T3, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDynatraceServiceDetailsFactory, T3, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceDynatraceServiceDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceDynatraceServiceDetailsFactory, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceDynatraceServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, T2, T3, T4, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServiceDynatraceServiceDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, T2, T3, T4, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceDynatraceServiceDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServiceDynatraceServiceDetailsFactory, T3, T4, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceDynatraceServiceDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServiceDynatraceServiceDetailsFactory, T4, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceDynatraceServiceDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServiceDynatraceServiceDetailsFactory, InnerServiceDynatraceAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceDynatraceServiceDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
