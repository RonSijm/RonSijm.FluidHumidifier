// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerOwnerOwnerPropertiesFactory(Action<Humidifier.DataZone.OwnerTypes.OwnerProperties> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.OwnerTypes.OwnerProperties>
{

    internal InnerOwnerOwnerGroupPropertiesFactory GroupFactory { get; set; }

    internal InnerOwnerOwnerUserPropertiesFactory UserFactory { get; set; }

    protected override Humidifier.DataZone.OwnerTypes.OwnerProperties Create()
    {
        var ownerPropertiesResult = CreateOwnerProperties();
        factoryAction?.Invoke(ownerPropertiesResult);

        return ownerPropertiesResult;
    }

    private Humidifier.DataZone.OwnerTypes.OwnerProperties CreateOwnerProperties()
    {
        var ownerPropertiesResult = new Humidifier.DataZone.OwnerTypes.OwnerProperties();

        return ownerPropertiesResult;
    }
    public override void CreateChildren(Humidifier.DataZone.OwnerTypes.OwnerProperties result)
    {
        base.CreateChildren(result);

        result.Group ??= GroupFactory?.Build();
        result.User ??= UserFactory?.Build();
    }

} // End Of Class

public static class InnerOwnerOwnerPropertiesFactoryExtensions
{
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerGroupPropertiesFactory> WithGroup(this InnerOwnerOwnerPropertiesFactory parentFactory, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null)
    {
        parentFactory.GroupFactory = new InnerOwnerOwnerGroupPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupFactory);
    }

    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerUserPropertiesFactory> WithUser(this InnerOwnerOwnerPropertiesFactory parentFactory, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null)
    {
        parentFactory.UserFactory = new InnerOwnerOwnerUserPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UserFactory);
    }

    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2>(this CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3>(this CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3, T4, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3, T4>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3, T4, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3, T4>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3, T4, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory, T4, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerGroupPropertiesFactory> WithGroup<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroup(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2>(this CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3>(this CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3, T4, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<InnerOwnerOwnerPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3, T4, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, InnerOwnerOwnerPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3, T4, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOwnerOwnerPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory, T4, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOwnerOwnerPropertiesFactory, T4> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOwnerOwnerPropertiesFactory, InnerOwnerOwnerUserPropertiesFactory> WithUser<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOwnerOwnerPropertiesFactory> combinedResult, Action<Humidifier.DataZone.OwnerTypes.OwnerUserProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUser(combinedResult.T5, subFactoryAction).T2);
}
