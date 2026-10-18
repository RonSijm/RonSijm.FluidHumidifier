// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerAccessLoggingPolicyFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AccessLoggingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AccessLoggingPolicy>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AccessLoggingPolicy Create()
    {
        var accessLoggingPolicyResult = CreateAccessLoggingPolicy();
        factoryAction?.Invoke(accessLoggingPolicyResult);

        return accessLoggingPolicyResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AccessLoggingPolicy CreateAccessLoggingPolicy()
    {
        var accessLoggingPolicyResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AccessLoggingPolicy();

        return accessLoggingPolicyResult;
    }

} // End Of Class

public static class InnerLoadBalancerAccessLoggingPolicyFactoryExtensions
{
}
