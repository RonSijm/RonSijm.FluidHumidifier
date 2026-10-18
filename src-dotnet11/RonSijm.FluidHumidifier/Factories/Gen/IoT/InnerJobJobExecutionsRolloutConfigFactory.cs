// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobJobExecutionsRolloutConfigFactory(Action<Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig>
{

    internal InnerJobExponentialRolloutRateFactory ExponentialRateFactory { get; set; }

    protected override Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig Create()
    {
        var jobExecutionsRolloutConfigResult = CreateJobExecutionsRolloutConfig();
        factoryAction?.Invoke(jobExecutionsRolloutConfigResult);

        return jobExecutionsRolloutConfigResult;
    }

    private Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig CreateJobExecutionsRolloutConfig()
    {
        var jobExecutionsRolloutConfigResult = new Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig();

        return jobExecutionsRolloutConfigResult;
    }
    public override void CreateChildren(Humidifier.IoT.JobTypes.JobExecutionsRolloutConfig result)
    {
        base.CreateChildren(result);

        result.ExponentialRate ??= ExponentialRateFactory?.Build();
    }

} // End Of Class

public static class InnerJobJobExecutionsRolloutConfigFactoryExtensions
{
    public static CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, InnerJobExponentialRolloutRateFactory> WithExponentialRate(this InnerJobJobExecutionsRolloutConfigFactory parentFactory, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null)
    {
        parentFactory.ExponentialRateFactory = new InnerJobExponentialRolloutRateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExponentialRateFactory);
    }

    public static CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1>(this CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1>(this CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, T2, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, T2> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, T2, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, T2> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobExecutionsRolloutConfigFactory, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<T1, T2, InnerJobJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, T2, T3, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, T2, T3, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, T2, T3> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobExecutionsRolloutConfigFactory, T3, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobJobExecutionsRolloutConfigFactory, T3> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobExecutionsRolloutConfigFactory, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, T2, T3, T4, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<InnerJobJobExecutionsRolloutConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, T2, T3, T4, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobJobExecutionsRolloutConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobExecutionsRolloutConfigFactory, T3, T4, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobJobExecutionsRolloutConfigFactory, T3, T4> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobExecutionsRolloutConfigFactory, T4, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobJobExecutionsRolloutConfigFactory, T4> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobJobExecutionsRolloutConfigFactory, InnerJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T5, subFactoryAction).T2);
}
