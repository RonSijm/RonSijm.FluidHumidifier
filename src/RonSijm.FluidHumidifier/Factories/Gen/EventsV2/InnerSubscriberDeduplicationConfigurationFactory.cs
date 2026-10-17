// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberDeduplicationConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration Create()
    {
        var deduplicationConfigurationResult = CreateDeduplicationConfiguration();
        factoryAction?.Invoke(deduplicationConfigurationResult);

        return deduplicationConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration CreateDeduplicationConfiguration()
    {
        var deduplicationConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration();

        return deduplicationConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberDeduplicationConfigurationFactoryExtensions
{
}
