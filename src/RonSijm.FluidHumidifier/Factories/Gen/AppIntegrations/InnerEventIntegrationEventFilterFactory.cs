// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class InnerEventIntegrationEventFilterFactory(Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> factoryAction = null) : SubResourceFactory<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter>
{

    protected override Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter Create()
    {
        var eventFilterResult = CreateEventFilter();
        factoryAction?.Invoke(eventFilterResult);

        return eventFilterResult;
    }

    private Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter CreateEventFilter()
    {
        var eventFilterResult = new Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter();

        return eventFilterResult;
    }

} // End Of Class

public static class InnerEventIntegrationEventFilterFactoryExtensions
{
}
