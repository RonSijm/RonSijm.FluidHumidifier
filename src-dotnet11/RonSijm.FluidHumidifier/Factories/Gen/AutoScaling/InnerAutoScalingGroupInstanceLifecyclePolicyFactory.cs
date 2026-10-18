// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerAutoScalingGroupInstanceLifecyclePolicyFactory(Action<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy>
{

    internal InnerAutoScalingGroupRetentionTriggersFactory RetentionTriggersFactory { get; set; }

    protected override Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy Create()
    {
        var instanceLifecyclePolicyResult = CreateInstanceLifecyclePolicy();
        factoryAction?.Invoke(instanceLifecyclePolicyResult);

        return instanceLifecyclePolicyResult;
    }

    private Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy CreateInstanceLifecyclePolicy()
    {
        var instanceLifecyclePolicyResult = new Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy();

        return instanceLifecyclePolicyResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy result)
    {
        base.CreateChildren(result);

        result.RetentionTriggers ??= RetentionTriggersFactory?.Build();
    }

} // End Of Class

public static class InnerAutoScalingGroupInstanceLifecyclePolicyFactoryExtensions
{
    public static CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers(this InnerAutoScalingGroupInstanceLifecyclePolicyFactory parentFactory, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null)
    {
        parentFactory.RetentionTriggersFactory = new InnerAutoScalingGroupRetentionTriggersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionTriggersFactory);
    }

    public static CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1>(this CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1>(this CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, T2, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2>(this CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T2, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2>(this CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T2> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2>(this CombinedResult<T1, T2, InnerAutoScalingGroupInstanceLifecyclePolicyFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, T2, T3, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3>(this CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T2, T3, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3>(this CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T3, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T3> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoScalingGroupInstanceLifecyclePolicyFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, T2, T3, T4, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3, T4>(this CombinedResult<InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T2, T3, T4, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T3, T4, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T4, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, T4> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoScalingGroupInstanceLifecyclePolicyFactory, InnerAutoScalingGroupRetentionTriggersFactory> WithRetentionTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoScalingGroupInstanceLifecyclePolicyFactory> combinedResult, Action<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionTriggers(combinedResult.T5, subFactoryAction).T2);
}
