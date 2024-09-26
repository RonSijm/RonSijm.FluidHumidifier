// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class EventSubscriptionFactory(string resourceName = null, Action<Humidifier.DMS.EventSubscription> factoryAction = null) : ResourceFactory<Humidifier.DMS.EventSubscription>(resourceName)
{

    protected override Humidifier.DMS.EventSubscription Create()
    {
        var eventSubscriptionResult = CreateEventSubscription();
        factoryAction?.Invoke(eventSubscriptionResult);

        return eventSubscriptionResult;
    }

    private Humidifier.DMS.EventSubscription CreateEventSubscription()
    {
        var eventSubscriptionResult = new Humidifier.DMS.EventSubscription
        {
            GivenName = InputResourceName,
        };

        return eventSubscriptionResult;
    }

} // End Of Class

public static class EventSubscriptionFactoryExtensions
{
}
