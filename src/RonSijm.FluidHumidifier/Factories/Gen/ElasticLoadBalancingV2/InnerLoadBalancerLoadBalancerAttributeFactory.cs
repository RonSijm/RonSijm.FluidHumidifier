// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerLoadBalancerLoadBalancerAttributeFactory(Action<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute>
{

    protected override Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute Create()
    {
        var loadBalancerAttributeResult = CreateLoadBalancerAttribute();
        factoryAction?.Invoke(loadBalancerAttributeResult);

        return loadBalancerAttributeResult;
    }

    private Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute CreateLoadBalancerAttribute()
    {
        var loadBalancerAttributeResult = new Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute();

        return loadBalancerAttributeResult;
    }

} // End Of Class

public static class InnerLoadBalancerLoadBalancerAttributeFactoryExtensions
{
}
