// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class InnerEntitlementEntitlementFactory(Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> factoryAction = null) : SubResourceFactory<Humidifier.AccountAccess.EntitlementTypes.Entitlement>
{

    internal InnerEntitlementPrincipalRoleEntitlementFactory PrincipalRoleFactory { get; set; }

    protected override Humidifier.AccountAccess.EntitlementTypes.Entitlement Create()
    {
        var entitlementResult = CreateEntitlement();
        factoryAction?.Invoke(entitlementResult);

        return entitlementResult;
    }

    private Humidifier.AccountAccess.EntitlementTypes.Entitlement CreateEntitlement()
    {
        var entitlementResult = new Humidifier.AccountAccess.EntitlementTypes.Entitlement();

        return entitlementResult;
    }
    public override void CreateChildren(Humidifier.AccountAccess.EntitlementTypes.Entitlement result)
    {
        base.CreateChildren(result);

        result.PrincipalRole ??= PrincipalRoleFactory?.Build();
    }

} // End Of Class

public static class InnerEntitlementEntitlementFactoryExtensions
{
    public static CombinedResult<InnerEntitlementEntitlementFactory, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole(this InnerEntitlementEntitlementFactory parentFactory, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null)
    {
        parentFactory.PrincipalRoleFactory = new InnerEntitlementPrincipalRoleEntitlementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalRoleFactory);
    }

    public static CombinedResult<InnerEntitlementEntitlementFactory, T1, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1>(this CombinedResult<InnerEntitlementEntitlementFactory, T1> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipalRole(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementEntitlementFactory, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1>(this CombinedResult<T1, InnerEntitlementEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipalRole(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementEntitlementFactory, T1, T2, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2>(this CombinedResult<InnerEntitlementEntitlementFactory, T1, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementEntitlementFactory, T2, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2>(this CombinedResult<T1, InnerEntitlementEntitlementFactory, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementEntitlementFactory, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2>(this CombinedResult<T1, T2, InnerEntitlementEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementEntitlementFactory, T1, T2, T3, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3>(this CombinedResult<InnerEntitlementEntitlementFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementEntitlementFactory, T2, T3, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3>(this CombinedResult<T1, InnerEntitlementEntitlementFactory, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementEntitlementFactory, T3, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3>(this CombinedResult<T1, T2, InnerEntitlementEntitlementFactory, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEntitlementEntitlementFactory, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEntitlementEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementEntitlementFactory, T1, T2, T3, T4, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3, T4>(this CombinedResult<InnerEntitlementEntitlementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementEntitlementFactory, T2, T3, T4, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3, T4>(this CombinedResult<T1, InnerEntitlementEntitlementFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementEntitlementFactory, T3, T4, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEntitlementEntitlementFactory, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEntitlementEntitlementFactory, T4, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEntitlementEntitlementFactory, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEntitlementEntitlementFactory, InnerEntitlementPrincipalRoleEntitlementFactory> WithPrincipalRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEntitlementEntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.PrincipalRoleEntitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipalRole(combinedResult.T5, subFactoryAction).T2);
}
