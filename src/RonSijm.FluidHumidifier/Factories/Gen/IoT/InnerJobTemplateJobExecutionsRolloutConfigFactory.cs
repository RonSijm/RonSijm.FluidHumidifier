// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateJobExecutionsRolloutConfigFactory(Action<Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig>
{

    internal InnerJobTemplateExponentialRolloutRateFactory ExponentialRolloutRateFactory { get; set; }

    protected override Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig Create()
    {
        var jobExecutionsRolloutConfigResult = CreateJobExecutionsRolloutConfig();
        factoryAction?.Invoke(jobExecutionsRolloutConfigResult);

        return jobExecutionsRolloutConfigResult;
    }

    private Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig CreateJobExecutionsRolloutConfig()
    {
        var jobExecutionsRolloutConfigResult = new Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig();

        return jobExecutionsRolloutConfigResult;
    }
    public override void CreateChildren(Humidifier.IoT.JobTemplateTypes.JobExecutionsRolloutConfig result)
    {
        base.CreateChildren(result);

        result.ExponentialRolloutRate ??= ExponentialRolloutRateFactory?.Build();
    }

} // End Of Class

public static class InnerJobTemplateJobExecutionsRolloutConfigFactoryExtensions
{
    public static CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate(this InnerJobTemplateJobExecutionsRolloutConfigFactory parentFactory, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null)
    {
        parentFactory.ExponentialRolloutRateFactory = new InnerJobTemplateExponentialRolloutRateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExponentialRolloutRateFactory);
    }

    public static CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1>(this CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1>(this CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, T2, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2>(this CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, T2> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, T2, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2>(this CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, T2> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobTemplateJobExecutionsRolloutConfigFactory, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, T2, T3, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3>(this CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, T2, T3, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, T2, T3> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobTemplateJobExecutionsRolloutConfigFactory, T3, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateJobExecutionsRolloutConfigFactory, T3> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobExecutionsRolloutConfigFactory, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, T2, T3, T4, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateJobExecutionsRolloutConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, T2, T3, T4, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateJobExecutionsRolloutConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobTemplateJobExecutionsRolloutConfigFactory, T3, T4, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateJobExecutionsRolloutConfigFactory, T3, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobExecutionsRolloutConfigFactory, T4, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobExecutionsRolloutConfigFactory, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobExecutionsRolloutConfigFactory, InnerJobTemplateExponentialRolloutRateFactory> WithExponentialRolloutRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRolloutRate(combinedResult.T5, subFactoryAction));
}
