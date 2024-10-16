// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerRuleForwardConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig>
{

    internal InnerListenerRuleTargetGroupStickinessConfigFactory TargetGroupStickinessConfigFactory { get; set; }

    protected override Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig Create()
    {
        var forwardConfigResult = CreateForwardConfig();
        factoryAction?.Invoke(forwardConfigResult);

        return forwardConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig CreateForwardConfig()
    {
        var forwardConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig();

        return forwardConfigResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig result)
    {
        base.CreateChildren(result);

        result.TargetGroupStickinessConfig ??= TargetGroupStickinessConfigFactory?.Build();
    }

} // End Of Class

public static class InnerListenerRuleForwardConfigFactoryExtensions
{
    public static CombinedResult<InnerListenerRuleForwardConfigFactory, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig(this InnerListenerRuleForwardConfigFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null)
    {
        parentFactory.TargetGroupStickinessConfigFactory = new InnerListenerRuleTargetGroupStickinessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetGroupStickinessConfigFactory);
    }

    public static CombinedResult<InnerListenerRuleForwardConfigFactory, T1, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1>(this CombinedResult<InnerListenerRuleForwardConfigFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerRuleForwardConfigFactory, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1>(this CombinedResult<T1, InnerListenerRuleForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerListenerRuleForwardConfigFactory, T1, T2, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2>(this CombinedResult<InnerListenerRuleForwardConfigFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerRuleForwardConfigFactory, T2, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2>(this CombinedResult<T1, InnerListenerRuleForwardConfigFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerRuleForwardConfigFactory, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2>(this CombinedResult<T1, T2, InnerListenerRuleForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerListenerRuleForwardConfigFactory, T1, T2, T3, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<InnerListenerRuleForwardConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerRuleForwardConfigFactory, T2, T3, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<T1, InnerListenerRuleForwardConfigFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerRuleForwardConfigFactory, T3, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerListenerRuleForwardConfigFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerRuleForwardConfigFactory, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerListenerRuleForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerListenerRuleForwardConfigFactory, T1, T2, T3, T4, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<InnerListenerRuleForwardConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerRuleForwardConfigFactory, T2, T3, T4, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerListenerRuleForwardConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerRuleForwardConfigFactory, T3, T4, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerListenerRuleForwardConfigFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerRuleForwardConfigFactory, T4, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerListenerRuleForwardConfigFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerListenerRuleForwardConfigFactory, InnerListenerRuleTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerListenerRuleForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T5, subFactoryAction));
}
