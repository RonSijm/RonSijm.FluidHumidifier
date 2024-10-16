// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceDeploymentCircuitBreakerFactory(Action<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker>
{

    protected override Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker Create()
    {
        var deploymentCircuitBreakerResult = CreateDeploymentCircuitBreaker();
        factoryAction?.Invoke(deploymentCircuitBreakerResult);

        return deploymentCircuitBreakerResult;
    }

    private Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker CreateDeploymentCircuitBreaker()
    {
        var deploymentCircuitBreakerResult = new Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker();

        return deploymentCircuitBreakerResult;
    }

} // End Of Class

public static class InnerServiceDeploymentCircuitBreakerFactoryExtensions
{
}
