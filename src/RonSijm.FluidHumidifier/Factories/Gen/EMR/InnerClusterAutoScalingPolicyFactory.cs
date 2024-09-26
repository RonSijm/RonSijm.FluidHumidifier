// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterAutoScalingPolicyFactory(Action<Humidifier.EMR.ClusterTypes.AutoScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.AutoScalingPolicy>
{

    internal InnerClusterScalingConstraintsFactory ConstraintsFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.AutoScalingPolicy Create()
    {
        var autoScalingPolicyResult = CreateAutoScalingPolicy();
        factoryAction?.Invoke(autoScalingPolicyResult);

        return autoScalingPolicyResult;
    }

    private Humidifier.EMR.ClusterTypes.AutoScalingPolicy CreateAutoScalingPolicy()
    {
        var autoScalingPolicyResult = new Humidifier.EMR.ClusterTypes.AutoScalingPolicy();

        return autoScalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.AutoScalingPolicy result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterAutoScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerClusterAutoScalingPolicyFactory, InnerClusterScalingConstraintsFactory> WithConstraints(this InnerClusterAutoScalingPolicyFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerClusterScalingConstraintsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, InnerClusterScalingConstraintsFactory> WithConstraints<T1>(this CombinedResult<InnerClusterAutoScalingPolicyFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, InnerClusterScalingConstraintsFactory> WithConstraints<T1>(this CombinedResult<T1, InnerClusterAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, T2, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, T2, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterAutoScalingPolicyFactory, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerClusterAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, T2, T3, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, T2, T3, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterAutoScalingPolicyFactory, T3, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterAutoScalingPolicyFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterAutoScalingPolicyFactory, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, T2, T3, T4, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerClusterAutoScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, T2, T3, T4, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterAutoScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterAutoScalingPolicyFactory, T3, T4, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterAutoScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterAutoScalingPolicyFactory, T4, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterAutoScalingPolicyFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterAutoScalingPolicyFactory, InnerClusterScalingConstraintsFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterAutoScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ScalingConstraints> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
}
