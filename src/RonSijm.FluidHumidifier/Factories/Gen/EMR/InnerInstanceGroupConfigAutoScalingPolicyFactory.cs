// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerInstanceGroupConfigAutoScalingPolicyFactory(Action<Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy>
{

    internal InnerInstanceGroupConfigScalingConstraintsFactory ConstraintsFactory { get; set; }

    protected override Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy Create()
    {
        var autoScalingPolicyResult = CreateAutoScalingPolicy();
        factoryAction?.Invoke(autoScalingPolicyResult);

        return autoScalingPolicyResult;
    }

    private Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy CreateAutoScalingPolicy()
    {
        var autoScalingPolicyResult = new Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy();

        return autoScalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceGroupConfigAutoScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints(this InnerInstanceGroupConfigAutoScalingPolicyFactory parentFactory, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerInstanceGroupConfigScalingConstraintsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1>(this CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1>(this CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, T2, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, T2, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, T2> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceGroupConfigAutoScalingPolicyFactory, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerInstanceGroupConfigAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, T2, T3, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, T2, T3, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceGroupConfigAutoScalingPolicyFactory, T3, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceGroupConfigAutoScalingPolicyFactory, T3> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceGroupConfigAutoScalingPolicyFactory, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceGroupConfigAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, T2, T3, T4, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerInstanceGroupConfigAutoScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, T2, T3, T4, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceGroupConfigAutoScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceGroupConfigAutoScalingPolicyFactory, T3, T4, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceGroupConfigAutoScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceGroupConfigAutoScalingPolicyFactory, T4, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceGroupConfigAutoScalingPolicyFactory, T4> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceGroupConfigAutoScalingPolicyFactory, InnerInstanceGroupConfigScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceGroupConfigAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
}
