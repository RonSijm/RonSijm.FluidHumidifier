// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobExponentialRolloutRateFactory(Action<Humidifier.IoT.JobTypes.ExponentialRolloutRate> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.ExponentialRolloutRate>
{

    internal InnerJobRateIncreaseCriteriaFactory RateIncreaseCriteriaFactory { get; set; }

    protected override Humidifier.IoT.JobTypes.ExponentialRolloutRate Create()
    {
        var exponentialRolloutRateResult = CreateExponentialRolloutRate();
        factoryAction?.Invoke(exponentialRolloutRateResult);

        return exponentialRolloutRateResult;
    }

    private Humidifier.IoT.JobTypes.ExponentialRolloutRate CreateExponentialRolloutRate()
    {
        var exponentialRolloutRateResult = new Humidifier.IoT.JobTypes.ExponentialRolloutRate();

        return exponentialRolloutRateResult;
    }
    public override void CreateChildren(Humidifier.IoT.JobTypes.ExponentialRolloutRate result)
    {
        base.CreateChildren(result);

        result.RateIncreaseCriteria ??= RateIncreaseCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerJobExponentialRolloutRateFactoryExtensions
{
    public static CombinedResult<InnerJobExponentialRolloutRateFactory, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria(this InnerJobExponentialRolloutRateFactory parentFactory, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null)
    {
        parentFactory.RateIncreaseCriteriaFactory = new InnerJobRateIncreaseCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RateIncreaseCriteriaFactory);
    }

    public static CombinedResult<InnerJobExponentialRolloutRateFactory, T1, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<InnerJobExponentialRolloutRateFactory, T1> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobExponentialRolloutRateFactory, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<T1, InnerJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobExponentialRolloutRateFactory, T1, T2, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<InnerJobExponentialRolloutRateFactory, T1, T2> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobExponentialRolloutRateFactory, T2, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, InnerJobExponentialRolloutRateFactory, T2> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobExponentialRolloutRateFactory, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, T2, InnerJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobExponentialRolloutRateFactory, T1, T2, T3, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<InnerJobExponentialRolloutRateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobExponentialRolloutRateFactory, T2, T3, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, InnerJobExponentialRolloutRateFactory, T2, T3> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobExponentialRolloutRateFactory, T3, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobExponentialRolloutRateFactory, T3> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobExponentialRolloutRateFactory, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobExponentialRolloutRateFactory, T1, T2, T3, T4, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<InnerJobExponentialRolloutRateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobExponentialRolloutRateFactory, T2, T3, T4, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobExponentialRolloutRateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobExponentialRolloutRateFactory, T3, T4, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobExponentialRolloutRateFactory, T3, T4> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobExponentialRolloutRateFactory, T4, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobExponentialRolloutRateFactory, T4> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobExponentialRolloutRateFactory, InnerJobRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T5, subFactoryAction).T2);
}
