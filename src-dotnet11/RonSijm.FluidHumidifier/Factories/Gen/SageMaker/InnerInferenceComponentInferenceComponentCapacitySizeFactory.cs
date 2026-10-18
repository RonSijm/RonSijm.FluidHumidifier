// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentCapacitySizeFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize Create()
    {
        var inferenceComponentCapacitySizeResult = CreateInferenceComponentCapacitySize();
        factoryAction?.Invoke(inferenceComponentCapacitySizeResult);

        return inferenceComponentCapacitySizeResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize CreateInferenceComponentCapacitySize()
    {
        var inferenceComponentCapacitySizeResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentCapacitySize();

        return inferenceComponentCapacitySizeResult;
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentCapacitySizeFactoryExtensions
{
}
