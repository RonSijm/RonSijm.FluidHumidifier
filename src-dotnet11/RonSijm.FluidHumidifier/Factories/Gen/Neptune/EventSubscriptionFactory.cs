// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class EventSubscriptionFactory(string resourceName = null, Action<Humidifier.Neptune.EventSubscription> factoryAction = null) : ResourceFactory<Humidifier.Neptune.EventSubscription>(resourceName)
{

    protected override Humidifier.Neptune.EventSubscription Create()
    {
        var eventSubscriptionResult = CreateEventSubscription();
        factoryAction?.Invoke(eventSubscriptionResult);

        return eventSubscriptionResult;
    }

    private Humidifier.Neptune.EventSubscription CreateEventSubscription()
    {
        var eventSubscriptionResult = new Humidifier.Neptune.EventSubscription
        {
            GivenName = InputResourceName,
        };

        return eventSubscriptionResult;
    }

} // End Of Class

public static class EventSubscriptionFactoryExtensions
{
}
