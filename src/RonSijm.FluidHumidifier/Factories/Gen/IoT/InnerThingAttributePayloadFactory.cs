// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerThingAttributePayloadFactory(Action<Humidifier.IoT.ThingTypes.AttributePayload> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ThingTypes.AttributePayload>
{

    protected override Humidifier.IoT.ThingTypes.AttributePayload Create()
    {
        var attributePayloadResult = CreateAttributePayload();
        factoryAction?.Invoke(attributePayloadResult);

        return attributePayloadResult;
    }

    private Humidifier.IoT.ThingTypes.AttributePayload CreateAttributePayload()
    {
        var attributePayloadResult = new Humidifier.IoT.ThingTypes.AttributePayload();

        return attributePayloadResult;
    }

} // End Of Class

public static class InnerThingAttributePayloadFactoryExtensions
{
}
