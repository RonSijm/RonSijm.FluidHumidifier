// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigServerlessConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig Create()
    {
        var serverlessConfigResult = CreateServerlessConfig();
        factoryAction?.Invoke(serverlessConfigResult);

        return serverlessConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig CreateServerlessConfig()
    {
        var serverlessConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.ServerlessConfig();

        return serverlessConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigServerlessConfigFactoryExtensions
{
}
