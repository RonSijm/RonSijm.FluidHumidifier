// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleHostHeaderConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HostHeaderConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HostHeaderConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HostHeaderConfig Create()
    {
        var hostHeaderConfigResult = CreateHostHeaderConfig();
        factoryAction?.Invoke(hostHeaderConfigResult);

        return hostHeaderConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HostHeaderConfig CreateHostHeaderConfig()
    {
        var hostHeaderConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HostHeaderConfig();

        return hostHeaderConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleHostHeaderConfigFactoryExtensions
{
}
