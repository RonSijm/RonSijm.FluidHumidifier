// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerHealthCheckFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.HealthCheck> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.HealthCheck>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.HealthCheck Create()
    {
        var healthCheckResult = CreateHealthCheck();
        factoryAction?.Invoke(healthCheckResult);

        return healthCheckResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.HealthCheck CreateHealthCheck()
    {
        var healthCheckResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.HealthCheck();

        return healthCheckResult;
    }

} // End Of Class

public static class InnerLoadBalancerHealthCheckFactoryExtensions
{
}
