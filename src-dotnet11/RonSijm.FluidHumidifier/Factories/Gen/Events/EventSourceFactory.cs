// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class EventSourceFactory(string resourceName = null, Action<Humidifier.Events.EventSource> factoryAction = null) : ResourceFactory<Humidifier.Events.EventSource>(resourceName)
{

    protected override Humidifier.Events.EventSource Create()
    {
        var eventSourceResult = CreateEventSource();
        factoryAction?.Invoke(eventSourceResult);

        return eventSourceResult;
    }

    private Humidifier.Events.EventSource CreateEventSource()
    {
        var eventSourceResult = new Humidifier.Events.EventSource
        {
            GivenName = InputResourceName,
        };

        return eventSourceResult;
    }

} // End Of Class

public static class EventSourceFactoryExtensions
{
}
