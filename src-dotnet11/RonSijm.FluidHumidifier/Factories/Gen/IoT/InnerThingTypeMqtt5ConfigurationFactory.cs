// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerThingTypeMqtt5ConfigurationFactory(Action<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration>
{

    protected override Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration Create()
    {
        var mqtt5ConfigurationResult = CreateMqtt5Configuration();
        factoryAction?.Invoke(mqtt5ConfigurationResult);

        return mqtt5ConfigurationResult;
    }

    private Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration CreateMqtt5Configuration()
    {
        var mqtt5ConfigurationResult = new Humidifier.IoT.ThingTypeTypes.Mqtt5Configuration();

        return mqtt5ConfigurationResult;
    }

} // End Of Class

public static class InnerThingTypeMqtt5ConfigurationFactoryExtensions
{
}
