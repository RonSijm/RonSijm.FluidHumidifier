// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigRoutingConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig Create()
    {
        var routingConfigResult = CreateRoutingConfig();
        factoryAction?.Invoke(routingConfigResult);

        return routingConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig CreateRoutingConfig()
    {
        var routingConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.RoutingConfig();

        return routingConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigRoutingConfigFactoryExtensions
{
}
