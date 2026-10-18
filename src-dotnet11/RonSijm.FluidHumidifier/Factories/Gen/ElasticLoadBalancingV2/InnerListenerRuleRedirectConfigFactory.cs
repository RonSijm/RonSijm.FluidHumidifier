// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleRedirectConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RedirectConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RedirectConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RedirectConfig Create()
    {
        var redirectConfigResult = CreateRedirectConfig();
        factoryAction?.Invoke(redirectConfigResult);

        return redirectConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RedirectConfig CreateRedirectConfig()
    {
        var redirectConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RedirectConfig();

        return redirectConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleRedirectConfigFactoryExtensions
{
}
