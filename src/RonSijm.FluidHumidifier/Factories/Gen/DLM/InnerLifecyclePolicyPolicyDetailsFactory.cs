// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyPolicyDetailsFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails>
{

    internal InnerLifecyclePolicyParametersFactory ParametersFactory { get; set; }

    internal InnerLifecyclePolicyExclusionsFactory ExclusionsFactory { get; set; }

    internal InnerLifecyclePolicyEventSourceFactory EventSourceFactory { get; set; }

    internal InnerLifecyclePolicyCrossRegionCopyTargetsFactory CrossRegionCopyTargetsFactory { get; set; }

    protected override Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails Create()
    {
        var policyDetailsResult = CreatePolicyDetails();
        factoryAction?.Invoke(policyDetailsResult);

        return policyDetailsResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails CreatePolicyDetails()
    {
        var policyDetailsResult = new Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails();

        return policyDetailsResult;
    }
    public override void CreateChildren(Humidifier.DLM.LifecyclePolicyTypes.PolicyDetails result)
    {
        base.CreateChildren(result);

        result.Parameters ??= ParametersFactory?.Build();
        result.Exclusions ??= ExclusionsFactory?.Build();
        result.EventSource ??= EventSourceFactory?.Build();
        result.CrossRegionCopyTargets ??= CrossRegionCopyTargetsFactory?.Build();
    }

} // End Of Class

public static class InnerLifecyclePolicyPolicyDetailsFactoryExtensions
{
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyParametersFactory> WithParameters(this InnerLifecyclePolicyPolicyDetailsFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null)
    {
        parentFactory.ParametersFactory = new InnerLifecyclePolicyParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions(this InnerLifecyclePolicyPolicyDetailsFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null)
    {
        parentFactory.ExclusionsFactory = new InnerLifecyclePolicyExclusionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExclusionsFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyEventSourceFactory> WithEventSource(this InnerLifecyclePolicyPolicyDetailsFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null)
    {
        parentFactory.EventSourceFactory = new InnerLifecyclePolicyEventSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventSourceFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets(this InnerLifecyclePolicyPolicyDetailsFactory parentFactory, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null)
    {
        parentFactory.CrossRegionCopyTargetsFactory = new InnerLifecyclePolicyCrossRegionCopyTargetsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrossRegionCopyTargetsFactory);
    }

    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, InnerLifecyclePolicyParametersFactory> WithParameters<T1>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyParametersFactory> WithParameters<T1>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Parameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyExclusionsFactory> WithExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.Exclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExclusions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyEventSourceFactory> WithEventSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.EventSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<InnerLifecyclePolicyPolicyDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, InnerLifecyclePolicyPolicyDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLifecyclePolicyPolicyDetailsFactory, T3, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLifecyclePolicyPolicyDetailsFactory, T4> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory, InnerLifecyclePolicyCrossRegionCopyTargetsFactory> WithCrossRegionCopyTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLifecyclePolicyPolicyDetailsFactory> combinedResult, Action<Humidifier.DLM.LifecyclePolicyTypes.CrossRegionCopyTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrossRegionCopyTargets(combinedResult.T5, subFactoryAction));
}
