// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigClarifyTextConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig Create()
    {
        var clarifyTextConfigResult = CreateClarifyTextConfig();
        factoryAction?.Invoke(clarifyTextConfigResult);

        return clarifyTextConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig CreateClarifyTextConfig()
    {
        var clarifyTextConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.ClarifyTextConfig();

        return clarifyTextConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigClarifyTextConfigFactoryExtensions
{
}
