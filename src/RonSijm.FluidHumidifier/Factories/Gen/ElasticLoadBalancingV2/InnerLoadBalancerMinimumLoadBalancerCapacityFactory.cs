// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerLoadBalancerMinimumLoadBalancerCapacityFactory(Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.MinimumLoadBalancerCapacity> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.MinimumLoadBalancerCapacity>
{

    protected override Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.MinimumLoadBalancerCapacity Create()
    {
        var minimumLoadBalancerCapacityResult = CreateMinimumLoadBalancerCapacity();
        factoryAction?.Invoke(minimumLoadBalancerCapacityResult);

        return minimumLoadBalancerCapacityResult;
    }

    private Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.MinimumLoadBalancerCapacity CreateMinimumLoadBalancerCapacity()
    {
        var minimumLoadBalancerCapacityResult = new Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.MinimumLoadBalancerCapacity();

        return minimumLoadBalancerCapacityResult;
    }

} // End Of Class

public static class InnerLoadBalancerMinimumLoadBalancerCapacityFactoryExtensions
{
}
