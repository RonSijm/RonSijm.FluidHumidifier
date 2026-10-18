// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleHttpHeaderConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpHeaderConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpHeaderConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpHeaderConfig Create()
    {
        var httpHeaderConfigResult = CreateHttpHeaderConfig();
        factoryAction?.Invoke(httpHeaderConfigResult);

        return httpHeaderConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpHeaderConfig CreateHttpHeaderConfig()
    {
        var httpHeaderConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpHeaderConfig();

        return httpHeaderConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleHttpHeaderConfigFactoryExtensions
{
}
