// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class InnerEntitlementPrincipalFactory(Action<Humidifier.AccountAccess.EntitlementTypes.Principal> factoryAction = null) : SubResourceFactory<Humidifier.AccountAccess.EntitlementTypes.Principal>
{

    internal InnerEntitlementIdentityCenterPrincipalFactory IdentityCenterFactory { get; set; }

    protected override Humidifier.AccountAccess.EntitlementTypes.Principal Create()
    {
        var principalResult = CreatePrincipal();
        factoryAction?.Invoke(principalResult);

        return principalResult;
    }

    private Humidifier.AccountAccess.EntitlementTypes.Principal CreatePrincipal()
    {
        var principalResult = new Humidifier.AccountAccess.EntitlementTypes.Principal();

        return principalResult;
    }
    public override void CreateChildren(Humidifier.AccountAccess.EntitlementTypes.Principal result)
    {
        base.CreateChildren(result);

        result.IdentityCenter ??= IdentityCenterFactory?.Build();
    }

} // End Of Class

public static class InnerEntitlementPrincipalFactoryExtensions
{
    public static CombinedResult<InnerEntitlementPrincipalFactory, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter(this InnerEntitlementPrincipalFactory parentFactory, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null)
    {
        parentFactory.IdentityCenterFactory = new InnerEntitlementIdentityCenterPrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityCenterFactory);
    }

    public static CombinedResult<InnerEntitlementPrincipalFactory, T1, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1>(this CombinedResult<InnerEntitlementPrincipalFactory, T1> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalFactory, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1>(this CombinedResult<T1, InnerEntitlementPrincipalFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementPrincipalFactory, T1, T2, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2>(this CombinedResult<InnerEntitlementPrincipalFactory, T1, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalFactory, T2, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2>(this CombinedResult<T1, InnerEntitlementPrincipalFactory, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementPrincipalFactory, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2>(this CombinedResult<T1, T2, InnerEntitlementPrincipalFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementPrincipalFactory, T1, T2, T3, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<InnerEntitlementPrincipalFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalFactory, T2, T3, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<T1, InnerEntitlementPrincipalFactory, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementPrincipalFactory, T3, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<T1, T2, InnerEntitlementPrincipalFactory, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEntitlementPrincipalFactory, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEntitlementPrincipalFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEntitlementPrincipalFactory, T1, T2, T3, T4, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<InnerEntitlementPrincipalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEntitlementPrincipalFactory, T2, T3, T4, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, InnerEntitlementPrincipalFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEntitlementPrincipalFactory, T3, T4, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEntitlementPrincipalFactory, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEntitlementPrincipalFactory, T4, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEntitlementPrincipalFactory, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEntitlementPrincipalFactory, InnerEntitlementIdentityCenterPrincipalFactory> WithIdentityCenter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEntitlementPrincipalFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.IdentityCenterPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenter(combinedResult.T5, subFactoryAction).T2);
}
