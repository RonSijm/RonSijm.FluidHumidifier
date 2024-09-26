// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskSetLoadBalancerFactory(Action<Humidifier.ECS.TaskSetTypes.LoadBalancer> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskSetTypes.LoadBalancer>
{

    protected override Humidifier.ECS.TaskSetTypes.LoadBalancer Create()
    {
        var loadBalancerResult = CreateLoadBalancer();
        factoryAction?.Invoke(loadBalancerResult);

        return loadBalancerResult;
    }

    private Humidifier.ECS.TaskSetTypes.LoadBalancer CreateLoadBalancer()
    {
        var loadBalancerResult = new Humidifier.ECS.TaskSetTypes.LoadBalancer();

        return loadBalancerResult;
    }

} // End Of Class

public static class InnerTaskSetLoadBalancerFactoryExtensions
{
}
