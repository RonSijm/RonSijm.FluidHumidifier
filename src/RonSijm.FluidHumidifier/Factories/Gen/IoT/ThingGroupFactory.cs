// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ThingGroupFactory(string resourceName = null, Action<Humidifier.IoT.ThingGroup> factoryAction = null) : ResourceFactory<Humidifier.IoT.ThingGroup>(resourceName)
{

    internal InnerThingGroupThingGroupPropertiesFactory ThingGroupPropertiesFactory { get; set; }

    protected override Humidifier.IoT.ThingGroup Create()
    {
        var thingGroupResult = CreateThingGroup();
        factoryAction?.Invoke(thingGroupResult);

        return thingGroupResult;
    }

    private Humidifier.IoT.ThingGroup CreateThingGroup()
    {
        var thingGroupResult = new Humidifier.IoT.ThingGroup
        {
            GivenName = InputResourceName,
        };

        return thingGroupResult;
    }
    public override void CreateChildren(Humidifier.IoT.ThingGroup result)
    {
        base.CreateChildren(result);

        result.ThingGroupProperties ??= ThingGroupPropertiesFactory?.Build();
    }

} // End Of Class

public static class ThingGroupFactoryExtensions
{
    public static CombinedResult<ThingGroupFactory, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties(this ThingGroupFactory parentFactory, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null)
    {
        parentFactory.ThingGroupPropertiesFactory = new InnerThingGroupThingGroupPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ThingGroupPropertiesFactory);
    }

    public static CombinedResult<ThingGroupFactory, T1, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1>(this CombinedResult<ThingGroupFactory, T1> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingGroupFactory, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1>(this CombinedResult<T1, ThingGroupFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThingGroupFactory, T1, T2, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2>(this CombinedResult<ThingGroupFactory, T1, T2> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingGroupFactory, T2, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2>(this CombinedResult<T1, ThingGroupFactory, T2> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingGroupFactory, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2>(this CombinedResult<T1, T2, ThingGroupFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThingGroupFactory, T1, T2, T3, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3>(this CombinedResult<ThingGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingGroupFactory, T2, T3, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3>(this CombinedResult<T1, ThingGroupFactory, T2, T3> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingGroupFactory, T3, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3>(this CombinedResult<T1, T2, ThingGroupFactory, T3> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThingGroupFactory, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThingGroupFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThingGroupFactory, T1, T2, T3, T4, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3, T4>(this CombinedResult<ThingGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingGroupFactory, T2, T3, T4, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, ThingGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingGroupFactory, T3, T4, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThingGroupFactory, T3, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThingGroupFactory, T4, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThingGroupFactory, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThingGroupFactory, InnerThingGroupThingGroupPropertiesFactory> WithThingGroupProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThingGroupFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingGroupProperties(combinedResult.T5, subFactoryAction));
}
