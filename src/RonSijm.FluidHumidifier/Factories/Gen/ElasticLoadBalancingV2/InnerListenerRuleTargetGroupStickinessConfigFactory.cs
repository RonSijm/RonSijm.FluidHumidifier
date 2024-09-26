// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleTargetGroupStickinessConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig Create()
    {
        var targetGroupStickinessConfigResult = CreateTargetGroupStickinessConfig();
        factoryAction?.Invoke(targetGroupStickinessConfigResult);

        return targetGroupStickinessConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig CreateTargetGroupStickinessConfig()
    {
        var targetGroupStickinessConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig();

        return targetGroupStickinessConfigResult;
    }

} // End Of Class

public static class InnerListenerRuleTargetGroupStickinessConfigFactoryExtensions
{
}
