// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentSchedulingConfigFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig>
{

    internal InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory AvailabilityZoneBalanceFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig Create()
    {
        var inferenceComponentSchedulingConfigResult = CreateInferenceComponentSchedulingConfig();
        factoryAction?.Invoke(inferenceComponentSchedulingConfigResult);

        return inferenceComponentSchedulingConfigResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig CreateInferenceComponentSchedulingConfig()
    {
        var inferenceComponentSchedulingConfigResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig();

        return inferenceComponentSchedulingConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSchedulingConfig result)
    {
        base.CreateChildren(result);

        result.AvailabilityZoneBalance ??= AvailabilityZoneBalanceFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentSchedulingConfigFactoryExtensions
{
    public static CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance(this InnerInferenceComponentInferenceComponentSchedulingConfigFactory parentFactory, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null)
    {
        parentFactory.AvailabilityZoneBalanceFactory = new InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AvailabilityZoneBalanceFactory);
    }

    public static CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1>(this CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, T2, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2>(this CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T2, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentSchedulingConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, T2, T3, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3>(this CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T2, T3, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T3, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentSchedulingConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, T2, T3, T4, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3, T4>(this CombinedResult<InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T2, T3, T4, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T3, T4, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T4, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceComponentInferenceComponentSchedulingConfigFactory, InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory> WithAvailabilityZoneBalance<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceComponentInferenceComponentSchedulingConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAvailabilityZoneBalance(combinedResult.T5, subFactoryAction).T2);
}
