// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentDataCacheConfigFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig Create()
    {
        var inferenceComponentDataCacheConfigResult = CreateInferenceComponentDataCacheConfig();
        factoryAction?.Invoke(inferenceComponentDataCacheConfigResult);

        return inferenceComponentDataCacheConfigResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig CreateInferenceComponentDataCacheConfig()
    {
        var inferenceComponentDataCacheConfigResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentDataCacheConfig();

        return inferenceComponentDataCacheConfigResult;
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentDataCacheConfigFactoryExtensions
{
}
