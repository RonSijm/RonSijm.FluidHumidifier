// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class UsagePlanFactory(string resourceName = null, Action<Humidifier.ApiGateway.UsagePlan> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.UsagePlan>(resourceName)
{

    internal List<InnerUsagePlanApiStageFactory> ApiStagesFactories { get; set; } = [];

    internal InnerUsagePlanQuotaSettingsFactory QuotaFactory { get; set; }

    internal InnerUsagePlanThrottleSettingsFactory ThrottleFactory { get; set; }

    protected override Humidifier.ApiGateway.UsagePlan Create()
    {
        var usagePlanResult = CreateUsagePlan();
        factoryAction?.Invoke(usagePlanResult);

        return usagePlanResult;
    }

    private Humidifier.ApiGateway.UsagePlan CreateUsagePlan()
    {
        var usagePlanResult = new Humidifier.ApiGateway.UsagePlan
        {
            GivenName = InputResourceName,
        };

        return usagePlanResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.UsagePlan result)
    {
        base.CreateChildren(result);

        result.ApiStages = ApiStagesFactories.Any() ? ApiStagesFactories.Select(x => x.Build()).ToList() : null;
        result.Quota ??= QuotaFactory?.Build();
        result.Throttle ??= ThrottleFactory?.Build();
    }

} // End Of Class

public static class UsagePlanFactoryExtensions
{
    public static CombinedResult<UsagePlanFactory, InnerUsagePlanApiStageFactory> WithApiStages(this UsagePlanFactory parentFactory, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null)
    {
        var factory = new InnerUsagePlanApiStageFactory(subFactoryAction);
        parentFactory.ApiStagesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UsagePlanFactory, InnerUsagePlanQuotaSettingsFactory> WithQuota(this UsagePlanFactory parentFactory, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null)
    {
        parentFactory.QuotaFactory = new InnerUsagePlanQuotaSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QuotaFactory);
    }

    public static CombinedResult<UsagePlanFactory, InnerUsagePlanThrottleSettingsFactory> WithThrottle(this UsagePlanFactory parentFactory, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null)
    {
        parentFactory.ThrottleFactory = new InnerUsagePlanThrottleSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ThrottleFactory);
    }

    public static CombinedResult<UsagePlanFactory, T1, InnerUsagePlanApiStageFactory> WithApiStages<T1>(this CombinedResult<UsagePlanFactory, T1> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, InnerUsagePlanApiStageFactory> WithApiStages<T1>(this CombinedResult<T1, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2>(this CombinedResult<UsagePlanFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2>(this CombinedResult<T1, UsagePlanFactory, T2> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2>(this CombinedResult<T1, T2, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, T3, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3>(this CombinedResult<UsagePlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, T3, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3>(this CombinedResult<T1, UsagePlanFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, T3, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3>(this CombinedResult<T1, T2, UsagePlanFactory, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsagePlanFactory, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3>(this CombinedResult<T1, T2, T3, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, T3, T4, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3, T4>(this CombinedResult<UsagePlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, T3, T4, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3, T4>(this CombinedResult<T1, UsagePlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, T3, T4, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, UsagePlanFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsagePlanFactory, T4, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UsagePlanFactory, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UsagePlanFactory, InnerUsagePlanApiStageFactory> WithApiStages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ApiStage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiStages(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1>(this CombinedResult<UsagePlanFactory, T1> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuota(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1>(this CombinedResult<T1, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuota(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2>(this CombinedResult<UsagePlanFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2>(this CombinedResult<T1, UsagePlanFactory, T2> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2>(this CombinedResult<T1, T2, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, T3, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3>(this CombinedResult<UsagePlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, T3, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3>(this CombinedResult<T1, UsagePlanFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, T3, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3>(this CombinedResult<T1, T2, UsagePlanFactory, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsagePlanFactory, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3>(this CombinedResult<T1, T2, T3, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, T3, T4, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3, T4>(this CombinedResult<UsagePlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, T3, T4, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3, T4>(this CombinedResult<T1, UsagePlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, T3, T4, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3, T4>(this CombinedResult<T1, T2, UsagePlanFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsagePlanFactory, T4, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UsagePlanFactory, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UsagePlanFactory, InnerUsagePlanQuotaSettingsFactory> WithQuota<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.QuotaSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuota(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1>(this CombinedResult<UsagePlanFactory, T1> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithThrottle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1>(this CombinedResult<T1, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithThrottle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2>(this CombinedResult<UsagePlanFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2>(this CombinedResult<T1, UsagePlanFactory, T2> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2>(this CombinedResult<T1, T2, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, T3, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3>(this CombinedResult<UsagePlanFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, T3, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3>(this CombinedResult<T1, UsagePlanFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, T3, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3>(this CombinedResult<T1, T2, UsagePlanFactory, T3> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsagePlanFactory, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3>(this CombinedResult<T1, T2, T3, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UsagePlanFactory, T1, T2, T3, T4, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3, T4>(this CombinedResult<UsagePlanFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UsagePlanFactory, T2, T3, T4, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3, T4>(this CombinedResult<T1, UsagePlanFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UsagePlanFactory, T3, T4, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3, T4>(this CombinedResult<T1, T2, UsagePlanFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UsagePlanFactory, T4, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UsagePlanFactory, T4> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UsagePlanFactory, InnerUsagePlanThrottleSettingsFactory> WithThrottle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UsagePlanFactory> combinedResult, Action<Humidifier.ApiGateway.UsagePlanTypes.ThrottleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThrottle(combinedResult.T5, subFactoryAction));
}
