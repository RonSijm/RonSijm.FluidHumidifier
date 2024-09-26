// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotFleetLoadBalancersConfigFactory(Action<Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig>
{

    internal InnerSpotFleetClassicLoadBalancersConfigFactory ClassicLoadBalancersConfigFactory { get; set; }

    internal InnerSpotFleetTargetGroupsConfigFactory TargetGroupsConfigFactory { get; set; }

    protected override Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig Create()
    {
        var loadBalancersConfigResult = CreateLoadBalancersConfig();
        factoryAction?.Invoke(loadBalancersConfigResult);

        return loadBalancersConfigResult;
    }

    private Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig CreateLoadBalancersConfig()
    {
        var loadBalancersConfigResult = new Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig();

        return loadBalancersConfigResult;
    }
    public override void CreateChildren(Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig result)
    {
        base.CreateChildren(result);

        result.ClassicLoadBalancersConfig ??= ClassicLoadBalancersConfigFactory?.Build();
        result.TargetGroupsConfig ??= TargetGroupsConfigFactory?.Build();
    }

} // End Of Class

public static class InnerSpotFleetLoadBalancersConfigFactoryExtensions
{
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig(this InnerSpotFleetLoadBalancersConfigFactory parentFactory, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null)
    {
        parentFactory.ClassicLoadBalancersConfigFactory = new InnerSpotFleetClassicLoadBalancersConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClassicLoadBalancersConfigFactory);
    }

    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig(this InnerSpotFleetLoadBalancersConfigFactory parentFactory, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null)
    {
        parentFactory.TargetGroupsConfigFactory = new InnerSpotFleetTargetGroupsConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetGroupsConfigFactory);
    }

    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2>(this CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3, T4, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3, T4>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3, T4, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3, T4, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory, T4, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetClassicLoadBalancersConfigFactory> WithClassicLoadBalancersConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClassicLoadBalancersConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2>(this CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3, T4, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3, T4>(this CombinedResult<InnerSpotFleetLoadBalancersConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3, T4, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpotFleetLoadBalancersConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3, T4, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpotFleetLoadBalancersConfigFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory, T4, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpotFleetLoadBalancersConfigFactory, T4> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpotFleetLoadBalancersConfigFactory, InnerSpotFleetTargetGroupsConfigFactory> WithTargetGroupsConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpotFleetLoadBalancersConfigFactory> combinedResult, Action<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetGroupsConfig(combinedResult.T5, subFactoryAction));
}
