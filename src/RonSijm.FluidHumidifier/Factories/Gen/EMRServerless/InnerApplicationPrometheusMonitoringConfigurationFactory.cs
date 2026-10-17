// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationPrometheusMonitoringConfigurationFactory(Action<Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration Create()
    {
        var prometheusMonitoringConfigurationResult = CreatePrometheusMonitoringConfiguration();
        factoryAction?.Invoke(prometheusMonitoringConfigurationResult);

        return prometheusMonitoringConfigurationResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration CreatePrometheusMonitoringConfiguration()
    {
        var prometheusMonitoringConfigurationResult = new Humidifier.EMRServerless.ApplicationTypes.PrometheusMonitoringConfiguration();

        return prometheusMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerApplicationPrometheusMonitoringConfigurationFactoryExtensions
{
}
