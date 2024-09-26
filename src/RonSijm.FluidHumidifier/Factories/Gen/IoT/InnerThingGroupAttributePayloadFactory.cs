// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerThingGroupAttributePayloadFactory(Action<Humidifier.IoT.ThingGroupTypes.AttributePayload> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ThingGroupTypes.AttributePayload>
{

    protected override Humidifier.IoT.ThingGroupTypes.AttributePayload Create()
    {
        var attributePayloadResult = CreateAttributePayload();
        factoryAction?.Invoke(attributePayloadResult);

        return attributePayloadResult;
    }

    private Humidifier.IoT.ThingGroupTypes.AttributePayload CreateAttributePayload()
    {
        var attributePayloadResult = new Humidifier.IoT.ThingGroupTypes.AttributePayload();

        return attributePayloadResult;
    }

} // End Of Class

public static class InnerThingGroupAttributePayloadFactoryExtensions
{
}
