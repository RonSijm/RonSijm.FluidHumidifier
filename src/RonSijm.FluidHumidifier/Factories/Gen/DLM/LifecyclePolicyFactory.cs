// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class LifecyclePolicyFactory(string resourceName = null, Action<Humidifier.DLM.LifecyclePolicy> factoryAction = null) : ResourceFactory<Humidifier.DLM.LifecyclePolicy>(resourceName)
{

    internal InnerLifecyclePolicyExclusionsFactory ExclusionsFactory { get; set; }

    internal InnerLifecyclePolicyCrossRegionCopyTargetsFactory CrossRegionCopyTargetsFactory { get; set; }

    internal InnerLifecyclePolicyPolicyDetailsFactory PolicyDetailsFactory { get; set; }

    protected override Humidifier.DLM.LifecyclePolicy Create()
    {
        var lifecyclePolicyResult = CreateLifecyclePolicy();
        factoryAction?.Invoke(lifecyclePolicyResult);

        return lifecyclePolicyResult;
    }

    private Humidifier.DLM.LifecyclePolicy CreateLifecyclePolicy()
    {
        var lifecyclePolicyResult = new Humidifier.DLM.LifecyclePolicy
        {
            GivenName = InputResourceName,
        };

        return lifecyclePolicyResult;
    }
    public override void CreateChildren(Humidifier.DLM.LifecyclePolicy result)
    {
        base.CreateChildren(result);

        result.Exclusions ??= ExclusionsFactory?.Build();
        result.CrossRegionCopyTargets ??= CrossRegionCopyTargetsFactory?.Build();
        result.PolicyDetails ??= PolicyDetailsFactory?.Build();
    }

} // End Of Class

public static class LifecyclePolicyFactoryExtensions
{
    public static CombinedResult<LifecyclePolicyFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions(this LifecyclePolicyFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null)
    {
        parentFactory.ExclusionsFactory = new InnerLifecyclePolicyExclusionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExclusionsFactory);
    }

    public static CombinedResult<LifecyclePolicyFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets(this LifecyclePolicyFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null)
    {
        parentFactory.CrossRegionCopyTargetsFactory = new InnerLifecyclePolicyCrossRegionCopyTargetsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrossRegionCopyTargetsFactory);
    }

    public static CombinedResult<LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails(this LifecyclePolicyFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null)
    {
        parentFactory.PolicyDetailsFactory = new InnerLifecyclePolicyPolicyDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyDetailsFactory);
    }

    public static CombinedResult<LifecyclePolicyFactory, T1, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1>(this CombinedResult<LifecyclePolicyFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1>(this CombinedResult<T1, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2>(this CombinedResult<LifecyclePolicyFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2>(this CombinedResult<T1, LifecyclePolicyFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2>(this CombinedResult<T1, T2, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1>(this CombinedResult<LifecyclePolicyFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1>(this CombinedResult<T1, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2>(this CombinedResult<LifecyclePolicyFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2>(this CombinedResult<T1, LifecyclePolicyFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2>(this CombinedResult<T1, T2, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1>(this CombinedResult<LifecyclePolicyFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1>(this CombinedResult<T1, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2>(this CombinedResult<LifecyclePolicyFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2>(this CombinedResult<T1, LifecyclePolicyFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2>(this CombinedResult<T1, T2, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<LifecyclePolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, LifecyclePolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, LifecyclePolicyFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LifecyclePolicyFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory, InnerLifecyclePolicyPolicyDetailsFactory> WithPolicyDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LifecyclePolicyFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyDetails(combinedResult.T5, subFactoryAction));
}
