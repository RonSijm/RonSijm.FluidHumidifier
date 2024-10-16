// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerLBCookieStickinessPolicyFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy Create()
    {
        var lBCookieStickinessPolicyResult = CreateLBCookieStickinessPolicy();
        factoryAction?.Invoke(lBCookieStickinessPolicyResult);

        return lBCookieStickinessPolicyResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy CreateLBCookieStickinessPolicy()
    {
        var lBCookieStickinessPolicyResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.LBCookieStickinessPolicy();

        return lBCookieStickinessPolicyResult;
    }

} // End Of Class

public static class InnerLoadBalancerLBCookieStickinessPolicyFactoryExtensions
{
}
