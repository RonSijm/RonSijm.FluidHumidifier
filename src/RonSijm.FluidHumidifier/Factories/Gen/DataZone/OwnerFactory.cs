// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class OwnerFactory(string resourceName = null, Action<Humidifier.DataZone.Owner> factoryAction = null) : ResourceFactory<Humidifier.DataZone.Owner>(resourceName)
{

    internal InnerOwnerOwnerPropertiesFactory Owner_Factory { get; set; }

    protected override Humidifier.DataZone.Owner Create()
    {
        var ownerResult = CreateOwner();
        factoryAction?.Invoke(ownerResult);

        return ownerResult;
    }

    private Humidifier.DataZone.Owner CreateOwner()
    {
        var ownerResult = new Humidifier.DataZone.Owner
        {
            GivenName = InputResourceName,
        };

        return ownerResult;
    }
    public override void CreateChildren(Humidifier.DataZone.Owner result)
    {
        base.CreateChildren(result);

        result.Owner_ ??= Owner_Factory?.Build();
    }

} // End Of Class

public static class OwnerFactoryExtensions
{
    public static CombinedResult<OwnerFactory, InnerOwnerOwnerPropertiesFactory> WithOwner_(this OwnerFactory parentFactory, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null)
    {
        parentFactory.Owner_Factory = new InnerOwnerOwnerPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Owner_Factory);
    }

    public static CombinedResult<OwnerFactory, T1, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1>(this CombinedResult<OwnerFactory, T1> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwner_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OwnerFactory, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1>(this CombinedResult<T1, OwnerFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithOwner_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OwnerFactory, T1, T2, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2>(this CombinedResult<OwnerFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OwnerFactory, T2, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2>(this CombinedResult<T1, OwnerFactory, T2> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OwnerFactory, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2>(this CombinedResult<T1, T2, OwnerFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OwnerFactory, T1, T2, T3, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3>(this CombinedResult<OwnerFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OwnerFactory, T2, T3, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3>(this CombinedResult<T1, OwnerFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OwnerFactory, T3, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3>(this CombinedResult<T1, T2, OwnerFactory, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OwnerFactory, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3>(this CombinedResult<T1, T2, T3, OwnerFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OwnerFactory, T1, T2, T3, T4, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3, T4>(this CombinedResult<OwnerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OwnerFactory, T2, T3, T4, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3, T4>(this CombinedResult<T1, OwnerFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OwnerFactory, T3, T4, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3, T4>(this CombinedResult<T1, T2, OwnerFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OwnerFactory, T4, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OwnerFactory, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OwnerFactory, InnerOwnerOwnerPropertiesFactory> WithOwner_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OwnerFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOwner_(combinedResult.T5, subFactoryAction).T2);
}
