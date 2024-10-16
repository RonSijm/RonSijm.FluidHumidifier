// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentContainerSpecificationFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification>
{

    internal InnerInferenceComponentDeployedImageFactory DeployedImageFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification Create()
    {
        var inferenceComponentContainerSpecificationResult = CreateInferenceComponentContainerSpecification();
        factoryAction?.Invoke(inferenceComponentContainerSpecificationResult);

        return inferenceComponentContainerSpecificationResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification CreateInferenceComponentContainerSpecification()
    {
        var inferenceComponentContainerSpecificationResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification();

        return inferenceComponentContainerSpecificationResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentContainerSpecification result)
    {
        base.CreateChildren(result);

        result.DeployedImage ??= DeployedImageFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentContainerSpecificationFactoryExtensions
{
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, InnerInferenceComponentDeployedImageFactory> WithDeployedImage(this InnerInferenceComponentInferenceComponentContainerSpecificationFactory parentFactory, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null)
    {
        parentFactory.DeployedImageFactory = new InnerInferenceComponentDeployedImageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeployedImageFactory);
    }

    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeployedImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeployedImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, T2, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T2, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, T2, T3, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T2, T3, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T3, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, T2, T3, T4, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3, T4>(this CombinedResult<InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T2, T3, T4, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T3, T4, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T4, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceComponentInferenceComponentContainerSpecificationFactory, InnerInferenceComponentDeployedImageFactory> WithDeployedImage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceComponentInferenceComponentContainerSpecificationFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.DeployedImage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeployedImage(combinedResult.T5, subFactoryAction));
}
