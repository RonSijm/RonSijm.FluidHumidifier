// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class InnerEntitlementPrincipalRoleEntitlementFactory(Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> factoryAction = null) : SubResourceFactory<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement>
{

    internal InnerEntitlementPrincipalFactory PrincipalFactory { get; set; }

    protected override Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement Create()
    {
        var principalRoleEntitlementResult = CreatePrincipalRoleEntitlement();
        factoryAction?.Invoke(principalRoleEntitlementResult);

        return principalRoleEntitlementResult;
    }

    private Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement CreatePrincipalRoleEntitlement()
    {
        var principalRoleEntitlementResult = new Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement();

        return principalRoleEntitlementResult;
    }
    public override void CreateChildren(Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement result)
    {
        base.CreateChildren(result);

        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class InnerEntitlementPrincipalRoleEntitlementFactoryExtensions
{
    public static CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, InnerEntitlementPrincipalFactory> WithPrincipal(this InnerEntitlementPrincipalRoleEntitlementFactory parentFactory, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerEntitlementPrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, InnerEntitlementPrincipalFactory> WithPrincipal<T1>(this CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, InnerEntitlementPrincipalFactory> WithPrincipal<T1>(this CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, T2, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, T2, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, T2, T3, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, T2, T3, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory, T3, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEntitlementPrincipalRoleEntitlementFactory, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEntitlementPrincipalRoleEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, T2, T3, T4, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<InnerEntitlementPrincipalRoleEntitlementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, T2, T3, T4, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, InnerEntitlementPrincipalRoleEntitlementFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory, T3, T4, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEntitlementPrincipalRoleEntitlementFactory, T4, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEntitlementPrincipalRoleEntitlementFactory, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEntitlementPrincipalRoleEntitlementFactory, InnerEntitlementPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEntitlementPrincipalRoleEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Principal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction).T2);
}
