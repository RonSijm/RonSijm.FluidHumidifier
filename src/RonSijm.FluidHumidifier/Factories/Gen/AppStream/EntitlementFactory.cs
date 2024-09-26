// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class EntitlementFactory(string resourceName = null, Action<Humidifier.AppStream.Entitlement> factoryAction = null) : ResourceFactory<Humidifier.AppStream.Entitlement>(resourceName)
{

    internal List<InnerEntitlementAttributeFactory> Attributes_Factories { get; set; } = [];

    protected override Humidifier.AppStream.Entitlement Create()
    {
        var entitlementResult = CreateEntitlement();
        factoryAction?.Invoke(entitlementResult);

        return entitlementResult;
    }

    private Humidifier.AppStream.Entitlement CreateEntitlement()
    {
        var entitlementResult = new Humidifier.AppStream.Entitlement
        {
            GivenName = InputResourceName,
        };

        return entitlementResult;
    }
    public override void CreateChildren(Humidifier.AppStream.Entitlement result)
    {
        base.CreateChildren(result);

        result.Attributes_ = Attributes_Factories.Any() ? Attributes_Factories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EntitlementFactoryExtensions
{
    public static CombinedResult<EntitlementFactory, InnerEntitlementAttributeFactory> WithAttributes_(this EntitlementFactory parentFactory, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null)
    {
        var factory = new InnerEntitlementAttributeFactory(subFactoryAction);
        parentFactory.Attributes_Factories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EntitlementFactory, T1, InnerEntitlementAttributeFactory> WithAttributes_<T1>(this CombinedResult<EntitlementFactory, T1> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EntitlementFactory, InnerEntitlementAttributeFactory> WithAttributes_<T1>(this CombinedResult<T1, EntitlementFactory> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EntitlementFactory, T1, T2, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2>(this CombinedResult<EntitlementFactory, T1, T2> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EntitlementFactory, T2, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, EntitlementFactory, T2> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EntitlementFactory, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2>(this CombinedResult<T1, T2, EntitlementFactory> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EntitlementFactory, T1, T2, T3, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<EntitlementFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EntitlementFactory, T2, T3, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, EntitlementFactory, T2, T3> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EntitlementFactory, T3, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, EntitlementFactory, T3> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EntitlementFactory, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3>(this CombinedResult<T1, T2, T3, EntitlementFactory> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EntitlementFactory, T1, T2, T3, T4, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<EntitlementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EntitlementFactory, T2, T3, T4, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, EntitlementFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EntitlementFactory, T3, T4, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, EntitlementFactory, T3, T4> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EntitlementFactory, T4, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EntitlementFactory, T4> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EntitlementFactory, InnerEntitlementAttributeFactory> WithAttributes_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EntitlementFactory> combinedResult, Action<Humidifier.AppStream.EntitlementTypes.Attribute> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributes_(combinedResult.T5, subFactoryAction));
}
