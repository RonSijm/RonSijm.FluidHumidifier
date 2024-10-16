// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class EventSubscriptionFactory(string resourceName = null, Action<Humidifier.DocDB.EventSubscription> factoryAction = null) : ResourceFactory<Humidifier.DocDB.EventSubscription>(resourceName)
{

    protected override Humidifier.DocDB.EventSubscription Create()
    {
        var eventSubscriptionResult = CreateEventSubscription();
        factoryAction?.Invoke(eventSubscriptionResult);

        return eventSubscriptionResult;
    }

    private Humidifier.DocDB.EventSubscription CreateEventSubscription()
    {
        var eventSubscriptionResult = new Humidifier.DocDB.EventSubscription
        {
            GivenName = InputResourceName,
        };

        return eventSubscriptionResult;
    }

} // End Of Class

public static class EventSubscriptionFactoryExtensions
{
}
