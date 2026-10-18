// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerContainerHealthCheckConfigFactory(Action<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig>
{

    protected override Humidifier.Lightsail.ContainerTypes.HealthCheckConfig Create()
    {
        var healthCheckConfigResult = CreateHealthCheckConfig();
        factoryAction?.Invoke(healthCheckConfigResult);

        return healthCheckConfigResult;
    }

    private Humidifier.Lightsail.ContainerTypes.HealthCheckConfig CreateHealthCheckConfig()
    {
        var healthCheckConfigResult = new Humidifier.Lightsail.ContainerTypes.HealthCheckConfig();

        return healthCheckConfigResult;
    }

} // End Of Class

public static class InnerContainerHealthCheckConfigFactoryExtensions
{
}
