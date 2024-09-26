// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceDiscovery;

public class InnerServiceHealthCheckCustomConfigFactory(Action<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig> factoryAction = null) : SubResourceFactory<Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig>
{

    protected override Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig Create()
    {
        var healthCheckCustomConfigResult = CreateHealthCheckCustomConfig();
        factoryAction?.Invoke(healthCheckCustomConfigResult);

        return healthCheckCustomConfigResult;
    }

    private Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig CreateHealthCheckCustomConfig()
    {
        var healthCheckCustomConfigResult = new Humidifier.ServiceDiscovery.ServiceTypes.HealthCheckCustomConfig();

        return healthCheckCustomConfigResult;
    }

} // End Of Class

public static class InnerServiceHealthCheckCustomConfigFactoryExtensions
{
}
