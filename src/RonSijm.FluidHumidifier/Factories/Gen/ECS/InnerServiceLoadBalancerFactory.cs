// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceLoadBalancerFactory(Action<Humidifier.ECS.ServiceTypes.LoadBalancer> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.LoadBalancer>
{

    protected override Humidifier.ECS.ServiceTypes.LoadBalancer Create()
    {
        var loadBalancerResult = CreateLoadBalancer();
        factoryAction?.Invoke(loadBalancerResult);

        return loadBalancerResult;
    }

    private Humidifier.ECS.ServiceTypes.LoadBalancer CreateLoadBalancer()
    {
        var loadBalancerResult = new Humidifier.ECS.ServiceTypes.LoadBalancer();

        return loadBalancerResult;
    }

} // End Of Class

public static class InnerServiceLoadBalancerFactoryExtensions
{
}
