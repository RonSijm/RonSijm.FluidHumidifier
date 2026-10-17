// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionHealthCheckFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck>
{

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck Create()
    {
        var healthCheckResult = CreateHealthCheck();
        factoryAction?.Invoke(healthCheckResult);

        return healthCheckResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck CreateHealthCheck()
    {
        var healthCheckResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck();

        return healthCheckResult;
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionHealthCheckFactoryExtensions
{
}
