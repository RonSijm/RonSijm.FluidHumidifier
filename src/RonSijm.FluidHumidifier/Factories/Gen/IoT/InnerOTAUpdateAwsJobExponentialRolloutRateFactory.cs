// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateAwsJobExponentialRolloutRateFactory(Action<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate>
{

    internal InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory RateIncreaseCriteriaFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate Create()
    {
        var awsJobExponentialRolloutRateResult = CreateAwsJobExponentialRolloutRate();
        factoryAction?.Invoke(awsJobExponentialRolloutRateResult);

        return awsJobExponentialRolloutRateResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate CreateAwsJobExponentialRolloutRate()
    {
        var awsJobExponentialRolloutRateResult = new Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate();

        return awsJobExponentialRolloutRateResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.AwsJobExponentialRolloutRate result)
    {
        base.CreateChildren(result);

        result.RateIncreaseCriteria ??= RateIncreaseCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateAwsJobExponentialRolloutRateFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria(this InnerOTAUpdateAwsJobExponentialRolloutRateFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null)
    {
        parentFactory.RateIncreaseCriteriaFactory = new InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RateIncreaseCriteriaFactory);
    }

    public static CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, T2, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T2, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, T2, T3, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T2, T3, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T3, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, T2, T3, T4, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T2, T3, T4, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T3, T4, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T4, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateAwsJobExponentialRolloutRateFactory, InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateAwsJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T5, subFactoryAction).T2);
}
