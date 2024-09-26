// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ThingTypeFactory(string resourceName = null, Action<Humidifier.IoT.ThingType> factoryAction = null) : ResourceFactory<Humidifier.IoT.ThingType>(resourceName)
{

    internal InnerThingTypeThingTypePropertiesFactory ThingTypePropertiesFactory { get; set; }

    protected override Humidifier.IoT.ThingType Create()
    {
        var thingTypeResult = CreateThingType();
        factoryAction?.Invoke(thingTypeResult);

        return thingTypeResult;
    }

    private Humidifier.IoT.ThingType CreateThingType()
    {
        var thingTypeResult = new Humidifier.IoT.ThingType
        {
            GivenName = InputResourceName,
        };

        return thingTypeResult;
    }
    public override void CreateChildren(Humidifier.IoT.ThingType result)
    {
        base.CreateChildren(result);

        result.ThingTypeProperties ??= ThingTypePropertiesFactory?.Build();
    }

} // End Of Class

public static class ThingTypeFactoryExtensions
{
    public static CombinedResult<ThingTypeFactory, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties(this ThingTypeFactory parentFactory, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null)
    {
        parentFactory.ThingTypePropertiesFactory = new InnerThingTypeThingTypePropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ThingTypePropertiesFactory);
    }

    public static CombinedResult<ThingTypeFactory, T1, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1>(this CombinedResult<ThingTypeFactory, T1> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingTypeFactory, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1>(this CombinedResult<T1, ThingTypeFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThingTypeFactory, T1, T2, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2>(this CombinedResult<ThingTypeFactory, T1, T2> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingTypeFactory, T2, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2>(this CombinedResult<T1, ThingTypeFactory, T2> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingTypeFactory, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2>(this CombinedResult<T1, T2, ThingTypeFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThingTypeFactory, T1, T2, T3, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3>(this CombinedResult<ThingTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingTypeFactory, T2, T3, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3>(this CombinedResult<T1, ThingTypeFactory, T2, T3> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingTypeFactory, T3, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3>(this CombinedResult<T1, T2, ThingTypeFactory, T3> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThingTypeFactory, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThingTypeFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThingTypeFactory, T1, T2, T3, T4, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3, T4>(this CombinedResult<ThingTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingTypeFactory, T2, T3, T4, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3, T4>(this CombinedResult<T1, ThingTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingTypeFactory, T3, T4, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThingTypeFactory, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThingTypeFactory, T4, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThingTypeFactory, T4> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThingTypeFactory, InnerThingTypeThingTypePropertiesFactory> WithThingTypeProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThingTypeFactory> combinedResult, Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithThingTypeProperties(combinedResult.T5, subFactoryAction));
}
