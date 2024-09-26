// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancing;

public class InnerLoadBalancerAppCookieStickinessPolicyFactory(Action<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy>
{

    protected override Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy Create()
    {
        var appCookieStickinessPolicyResult = CreateAppCookieStickinessPolicy();
        factoryAction?.Invoke(appCookieStickinessPolicyResult);

        return appCookieStickinessPolicyResult;
    }

    private Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy CreateAppCookieStickinessPolicy()
    {
        var appCookieStickinessPolicyResult = new Humidifier.ElasticLoadBalancing.LoadBalancerTypes.AppCookieStickinessPolicy();

        return appCookieStickinessPolicyResult;
    }

} // End Of Class

public static class InnerLoadBalancerAppCookieStickinessPolicyFactoryExtensions
{
}
