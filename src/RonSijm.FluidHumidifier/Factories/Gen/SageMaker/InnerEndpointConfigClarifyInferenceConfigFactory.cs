// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigClarifyInferenceConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig Create()
    {
        var clarifyInferenceConfigResult = CreateClarifyInferenceConfig();
        factoryAction?.Invoke(clarifyInferenceConfigResult);

        return clarifyInferenceConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig CreateClarifyInferenceConfig()
    {
        var clarifyInferenceConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.ClarifyInferenceConfig();

        return clarifyInferenceConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigClarifyInferenceConfigFactoryExtensions
{
}
