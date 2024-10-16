// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerLayerLoadBasedAutoScalingFactory(Action<Humidifier.OpsWorks.LayerTypes.LoadBasedAutoScaling> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.LayerTypes.LoadBasedAutoScaling>
{

    internal InnerLayerAutoScalingThresholdsFactory DownScalingFactory { get; set; }

    internal InnerLayerAutoScalingThresholdsFactory UpScalingFactory { get; set; }

    protected override Humidifier.OpsWorks.LayerTypes.LoadBasedAutoScaling Create()
    {
        var loadBasedAutoScalingResult = CreateLoadBasedAutoScaling();
        factoryAction?.Invoke(loadBasedAutoScalingResult);

        return loadBasedAutoScalingResult;
    }

    private Humidifier.OpsWorks.LayerTypes.LoadBasedAutoScaling CreateLoadBasedAutoScaling()
    {
        var loadBasedAutoScalingResult = new Humidifier.OpsWorks.LayerTypes.LoadBasedAutoScaling();

        return loadBasedAutoScalingResult;
    }
    public override void CreateChildren(Humidifier.OpsWorks.LayerTypes.LoadBasedAutoScaling result)
    {
        base.CreateChildren(result);

        result.DownScaling ??= DownScalingFactory?.Build();
        result.UpScaling ??= UpScalingFactory?.Build();
    }

} // End Of Class

public static class InnerLayerLoadBasedAutoScalingFactoryExtensions
{
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithDownScaling(this InnerLayerLoadBasedAutoScalingFactory parentFactory, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null)
    {
        parentFactory.DownScalingFactory = new InnerLayerAutoScalingThresholdsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DownScalingFactory);
    }

    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithUpScaling(this InnerLayerLoadBasedAutoScalingFactory parentFactory, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null)
    {
        parentFactory.UpScalingFactory = new InnerLayerAutoScalingThresholdsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UpScalingFactory);
    }

    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, WithDownScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, WithDownScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2>(this CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3, T4, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3, T4>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3, T4, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3, T4, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory, T4, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithDownScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDownScaling(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, WithUpScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, WithUpScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2>(this CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3>(this CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3, T4, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3, T4>(this CombinedResult<InnerLayerLoadBasedAutoScalingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3, T4, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3, T4>(this CombinedResult<T1, InnerLayerLoadBasedAutoScalingFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3, T4, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLayerLoadBasedAutoScalingFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory, T4, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLayerLoadBasedAutoScalingFactory, T4> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLayerLoadBasedAutoScalingFactory, InnerLayerAutoScalingThresholdsFactory> WithUpScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLayerLoadBasedAutoScalingFactory> combinedResult, Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUpScaling(combinedResult.T5, subFactoryAction));
}
