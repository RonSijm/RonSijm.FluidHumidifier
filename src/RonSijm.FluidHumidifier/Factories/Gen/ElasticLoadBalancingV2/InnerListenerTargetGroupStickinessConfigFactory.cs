// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerTargetGroupStickinessConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig>
{

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig Create()
    {
        var targetGroupStickinessConfigResult = CreateTargetGroupStickinessConfig();
        factoryAction?.Invoke(targetGroupStickinessConfigResult);

        return targetGroupStickinessConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig CreateTargetGroupStickinessConfig()
    {
        var targetGroupStickinessConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig();

        return targetGroupStickinessConfigResult;
    }

} // End Of Class

public static class InnerListenerTargetGroupStickinessConfigFactoryExtensions
{
}
