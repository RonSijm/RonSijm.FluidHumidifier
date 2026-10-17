// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryScheduleFactory(Action<Humidifier.Synthetics.CanaryTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.Schedule>
{

    internal InnerCanaryRetryConfigFactory RetryConfigFactory { get; set; }

    protected override Humidifier.Synthetics.CanaryTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.Synthetics.CanaryTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.Synthetics.CanaryTypes.Schedule();

        return scheduleResult;
    }
    public override void CreateChildren(Humidifier.Synthetics.CanaryTypes.Schedule result)
    {
        base.CreateChildren(result);

        result.RetryConfig ??= RetryConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCanaryScheduleFactoryExtensions
{
    public static CombinedResult<InnerCanaryScheduleFactory, InnerCanaryRetryConfigFactory> WithRetryConfig(this InnerCanaryScheduleFactory parentFactory, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null)
    {
        parentFactory.RetryConfigFactory = new InnerCanaryRetryConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetryConfigFactory);
    }

    public static CombinedResult<InnerCanaryScheduleFactory, T1, InnerCanaryRetryConfigFactory> WithRetryConfig<T1>(this CombinedResult<InnerCanaryScheduleFactory, T1> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryScheduleFactory, InnerCanaryRetryConfigFactory> WithRetryConfig<T1>(this CombinedResult<T1, InnerCanaryScheduleFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryScheduleFactory, T1, T2, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2>(this CombinedResult<InnerCanaryScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryScheduleFactory, T2, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2>(this CombinedResult<T1, InnerCanaryScheduleFactory, T2> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryScheduleFactory, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2>(this CombinedResult<T1, T2, InnerCanaryScheduleFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryScheduleFactory, T1, T2, T3, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3>(this CombinedResult<InnerCanaryScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryScheduleFactory, T2, T3, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3>(this CombinedResult<T1, InnerCanaryScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryScheduleFactory, T3, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCanaryScheduleFactory, T3> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCanaryScheduleFactory, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCanaryScheduleFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCanaryScheduleFactory, T1, T2, T3, T4, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3, T4>(this CombinedResult<InnerCanaryScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCanaryScheduleFactory, T2, T3, T4, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCanaryScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCanaryScheduleFactory, T3, T4, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCanaryScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCanaryScheduleFactory, T4, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCanaryScheduleFactory, T4> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCanaryScheduleFactory, InnerCanaryRetryConfigFactory> WithRetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCanaryScheduleFactory> combinedResult, Action<Humidifier.Synthetics.CanaryTypes.RetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryConfig(combinedResult.T5, subFactoryAction).T2);
}
