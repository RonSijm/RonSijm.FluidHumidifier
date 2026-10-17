// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberFilterConfigurationFactory(Action<Humidifier.EventsV2.SubscriberTypes.FilterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.FilterConfiguration>
{

    protected override Humidifier.EventsV2.SubscriberTypes.FilterConfiguration Create()
    {
        var filterConfigurationResult = CreateFilterConfiguration();
        factoryAction?.Invoke(filterConfigurationResult);

        return filterConfigurationResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.FilterConfiguration CreateFilterConfiguration()
    {
        var filterConfigurationResult = new Humidifier.EventsV2.SubscriberTypes.FilterConfiguration();

        return filterConfigurationResult;
    }

} // End Of Class

public static class InnerSubscriberFilterConfigurationFactoryExtensions
{
}
