// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerThingTypeThingTypePropertiesFactory(Action<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ThingTypeTypes.ThingTypeProperties>
{

    protected override Humidifier.IoT.ThingTypeTypes.ThingTypeProperties Create()
    {
        var thingTypePropertiesResult = CreateThingTypeProperties();
        factoryAction?.Invoke(thingTypePropertiesResult);

        return thingTypePropertiesResult;
    }

    private Humidifier.IoT.ThingTypeTypes.ThingTypeProperties CreateThingTypeProperties()
    {
        var thingTypePropertiesResult = new Humidifier.IoT.ThingTypeTypes.ThingTypeProperties();

        return thingTypePropertiesResult;
    }

} // End Of Class

public static class InnerThingTypeThingTypePropertiesFactoryExtensions
{
}
