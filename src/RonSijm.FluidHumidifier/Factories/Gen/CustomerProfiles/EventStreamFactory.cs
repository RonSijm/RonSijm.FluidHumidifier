// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class EventStreamFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.EventStream> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.EventStream>(resourceName)
{

    protected override Humidifier.CustomerProfiles.EventStream Create()
    {
        var eventStreamResult = CreateEventStream();
        factoryAction?.Invoke(eventStreamResult);

        return eventStreamResult;
    }

    private Humidifier.CustomerProfiles.EventStream CreateEventStream()
    {
        var eventStreamResult = new Humidifier.CustomerProfiles.EventStream
        {
            GivenName = InputResourceName,
        };

        return eventStreamResult;
    }

} // End Of Class

public static class EventStreamFactoryExtensions
{
}
