// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigMetricsConfigFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.MetricsConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.MetricsConfig>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.MetricsConfig Create()
    {
        var metricsConfigResult = CreateMetricsConfig();
        factoryAction?.Invoke(metricsConfigResult);

        return metricsConfigResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.MetricsConfig CreateMetricsConfig()
    {
        var metricsConfigResult = new Humidifier.SageMaker.EndpointConfigTypes.MetricsConfig();

        return metricsConfigResult;
    }

} // End Of Class

public static class InnerEndpointConfigMetricsConfigFactoryExtensions
{
}
