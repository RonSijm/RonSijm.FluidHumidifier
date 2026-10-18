// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleHttpRequestMethodConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpRequestMethodConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpRequestMethodConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpRequestMethodConfig Create()
    {
        var httpRequestMethodConfigResult = CreateHttpRequestMethodConfig();
        factoryAction?.Invoke(httpRequestMethodConfigResult);

        return httpRequestMethodConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpRequestMethodConfig CreateHttpRequestMethodConfig()
    {
        var httpRequestMethodConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpRequestMethodConfig();

        return httpRequestMethodConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleHttpRequestMethodConfigFactoryExtensions
{
}
