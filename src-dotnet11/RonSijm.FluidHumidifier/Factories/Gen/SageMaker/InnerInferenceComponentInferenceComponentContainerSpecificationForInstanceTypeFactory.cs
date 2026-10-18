// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType>
{

    internal InnerInferenceComponentContainerMetricsConfigFactory ContainerMetricsConfigFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType Create()
    {
        var inferenceComponentContainerSpecificationForInstanceTypeResult = CreateInferenceComponentContainerSpecificationForInstanceType();
        factoryAction?.Invoke(inferenceComponentContainerSpecificationForInstanceTypeResult);

        return inferenceComponentContainerSpecificationForInstanceTypeResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType CreateInferenceComponentContainerSpecificationForInstanceType()
    {
        var inferenceComponentContainerSpecificationForInstanceTypeResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType();

        return inferenceComponentContainerSpecificationForInstanceTypeResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecificationForInstanceType result)
    {
        base.CreateChildren(result);

        result.ContainerMetricsConfig ??= ContainerMetricsConfigFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactoryExtensions
{
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig(this InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory parentFactory, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null)
    {
        parentFactory.ContainerMetricsConfigFactory = new InnerInferenceComponentContainerMetricsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerMetricsConfigFactory);
    }

    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, T2, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T2, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, T2, T3, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T2, T3, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T3, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, T2, T3, T4, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3, T4>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T2, T3, T4, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T3, T4, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T4, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory, InnerInferenceComponentContainerMetricsConfigFactory> WithContainerMetricsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceComponentInferenceComponentContainerSpecificationForInstanceTypeFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerMetricsConfig(combinedResult.T5, subFactoryAction).T2);
}
