// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentRuntimeConfigFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig Create()
    {
        var inferenceComponentRuntimeConfigResult = CreateInferenceComponentRuntimeConfig();
        factoryAction?.Invoke(inferenceComponentRuntimeConfigResult);

        return inferenceComponentRuntimeConfigResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig CreateInferenceComponentRuntimeConfig()
    {
        var inferenceComponentRuntimeConfigResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig();

        return inferenceComponentRuntimeConfigResult;
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentRuntimeConfigFactoryExtensions
{
}
