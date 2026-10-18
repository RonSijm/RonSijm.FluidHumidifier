// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceHealthCheckConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.HealthCheckConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.HealthCheckConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.HealthCheckConfiguration Create()
    {
        var healthCheckConfigurationResult = CreateHealthCheckConfiguration();
        factoryAction?.Invoke(healthCheckConfigurationResult);

        return healthCheckConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.HealthCheckConfiguration CreateHealthCheckConfiguration()
    {
        var healthCheckConfigurationResult = new Humidifier.AppRunner.ServiceTypes.HealthCheckConfiguration();

        return healthCheckConfigurationResult;
    }

} // End Of Class

public static class InnerServiceHealthCheckConfigurationFactoryExtensions
{
}
