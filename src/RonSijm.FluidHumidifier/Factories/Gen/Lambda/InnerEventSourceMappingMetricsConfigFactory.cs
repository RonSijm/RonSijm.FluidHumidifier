// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingMetricsConfigFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig Create()
    {
        var metricsConfigResult = CreateMetricsConfig();
        factoryAction?.Invoke(metricsConfigResult);

        return metricsConfigResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig CreateMetricsConfig()
    {
        var metricsConfigResult = new Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig();

        return metricsConfigResult;
    }

} // End Of Class

public static class InnerEventSourceMappingMetricsConfigFactoryExtensions
{
}
