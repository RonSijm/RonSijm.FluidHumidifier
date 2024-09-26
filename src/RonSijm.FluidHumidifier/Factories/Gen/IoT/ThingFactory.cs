// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ThingFactory(string resourceName = null, Action<Humidifier.IoT.Thing> factoryAction = null) : ResourceFactory<Humidifier.IoT.Thing>(resourceName)
{

    internal InnerThingAttributePayloadFactory AttributePayloadFactory { get; set; }

    protected override Humidifier.IoT.Thing Create()
    {
        var thingResult = CreateThing();
        factoryAction?.Invoke(thingResult);

        return thingResult;
    }

    private Humidifier.IoT.Thing CreateThing()
    {
        var thingResult = new Humidifier.IoT.Thing
        {
            GivenName = InputResourceName,
        };

        return thingResult;
    }
    public override void CreateChildren(Humidifier.IoT.Thing result)
    {
        base.CreateChildren(result);

        result.AttributePayload ??= AttributePayloadFactory?.Build();
    }

} // End Of Class

public static class ThingFactoryExtensions
{
    public static CombinedResult<ThingFactory, InnerThingAttributePayloadFactory> WithAttributePayload(this ThingFactory parentFactory, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null)
    {
        parentFactory.AttributePayloadFactory = new InnerThingAttributePayloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AttributePayloadFactory);
    }

    public static CombinedResult<ThingFactory, T1, InnerThingAttributePayloadFactory> WithAttributePayload<T1>(this CombinedResult<ThingFactory, T1> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingFactory, InnerThingAttributePayloadFactory> WithAttributePayload<T1>(this CombinedResult<T1, ThingFactory> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThingFactory, T1, T2, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2>(this CombinedResult<ThingFactory, T1, T2> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingFactory, T2, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2>(this CombinedResult<T1, ThingFactory, T2> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingFactory, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2>(this CombinedResult<T1, T2, ThingFactory> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThingFactory, T1, T2, T3, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<ThingFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingFactory, T2, T3, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<T1, ThingFactory, T2, T3> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingFactory, T3, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<T1, T2, ThingFactory, T3> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThingFactory, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThingFactory> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThingFactory, T1, T2, T3, T4, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<ThingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThingFactory, T2, T3, T4, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, ThingFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThingFactory, T3, T4, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThingFactory, T3, T4> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThingFactory, T4, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThingFactory, T4> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThingFactory, InnerThingAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThingFactory> combinedResult, Action<Humidifier.IoT.ThingTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T5, subFactoryAction));
}
