// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class SchedulingPolicyFactory(string resourceName = null, Action<Humidifier.Batch.SchedulingPolicy> factoryAction = null) : ResourceFactory<Humidifier.Batch.SchedulingPolicy>(resourceName)
{

    internal InnerSchedulingPolicyFairsharePolicyFactory FairsharePolicyFactory { get; set; }

    protected override Humidifier.Batch.SchedulingPolicy Create()
    {
        var schedulingPolicyResult = CreateSchedulingPolicy();
        factoryAction?.Invoke(schedulingPolicyResult);

        return schedulingPolicyResult;
    }

    private Humidifier.Batch.SchedulingPolicy CreateSchedulingPolicy()
    {
        var schedulingPolicyResult = new Humidifier.Batch.SchedulingPolicy
        {
            GivenName = InputResourceName,
        };

        return schedulingPolicyResult;
    }
    public override void CreateChildren(Humidifier.Batch.SchedulingPolicy result)
    {
        base.CreateChildren(result);

        result.FairsharePolicy ??= FairsharePolicyFactory?.Build();
    }

} // End Of Class

public static class SchedulingPolicyFactoryExtensions
{
    public static CombinedResult<SchedulingPolicyFactory, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy(this SchedulingPolicyFactory parentFactory, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null)
    {
        parentFactory.FairsharePolicyFactory = new InnerSchedulingPolicyFairsharePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FairsharePolicyFactory);
    }

    public static CombinedResult<SchedulingPolicyFactory, T1, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1>(this CombinedResult<SchedulingPolicyFactory, T1> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchedulingPolicyFactory, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1>(this CombinedResult<T1, SchedulingPolicyFactory> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SchedulingPolicyFactory, T1, T2, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2>(this CombinedResult<SchedulingPolicyFactory, T1, T2> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchedulingPolicyFactory, T2, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2>(this CombinedResult<T1, SchedulingPolicyFactory, T2> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchedulingPolicyFactory, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2>(this CombinedResult<T1, T2, SchedulingPolicyFactory> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SchedulingPolicyFactory, T1, T2, T3, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3>(this CombinedResult<SchedulingPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchedulingPolicyFactory, T2, T3, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3>(this CombinedResult<T1, SchedulingPolicyFactory, T2, T3> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchedulingPolicyFactory, T3, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3>(this CombinedResult<T1, T2, SchedulingPolicyFactory, T3> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchedulingPolicyFactory, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, SchedulingPolicyFactory> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SchedulingPolicyFactory, T1, T2, T3, T4, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3, T4>(this CombinedResult<SchedulingPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SchedulingPolicyFactory, T2, T3, T4, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3, T4>(this CombinedResult<T1, SchedulingPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SchedulingPolicyFactory, T3, T4, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, SchedulingPolicyFactory, T3, T4> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SchedulingPolicyFactory, T4, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SchedulingPolicyFactory, T4> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SchedulingPolicyFactory, InnerSchedulingPolicyFairsharePolicyFactory> WithFairsharePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SchedulingPolicyFactory> combinedResult, Action<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFairsharePolicy(combinedResult.T5, subFactoryAction));
}
