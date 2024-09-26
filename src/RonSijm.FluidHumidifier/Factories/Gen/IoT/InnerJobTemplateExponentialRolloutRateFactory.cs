// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateExponentialRolloutRateFactory(Action<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate>
{

    internal InnerJobTemplateRateIncreaseCriteriaFactory RateIncreaseCriteriaFactory { get; set; }

    protected override Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate Create()
    {
        var exponentialRolloutRateResult = CreateExponentialRolloutRate();
        factoryAction?.Invoke(exponentialRolloutRateResult);

        return exponentialRolloutRateResult;
    }

    private Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate CreateExponentialRolloutRate()
    {
        var exponentialRolloutRateResult = new Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate();

        return exponentialRolloutRateResult;
    }
    public override void CreateChildren(Humidifier.IoT.JobTemplateTypes.ExponentialRolloutRate result)
    {
        base.CreateChildren(result);

        result.RateIncreaseCriteria ??= RateIncreaseCriteriaFactory?.Build();
    }

} // End Of Class

public static class InnerJobTemplateExponentialRolloutRateFactoryExtensions
{
    public static CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria(this InnerJobTemplateExponentialRolloutRateFactory parentFactory, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null)
    {
        parentFactory.RateIncreaseCriteriaFactory = new InnerJobTemplateRateIncreaseCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RateIncreaseCriteriaFactory);
    }

    public static CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1>(this CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, T2, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, T2> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, T2, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, T2> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobTemplateExponentialRolloutRateFactory, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, T2, T3, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, T2, T3, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, T2, T3> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobTemplateExponentialRolloutRateFactory, T3, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateExponentialRolloutRateFactory, T3> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobTemplateExponentialRolloutRateFactory, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, T2, T3, T4, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateExponentialRolloutRateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, T2, T3, T4, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateExponentialRolloutRateFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobTemplateExponentialRolloutRateFactory, T3, T4, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateExponentialRolloutRateFactory, T3, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobTemplateExponentialRolloutRateFactory, T4, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateExponentialRolloutRateFactory, T4> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateExponentialRolloutRateFactory, InnerJobTemplateRateIncreaseCriteriaFactory> WithRateIncreaseCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateExponentialRolloutRateFactory> combinedResult, Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRateIncreaseCriteria(combinedResult.T5, subFactoryAction));
}
