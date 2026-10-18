// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class EventTrackerFactory(string resourceName = null, Action<Humidifier.Personalize.EventTracker> factoryAction = null) : ResourceFactory<Humidifier.Personalize.EventTracker>(resourceName)
{

    protected override Humidifier.Personalize.EventTracker Create()
    {
        var eventTrackerResult = CreateEventTracker();
        factoryAction?.Invoke(eventTrackerResult);

        return eventTrackerResult;
    }

    private Humidifier.Personalize.EventTracker CreateEventTracker()
    {
        var eventTrackerResult = new Humidifier.Personalize.EventTracker
        {
            GivenName = InputResourceName,
        };

        return eventTrackerResult;
    }

} // End Of Class

public static class EventTrackerFactoryExtensions
{
}
