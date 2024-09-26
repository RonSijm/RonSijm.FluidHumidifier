// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class ResiliencyPolicyFactory(string resourceName = null, Action<Humidifier.ResilienceHub.ResiliencyPolicy> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHub.ResiliencyPolicy>(resourceName)
{

    internal InnerResiliencyPolicyPolicyMapFactory PolicyFactory { get; set; }

    protected override Humidifier.ResilienceHub.ResiliencyPolicy Create()
    {
        var resiliencyPolicyResult = CreateResiliencyPolicy();
        factoryAction?.Invoke(resiliencyPolicyResult);

        return resiliencyPolicyResult;
    }

    private Humidifier.ResilienceHub.ResiliencyPolicy CreateResiliencyPolicy()
    {
        var resiliencyPolicyResult = new Humidifier.ResilienceHub.ResiliencyPolicy
        {
            GivenName = InputResourceName,
        };

        return resiliencyPolicyResult;
    }
    public override void CreateChildren(Humidifier.ResilienceHub.ResiliencyPolicy result)
    {
        base.CreateChildren(result);

        result.Policy ??= PolicyFactory?.Build();
    }

} // End Of Class

public static class ResiliencyPolicyFactoryExtensions
{
    public static CombinedResult<ResiliencyPolicyFactory, InnerResiliencyPolicyPolicyMapFactory> WithPolicy(this ResiliencyPolicyFactory parentFactory, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null)
    {
        parentFactory.PolicyFactory = new InnerResiliencyPolicyPolicyMapFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyFactory);
    }

    public static CombinedResult<ResiliencyPolicyFactory, T1, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1>(this CombinedResult<ResiliencyPolicyFactory, T1> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResiliencyPolicyFactory, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1>(this CombinedResult<T1, ResiliencyPolicyFactory> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResiliencyPolicyFactory, T1, T2, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2>(this CombinedResult<ResiliencyPolicyFactory, T1, T2> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResiliencyPolicyFactory, T2, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2>(this CombinedResult<T1, ResiliencyPolicyFactory, T2> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResiliencyPolicyFactory, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2>(this CombinedResult<T1, T2, ResiliencyPolicyFactory> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResiliencyPolicyFactory, T1, T2, T3, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3>(this CombinedResult<ResiliencyPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResiliencyPolicyFactory, T2, T3, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, ResiliencyPolicyFactory, T2, T3> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResiliencyPolicyFactory, T3, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, ResiliencyPolicyFactory, T3> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResiliencyPolicyFactory, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResiliencyPolicyFactory> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResiliencyPolicyFactory, T1, T2, T3, T4, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<ResiliencyPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResiliencyPolicyFactory, T2, T3, T4, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, ResiliencyPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResiliencyPolicyFactory, T3, T4, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResiliencyPolicyFactory, T3, T4> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResiliencyPolicyFactory, T4, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResiliencyPolicyFactory, T4> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResiliencyPolicyFactory, InnerResiliencyPolicyPolicyMapFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResiliencyPolicyFactory> combinedResult, Action<Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T5, subFactoryAction));
}
