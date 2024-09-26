// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GlobalAccelerator;

public class InnerEndpointGroupEndpointConfigurationFactory(Action<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration>
{

    protected override Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration Create()
    {
        var endpointConfigurationResult = CreateEndpointConfiguration();
        factoryAction?.Invoke(endpointConfigurationResult);

        return endpointConfigurationResult;
    }

    private Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration CreateEndpointConfiguration()
    {
        var endpointConfigurationResult = new Humidifier.GlobalAccelerator.EndpointGroupTypes.EndpointConfiguration();

        return endpointConfigurationResult;
    }

} // End Of Class

public static class InnerEndpointGroupEndpointConfigurationFactoryExtensions
{
}
