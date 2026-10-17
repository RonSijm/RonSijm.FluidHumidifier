// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccountAccess;

public class EntitlementFactory(string resourceName = null, Action<Humidifier.AccountAccess.Entitlement> factoryAction = null) : ResourceFactory<Humidifier.AccountAccess.Entitlement>(resourceName)
{

    internal InnerEntitlementEntitlementFactory Entitlement_Factory { get; set; }

    protected override Humidifier.AccountAccess.Entitlement Create()
    {
        var entitlementResult = CreateEntitlement();
        factoryAction?.Invoke(entitlementResult);

        return entitlementResult;
    }

    private Humidifier.AccountAccess.Entitlement CreateEntitlement()
    {
        var entitlementResult = new Humidifier.AccountAccess.Entitlement
        {
            GivenName = InputResourceName,
        };

        return entitlementResult;
    }
    public override void CreateChildren(Humidifier.AccountAccess.Entitlement result)
    {
        base.CreateChildren(result);

        result.Entitlement_ ??= Entitlement_Factory?.Build();
    }

} // End Of Class

public static class EntitlementFactoryExtensions
{
    public static CombinedResult<EntitlementFactory, InnerEntitlementEntitlementFactory> WithEntitlement_(this EntitlementFactory parentFactory, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null)
    {
        parentFactory.Entitlement_Factory = new InnerEntitlementEntitlementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Entitlement_Factory);
    }

    public static CombinedResult<EntitlementFactory, T1, InnerEntitlementEntitlementFactory> WithEntitlement_<T1>(this CombinedResult<EntitlementFactory, T1> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntitlement_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitlementFactory, InnerEntitlementEntitlementFactory> WithEntitlement_<T1>(this CombinedResult<T1, EntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntitlement_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EntitlementFactory, T1, T2, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2>(this CombinedResult<EntitlementFactory, T1, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitlementFactory, T2, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2>(this CombinedResult<T1, EntitlementFactory, T2> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntitlementFactory, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2>(this CombinedResult<T1, T2, EntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EntitlementFactory, T1, T2, T3, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3>(this CombinedResult<EntitlementFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitlementFactory, T2, T3, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3>(this CombinedResult<T1, EntitlementFactory, T2, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntitlementFactory, T3, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3>(this CombinedResult<T1, T2, EntitlementFactory, T3> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntitlementFactory, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3>(this CombinedResult<T1, T2, T3, EntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EntitlementFactory, T1, T2, T3, T4, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3, T4>(this CombinedResult<EntitlementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EntitlementFactory, T2, T3, T4, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3, T4>(this CombinedResult<T1, EntitlementFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EntitlementFactory, T3, T4, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3, T4>(this CombinedResult<T1, T2, EntitlementFactory, T3, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EntitlementFactory, T4, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EntitlementFactory, T4> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EntitlementFactory, InnerEntitlementEntitlementFactory> WithEntitlement_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EntitlementFactory> combinedResult, Action<Humidifier.AccountAccess.EntitlementTypes.Entitlement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntitlement_(combinedResult.T5, subFactoryAction).T2);
}
