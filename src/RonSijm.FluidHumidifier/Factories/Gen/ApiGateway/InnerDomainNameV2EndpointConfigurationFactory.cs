// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDomainNameV2EndpointConfigurationFactory(Action<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration>
{

    protected override Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration Create()
    {
        var endpointConfigurationResult = CreateEndpointConfiguration();
        factoryAction?.Invoke(endpointConfigurationResult);

        return endpointConfigurationResult;
    }

    private Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration CreateEndpointConfiguration()
    {
        var endpointConfigurationResult = new Humidifier.ApiGateway.DomainNameV2Types.EndpointConfiguration();

        return endpointConfigurationResult;
    }

} // End Of Class

public static class InnerDomainNameV2EndpointConfigurationFactoryExtensions
{
}
