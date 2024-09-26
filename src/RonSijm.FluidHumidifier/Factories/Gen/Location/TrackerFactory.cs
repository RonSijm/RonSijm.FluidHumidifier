// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class TrackerFactory(string resourceName = null, Action<Humidifier.Location.Tracker> factoryAction = null) : ResourceFactory<Humidifier.Location.Tracker>(resourceName)
{

    protected override Humidifier.Location.Tracker Create()
    {
        var trackerResult = CreateTracker();
        factoryAction?.Invoke(trackerResult);

        return trackerResult;
    }

    private Humidifier.Location.Tracker CreateTracker()
    {
        var trackerResult = new Humidifier.Location.Tracker
        {
            GivenName = InputResourceName,
        };

        return trackerResult;
    }

} // End Of Class

public static class TrackerFactoryExtensions
{
}
