// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerRecommenderEventsConfigFactory(Action<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig>
{

    protected override Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig Create()
    {
        var eventsConfigResult = CreateEventsConfig();
        factoryAction?.Invoke(eventsConfigResult);

        return eventsConfigResult;
    }

    private Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig CreateEventsConfig()
    {
        var eventsConfigResult = new Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig();

        return eventsConfigResult;
    }

} // End Of Class

public static class InnerRecommenderEventsConfigFactoryExtensions
{
}
