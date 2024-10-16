// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigAsyncInferenceNotificationConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig Create()
    {
        var asyncInferenceNotificationConfigResult = CreateAsyncInferenceNotificationConfig();
        factoryAction?.Invoke(asyncInferenceNotificationConfigResult);

        return asyncInferenceNotificationConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig CreateAsyncInferenceNotificationConfig()
    {
        var asyncInferenceNotificationConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.AsyncInferenceNotificationConfig();

        return asyncInferenceNotificationConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigAsyncInferenceNotificationConfigFactoryExtensions
{
}
