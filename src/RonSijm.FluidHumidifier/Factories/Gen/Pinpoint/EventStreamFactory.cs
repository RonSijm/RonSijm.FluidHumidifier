// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class EventStreamFactory(string resourceName = null, Action<Humidifier.Pinpoint.EventStream> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.EventStream>(resourceName)
{

    protected override Humidifier.Pinpoint.EventStream Create()
    {
        var eventStreamResult = CreateEventStream();
        factoryAction?.Invoke(eventStreamResult);

        return eventStreamResult;
    }

    private Humidifier.Pinpoint.EventStream CreateEventStream()
    {
        var eventStreamResult = new Humidifier.Pinpoint.EventStream
        {
            GivenName = InputResourceName,
        };

        return eventStreamResult;
    }

} // End Of Class

public static class EventStreamFactoryExtensions
{
}
