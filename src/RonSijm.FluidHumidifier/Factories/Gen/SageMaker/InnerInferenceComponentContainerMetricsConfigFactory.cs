// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentContainerMetricsConfigFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig Create()
    {
        var containerMetricsConfigResult = CreateContainerMetricsConfig();
        factoryAction?.Invoke(containerMetricsConfigResult);

        return containerMetricsConfigResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig CreateContainerMetricsConfig()
    {
        var containerMetricsConfigResult = new Humidifier.SageMaker.InferenceComponentTypes.ContainerMetricsConfig();

        return containerMetricsConfigResult;
    }

} // End Of Class

public static class InnerInferenceComponentContainerMetricsConfigFactoryExtensions
{
}
