// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory(Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig>
{

    internal InnerOTAUpdateAwsJobExponentialRolloutRateFactory ExponentialRateFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig Create()
    {
        var awsJobExecutionsRolloutConfigResult = CreateAwsJobExecutionsRolloutConfig();
        factoryAction?.Invoke(awsJobExecutionsRolloutConfigResult);

        return awsJobExecutionsRolloutConfigResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig CreateAwsJobExecutionsRolloutConfig()
    {
        var awsJobExecutionsRolloutConfigResult = new Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig();

        return awsJobExecutionsRolloutConfigResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.AwsJobExecutionsRolloutConfig result)
    {
        base.CreateChildren(result);

        result.ExponentialRate ??= ExponentialRateFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateAwsJobExecutionsRolloutConfigFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate(this InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null)
    {
        parentFactory.ExponentialRateFactory = new InnerOTAUpdateAwsJobExponentialRolloutRateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExponentialRateFactory);
    }

    public static CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1>(this CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1>(this CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, T2, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T2, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, T2, T3, T4, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T2, T3, T4, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T3, T4, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T4, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> WithExponentialRate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateAwsJobExecutionsRolloutConfigFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExponentialRate(combinedResult.T5, subFactoryAction).T2);
}
