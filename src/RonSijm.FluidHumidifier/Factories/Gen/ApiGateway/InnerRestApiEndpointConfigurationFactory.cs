// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerRestApiEndpointConfigurationFactory(Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration>
{

    protected override Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration Create()
    {
        var endpointConfigurationResult = CreateEndpointConfiguration();
        factoryAction?.Invoke(endpointConfigurationResult);

        return endpointConfigurationResult;
    }

    private Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration CreateEndpointConfiguration()
    {
        var endpointConfigurationResult = new Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration();

        return endpointConfigurationResult;
    }

} // End Of Class

public static class InnerRestApiEndpointConfigurationFactoryExtensions
{
}
