// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigAsyncInferenceClientConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig Create()
    {
        var asyncInferenceClientConfigResult = CreateAsyncInferenceClientConfig();
        factoryAction?.Invoke(asyncInferenceClientConfigResult);

        return asyncInferenceClientConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig CreateAsyncInferenceClientConfig()
    {
        var asyncInferenceClientConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceClientConfig();

        return asyncInferenceClientConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigAsyncInferenceClientConfigFactoryExtensions
{
}
