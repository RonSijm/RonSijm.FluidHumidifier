// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class PolicyGrantFactory(string resourceName = null, Action<Humidifier.DataZone.PolicyGrant> factoryAction = null) : ResourceFactory<Humidifier.DataZone.PolicyGrant>(resourceName)
{

    internal InnerPolicyGrantPolicyGrantDetailFactory DetailFactory { get; set; }

    internal InnerPolicyGrantPolicyGrantPrincipalFactory PrincipalFactory { get; set; }

    protected override Humidifier.DataZone.PolicyGrant Create()
    {
        var policyGrantResult = CreatePolicyGrant();
        factoryAction?.Invoke(policyGrantResult);

        return policyGrantResult;
    }

    private Humidifier.DataZone.PolicyGrant CreatePolicyGrant()
    {
        var policyGrantResult = new Humidifier.DataZone.PolicyGrant
        {
            GivenName = InputResourceName,
        };

        return policyGrantResult;
    }
    public override void CreateChildren(Humidifier.DataZone.PolicyGrant result)
    {
        base.CreateChildren(result);

        result.Detail ??= DetailFactory?.Build();
        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class PolicyGrantFactoryExtensions
{
    public static CombinedResult<PolicyGrantFactory, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail(this PolicyGrantFactory parentFactory, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null)
    {
        parentFactory.DetailFactory = new InnerPolicyGrantPolicyGrantDetailFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DetailFactory);
    }

    public static CombinedResult<PolicyGrantFactory, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal(this PolicyGrantFactory parentFactory, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerPolicyGrantPolicyGrantPrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<PolicyGrantFactory, T1, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1>(this CombinedResult<PolicyGrantFactory, T1> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1>(this CombinedResult<T1, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, WithDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, T2, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2>(this CombinedResult<PolicyGrantFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, T2, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2>(this CombinedResult<T1, PolicyGrantFactory, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGrantFactory, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2>(this CombinedResult<T1, T2, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, T2, T3, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3>(this CombinedResult<PolicyGrantFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, T2, T3, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3>(this CombinedResult<T1, PolicyGrantFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGrantFactory, T3, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3>(this CombinedResult<T1, T2, PolicyGrantFactory, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyGrantFactory, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, T2, T3, T4, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3, T4>(this CombinedResult<PolicyGrantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, T2, T3, T4, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3, T4>(this CombinedResult<T1, PolicyGrantFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGrantFactory, T3, T4, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyGrantFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyGrantFactory, T4, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyGrantFactory, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PolicyGrantFactory, InnerPolicyGrantPolicyGrantDetailFactory> WithDetail<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantDetail> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetail(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1>(this CombinedResult<PolicyGrantFactory, T1> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1>(this CombinedResult<T1, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, T2, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<PolicyGrantFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, T2, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, PolicyGrantFactory, T2> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGrantFactory, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, T2, T3, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<PolicyGrantFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, T2, T3, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, PolicyGrantFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGrantFactory, T3, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, PolicyGrantFactory, T3> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyGrantFactory, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PolicyGrantFactory, T1, T2, T3, T4, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<PolicyGrantFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyGrantFactory, T2, T3, T4, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, PolicyGrantFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyGrantFactory, T3, T4, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyGrantFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyGrantFactory, T4, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyGrantFactory, T4> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PolicyGrantFactory, InnerPolicyGrantPolicyGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyGrantFactory> combinedResult, Action<Humidifier.DataZone.PolicyGrantTypes.PolicyGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction).T2);
}
