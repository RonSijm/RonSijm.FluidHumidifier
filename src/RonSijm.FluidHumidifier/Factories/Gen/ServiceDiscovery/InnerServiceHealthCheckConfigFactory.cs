// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerServiceHealthCheckConfigFactory(Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig>
{

    protected override Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig Create()
    {
        var healthCheckConfigResult = CreateHealthCheckConfig();
        factoryAction?.Invoke(healthCheckConfigResult);

        return healthCheckConfigResult;
    }

    private Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig CreateHealthCheckConfig()
    {
        var healthCheckConfigResult = new Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckConfig();

        return healthCheckConfigResult;
    }

} // End Of Class

public static class InnerServiceHealthCheckConfigFactoryExtensions
{
}
