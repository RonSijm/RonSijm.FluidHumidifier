// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class TrackerConsumerFactory(string resourceName = null, Action<Humidifier.Location.TrackerConsumer> factoryAction = null) : ResourceFactory<Humidifier.Location.TrackerConsumer>(resourceName)
{

    protected override Humidifier.Location.TrackerConsumer Create()
    {
        var trackerConsumerResult = CreateTrackerConsumer();
        factoryAction?.Invoke(trackerConsumerResult);

        return trackerConsumerResult;
    }

    private Humidifier.Location.TrackerConsumer CreateTrackerConsumer()
    {
        var trackerConsumerResult = new Humidifier.Location.TrackerConsumer
        {
            GivenName = InputResourceName,
        };

        return trackerConsumerResult;
    }

} // End Of Class

public static class TrackerConsumerFactoryExtensions
{
}
