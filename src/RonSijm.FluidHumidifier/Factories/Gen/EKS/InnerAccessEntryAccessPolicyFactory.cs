// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerAccessEntryAccessPolicyFactory(Action<Humidifier.EKS.AccessEntryTypes.AccessPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EKS.AccessEntryTypes.AccessPolicy>
{

    internal InnerAccessEntryAccessScopeFactory AccessScopeFactory { get; set; }

    protected override Humidifier.EKS.AccessEntryTypes.AccessPolicy Create()
    {
        var accessPolicyResult = CreateAccessPolicy();
        factoryAction?.Invoke(accessPolicyResult);

        return accessPolicyResult;
    }

    private Humidifier.EKS.AccessEntryTypes.AccessPolicy CreateAccessPolicy()
    {
        var accessPolicyResult = new Humidifier.EKS.AccessEntryTypes.AccessPolicy();

        return accessPolicyResult;
    }
    public override void CreateChildren(Humidifier.EKS.AccessEntryTypes.AccessPolicy result)
    {
        base.CreateChildren(result);

        result.AccessScope ??= AccessScopeFactory?.Build();
    }

} // End Of Class

public static class InnerAccessEntryAccessPolicyFactoryExtensions
{
    public static CombinedResult<InnerAccessEntryAccessPolicyFactory, InnerAccessEntryAccessScopeFactory> WithAccessScope(this InnerAccessEntryAccessPolicyFactory parentFactory, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null)
    {
        parentFactory.AccessScopeFactory = new InnerAccessEntryAccessScopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessScopeFactory);
    }

    public static CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1>(this CombinedResult<InnerAccessEntryAccessPolicyFactory, T1> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1>(this CombinedResult<T1, InnerAccessEntryAccessPolicyFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, T2, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2>(this CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, T2> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, T2, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2>(this CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, T2> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessEntryAccessPolicyFactory, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2>(this CombinedResult<T1, T2, InnerAccessEntryAccessPolicyFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, T2, T3, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3>(this CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, T2, T3, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3>(this CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, T2, T3> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessEntryAccessPolicyFactory, T3, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessEntryAccessPolicyFactory, T3> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessEntryAccessPolicyFactory, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessEntryAccessPolicyFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, T2, T3, T4, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3, T4>(this CombinedResult<InnerAccessEntryAccessPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, T2, T3, T4, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessEntryAccessPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessEntryAccessPolicyFactory, T3, T4, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessEntryAccessPolicyFactory, T3, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessEntryAccessPolicyFactory, T4, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessEntryAccessPolicyFactory, T4> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessEntryAccessPolicyFactory, InnerAccessEntryAccessScopeFactory> WithAccessScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessEntryAccessPolicyFactory> combinedResult, Action<Humidifier.EKS.AccessEntryTypes.AccessScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessScope(combinedResult.T5, subFactoryAction));
}
