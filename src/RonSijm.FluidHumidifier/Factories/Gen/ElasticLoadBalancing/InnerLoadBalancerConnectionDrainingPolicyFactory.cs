// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerConnectionDrainingPolicyFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionDrainingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionDrainingPolicy>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionDrainingPolicy Create()
    {
        var connectionDrainingPolicyResult = CreateConnectionDrainingPolicy();
        factoryAction?.Invoke(connectionDrainingPolicyResult);

        return connectionDrainingPolicyResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionDrainingPolicy CreateConnectionDrainingPolicy()
    {
        var connectionDrainingPolicyResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.ConnectionDrainingPolicy();

        return connectionDrainingPolicyResult;
    }

} // End Of Class

public static class InnerLoadBalancerConnectionDrainingPolicyFactoryExtensions
{
}
