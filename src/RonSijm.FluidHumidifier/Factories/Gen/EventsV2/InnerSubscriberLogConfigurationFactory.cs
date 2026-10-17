// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberLogConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.LogConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.LogConfiguration();

        return logConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberLogConfigurationFactoryExtensions
{
}
