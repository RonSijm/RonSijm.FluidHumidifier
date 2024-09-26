// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerListenerForwardConfigFactory(Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig>
{

    internal InnerListenerTargetGroupStickinessConfigFactory TargetGroupStickinessConfigFactory { get; set; }

    protected override Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig Create()
    {
        var forwardConfigResult = CreateForwardConfig();
        factoryAction?.Invoke(forwardConfigResult);

        return forwardConfigResult;
    }

    private Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig CreateForwardConfig()
    {
        var forwardConfigResult = new Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig();

        return forwardConfigResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig result)
    {
        base.CreateChildren(result);

        result.TargetGroupStickinessConfig ??= TargetGroupStickinessConfigFactory?.Build();
    }

} // End Of Class

public static class InnerListenerForwardConfigFactoryExtensions
{
    public static CombinedResult<InnerListenerForwardConfigFactory, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig(this InnerListenerForwardConfigFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null)
    {
        parentFactory.TargetGroupStickinessConfigFactory = new InnerListenerTargetGroupStickinessConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetGroupStickinessConfigFactory);
    }

    public static CombinedResult<InnerListenerForwardConfigFactory, T1, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1>(this CombinedResult<InnerListenerForwardConfigFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerForwardConfigFactory, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1>(this CombinedResult<T1, InnerListenerForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerListenerForwardConfigFactory, T1, T2, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2>(this CombinedResult<InnerListenerForwardConfigFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerForwardConfigFactory, T2, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2>(this CombinedResult<T1, InnerListenerForwardConfigFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerForwardConfigFactory, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2>(this CombinedResult<T1, T2, InnerListenerForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerListenerForwardConfigFactory, T1, T2, T3, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<InnerListenerForwardConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerForwardConfigFactory, T2, T3, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<T1, InnerListenerForwardConfigFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerForwardConfigFactory, T3, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerListenerForwardConfigFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerForwardConfigFactory, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerListenerForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerListenerForwardConfigFactory, T1, T2, T3, T4, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<InnerListenerForwardConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerListenerForwardConfigFactory, T2, T3, T4, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerListenerForwardConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerListenerForwardConfigFactory, T3, T4, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerListenerForwardConfigFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerListenerForwardConfigFactory, T4, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerListenerForwardConfigFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerListenerForwardConfigFactory, InnerListenerTargetGroupStickinessConfigFactory> WithTargetGroupStickinessConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerListenerForwardConfigFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupStickinessConfig(combinedResult.T5, subFactoryAction));
}
