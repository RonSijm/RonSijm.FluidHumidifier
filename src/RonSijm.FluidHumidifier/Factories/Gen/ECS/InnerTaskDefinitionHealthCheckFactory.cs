// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionHealthCheckFactory(Action<Humidifier.ECS.TaskDefinitionTypes.HealthCheck> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.HealthCheck>
{

    protected override Humidifier.ECS.TaskDefinitionTypes.HealthCheck Create()
    {
        var healthCheckResult = CreateHealthCheck();
        factoryAction?.Invoke(healthCheckResult);

        return healthCheckResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.HealthCheck CreateHealthCheck()
    {
        var healthCheckResult = new Humidifier.ECS.TaskDefinitionTypes.HealthCheck();

        return healthCheckResult;
    }

} // End Of Class

public static class InnerTaskDefinitionHealthCheckFactoryExtensions
{
}
