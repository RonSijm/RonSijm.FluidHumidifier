// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDomainNameEndpointConfigurationFactory(Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration>
{

    protected override Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration Create()
    {
        var endpointConfigurationResult = CreateEndpointConfiguration();
        factoryAction?.Invoke(endpointConfigurationResult);

        return endpointConfigurationResult;
    }

    private Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration CreateEndpointConfiguration()
    {
        var endpointConfigurationResult = new Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration();

        return endpointConfigurationResult;
    }

} // End Of Class

public static class InnerDomainNameEndpointConfigurationFactoryExtensions
{
}
