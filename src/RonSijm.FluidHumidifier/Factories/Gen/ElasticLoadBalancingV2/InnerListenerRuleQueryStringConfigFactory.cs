// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleQueryStringConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringConfig Create()
    {
        var queryStringConfigResult = CreateQueryStringConfig();
        factoryAction?.Invoke(queryStringConfigResult);

        return queryStringConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringConfig CreateQueryStringConfig()
    {
        var queryStringConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringConfig();

        return queryStringConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleQueryStringConfigFactoryExtensions
{
}
