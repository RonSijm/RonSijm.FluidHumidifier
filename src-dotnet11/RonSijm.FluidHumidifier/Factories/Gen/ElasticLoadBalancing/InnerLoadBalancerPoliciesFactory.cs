// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerPoliciesFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies Create()
    {
        var policiesResult = CreatePolicies();
        factoryAction?.Invoke(policiesResult);

        return policiesResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies CreatePolicies()
    {
        var policiesResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.Policies();

        return policiesResult;
    }

} // End Of Class

public static class InnerLoadBalancerPoliciesFactoryExtensions
{
}
