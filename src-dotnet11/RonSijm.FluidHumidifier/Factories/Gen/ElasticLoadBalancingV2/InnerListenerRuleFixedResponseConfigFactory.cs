// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleFixedResponseConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.FixedResponseConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.FixedResponseConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.FixedResponseConfig Create()
    {
        var fixedResponseConfigResult = CreateFixedResponseConfig();
        factoryAction?.Invoke(fixedResponseConfigResult);

        return fixedResponseConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.FixedResponseConfig CreateFixedResponseConfig()
    {
        var fixedResponseConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.FixedResponseConfig();

        return fixedResponseConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleFixedResponseConfigFactoryExtensions
{
}
