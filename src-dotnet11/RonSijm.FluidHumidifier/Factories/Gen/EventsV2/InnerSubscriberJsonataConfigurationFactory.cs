// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberJsonataConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration Create()
    {
        var jsonataConfigurationResult = CreateJsonataConfiguration();
        factoryAction?.Invoke(jsonataConfigurationResult);

        return jsonataConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration CreateJsonataConfiguration()
    {
        var jsonataConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration();

        return jsonataConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberJsonataConfigurationFactoryExtensions
{
}
