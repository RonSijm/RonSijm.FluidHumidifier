// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class AccessEntryFactory(string resourceName = null, Action<Humidifier.EKS.AccessEntry> factoryAction = null) : ResourceFactory<Humidifier.EKS.AccessEntry>(resourceName)
{

    internal List<InnerAccessEntryAccessPolicyFactory> AccessPoliciesFactories { get; set; } = [];

    protected override Humidifier.EKS.AccessEntry Create()
    {
        var accessEntryResult = CreateAccessEntry();
        factoryAction?.Invoke(accessEntryResult);

        return accessEntryResult;
    }

    private Humidifier.EKS.AccessEntry CreateAccessEntry()
    {
        var accessEntryResult = new Humidifier.EKS.AccessEntry
        {
            GivenName = InputResourceName,
        };

        return accessEntryResult;
    }
    public override void CreateChildren(Humidifier.EKS.AccessEntry result)
    {
        base.CreateChildren(result);

        result.AccessPolicies = AccessPoliciesFactories.Any() ? AccessPoliciesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AccessEntryFactoryExtensions
{
    public static CombinedResult<AccessEntryFactory, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies(this AccessEntryFactory parentFactory, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null)
    {
        var factory = new InnerAccessEntryAccessPolicyFactory(subFactoryAction);
        parentFactory.AccessPoliciesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AccessEntryFactory, T1, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1>(this CombinedResult<AccessEntryFactory, T1> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessEntryFactory, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1>(this CombinedResult<T1, AccessEntryFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessEntryFactory, T1, T2, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2>(this CombinedResult<AccessEntryFactory, T1, T2> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessEntryFactory, T2, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2>(this CombinedResult<T1, AccessEntryFactory, T2> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessEntryFactory, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2>(this CombinedResult<T1, T2, AccessEntryFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessEntryFactory, T1, T2, T3, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3>(this CombinedResult<AccessEntryFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessEntryFactory, T2, T3, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3>(this CombinedResult<T1, AccessEntryFactory, T2, T3> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessEntryFactory, T3, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3>(this CombinedResult<T1, T2, AccessEntryFactory, T3> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessEntryFactory, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessEntryFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessEntryFactory, T1, T2, T3, T4, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3, T4>(this CombinedResult<AccessEntryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessEntryFactory, T2, T3, T4, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3, T4>(this CombinedResult<T1, AccessEntryFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessEntryFactory, T3, T4, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessEntryFactory, T3, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessEntryFactory, T4, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessEntryFactory, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessEntryFactory, InnerAccessEntryAccessPolicyFactory> WithAccessPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessEntryFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessPolicies(combinedResult.T5, subFactoryAction));
}
