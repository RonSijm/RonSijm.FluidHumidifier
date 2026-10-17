// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerServicePagerDutyDetailsFactory(Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails>
{

    internal InnerServicePagerDutyAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails Create()
    {
        var pagerDutyDetailsResult = CreatePagerDutyDetails();
        factoryAction?.Invoke(pagerDutyDetailsResult);

        return pagerDutyDetailsResult;
    }

    private Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails CreatePagerDutyDetails()
    {
        var pagerDutyDetailsResult = new Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails();

        return pagerDutyDetailsResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerServicePagerDutyDetailsFactoryExtensions
{
    public static CombinedResult<InnerServicePagerDutyDetailsFactory, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig(this InnerServicePagerDutyDetailsFactory parentFactory, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerServicePagerDutyAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerServicePagerDutyDetailsFactory, T1, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerServicePagerDutyDetailsFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyDetailsFactory, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerServicePagerDutyDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerServicePagerDutyDetailsFactory, T1, T2, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerServicePagerDutyDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyDetailsFactory, T2, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerServicePagerDutyDetailsFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServicePagerDutyDetailsFactory, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerServicePagerDutyDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerServicePagerDutyDetailsFactory, T1, T2, T3, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerServicePagerDutyDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyDetailsFactory, T2, T3, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerServicePagerDutyDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServicePagerDutyDetailsFactory, T3, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerServicePagerDutyDetailsFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServicePagerDutyDetailsFactory, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServicePagerDutyDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerServicePagerDutyDetailsFactory, T1, T2, T3, T4, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerServicePagerDutyDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerServicePagerDutyDetailsFactory, T2, T3, T4, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerServicePagerDutyDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerServicePagerDutyDetailsFactory, T3, T4, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServicePagerDutyDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerServicePagerDutyDetailsFactory, T4, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServicePagerDutyDetailsFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerServicePagerDutyDetailsFactory, InnerServicePagerDutyAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServicePagerDutyDetailsFactory> combinedResult, Action<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction).T2);
}
