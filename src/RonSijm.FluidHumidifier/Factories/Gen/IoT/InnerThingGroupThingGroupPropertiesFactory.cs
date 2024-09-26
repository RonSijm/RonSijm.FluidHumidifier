// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerThingGroupThingGroupPropertiesFactory(Action<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ThingGroupTypes.ThingGroupProperties>
{

    internal InnerThingGroupAttributePayloadFactory AttributePayloadFactory { get; set; }

    protected override Humidifier.IoT.ThingGroupTypes.ThingGroupProperties Create()
    {
        var thingGroupPropertiesResult = CreateThingGroupProperties();
        factoryAction?.Invoke(thingGroupPropertiesResult);

        return thingGroupPropertiesResult;
    }

    private Humidifier.IoT.ThingGroupTypes.ThingGroupProperties CreateThingGroupProperties()
    {
        var thingGroupPropertiesResult = new Humidifier.IoT.ThingGroupTypes.ThingGroupProperties();

        return thingGroupPropertiesResult;
    }
    public override void CreateChildren(Humidifier.IoT.ThingGroupTypes.ThingGroupProperties result)
    {
        base.CreateChildren(result);

        result.AttributePayload ??= AttributePayloadFactory?.Build();
    }

} // End Of Class

public static class InnerThingGroupThingGroupPropertiesFactoryExtensions
{
    public static CombinedResult<InnerThingGroupThingGroupPropertiesFactory, InnerThingGroupAttributePayloadFactory> WithAttributePayload(this InnerThingGroupThingGroupPropertiesFactory parentFactory, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null)
    {
        parentFactory.AttributePayloadFactory = new InnerThingGroupAttributePayloadFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AttributePayloadFactory);
    }

    public static CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1>(this CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1>(this CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, T2, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2>(this CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, T2, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2>(this CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, T2> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThingGroupThingGroupPropertiesFactory, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2>(this CombinedResult<T1, T2, InnerThingGroupThingGroupPropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, T2, T3, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, T2, T3, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThingGroupThingGroupPropertiesFactory, T3, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<T1, T2, InnerThingGroupThingGroupPropertiesFactory, T3> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThingGroupThingGroupPropertiesFactory, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThingGroupThingGroupPropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, T2, T3, T4, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<InnerThingGroupThingGroupPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, T2, T3, T4, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, InnerThingGroupThingGroupPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThingGroupThingGroupPropertiesFactory, T3, T4, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThingGroupThingGroupPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThingGroupThingGroupPropertiesFactory, T4, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThingGroupThingGroupPropertiesFactory, T4> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThingGroupThingGroupPropertiesFactory, InnerThingGroupAttributePayloadFactory> WithAttributePayload<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThingGroupThingGroupPropertiesFactory> combinedResult, Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttributePayload(combinedResult.T5, subFactoryAction));
}
