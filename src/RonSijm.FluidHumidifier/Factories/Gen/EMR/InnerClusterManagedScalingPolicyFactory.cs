// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterManagedScalingPolicyFactory(Action<Humidifier.EMR.ClusterTypes.ManagedScalingPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.ManagedScalingPolicy>
{

    internal InnerClusterComputeLimitsFactory ComputeLimitsFactory { get; set; }

    protected override Humidifier.EMR.ClusterTypes.ManagedScalingPolicy Create()
    {
        var managedScalingPolicyResult = CreateManagedScalingPolicy();
        factoryAction?.Invoke(managedScalingPolicyResult);

        return managedScalingPolicyResult;
    }

    private Humidifier.EMR.ClusterTypes.ManagedScalingPolicy CreateManagedScalingPolicy()
    {
        var managedScalingPolicyResult = new Humidifier.EMR.ClusterTypes.ManagedScalingPolicy();

        return managedScalingPolicyResult;
    }
    public override void CreateChildren(Humidifier.EMR.ClusterTypes.ManagedScalingPolicy result)
    {
        base.CreateChildren(result);

        result.ComputeLimits ??= ComputeLimitsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterManagedScalingPolicyFactoryExtensions
{
    public static CombinedResult<InnerClusterManagedScalingPolicyFactory, InnerClusterComputeLimitsFactory> WithComputeLimits(this InnerClusterManagedScalingPolicyFactory parentFactory, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null)
    {
        parentFactory.ComputeLimitsFactory = new InnerClusterComputeLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeLimitsFactory);
    }

    public static CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, InnerClusterComputeLimitsFactory> WithComputeLimits<T1>(this CombinedResult<InnerClusterManagedScalingPolicyFactory, T1> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, InnerClusterComputeLimitsFactory> WithComputeLimits<T1>(this CombinedResult<T1, InnerClusterManagedScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, T2, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2>(this CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, T2, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2>(this CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, T2> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterManagedScalingPolicyFactory, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2>(this CombinedResult<T1, T2, InnerClusterManagedScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, T2, T3, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3>(this CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, T2, T3, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3>(this CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterManagedScalingPolicyFactory, T3, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterManagedScalingPolicyFactory, T3> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterManagedScalingPolicyFactory, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterManagedScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, T2, T3, T4, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3, T4>(this CombinedResult<InnerClusterManagedScalingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, T2, T3, T4, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterManagedScalingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterManagedScalingPolicyFactory, T3, T4, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterManagedScalingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterManagedScalingPolicyFactory, T4, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterManagedScalingPolicyFactory, T4> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterManagedScalingPolicyFactory, InnerClusterComputeLimitsFactory> WithComputeLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterManagedScalingPolicyFactory> combinedResult, Action<Humidifier.EMR.ClusterTypes.ComputeLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeLimits(combinedResult.T5, subFactoryAction));
}
