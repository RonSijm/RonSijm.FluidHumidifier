// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class EventSubscriptionFactory(string resourceName = null, Action<Humidifier.Redshift.EventSubscription> factoryAction = null) : ResourceFactory<Humidifier.Redshift.EventSubscription>(resourceName)
{

    protected override Humidifier.Redshift.EventSubscription Create()
    {
        var eventSubscriptionResult = CreateEventSubscription();
        factoryAction?.Invoke(eventSubscriptionResult);

        return eventSubscriptionResult;
    }

    private Humidifier.Redshift.EventSubscription CreateEventSubscription()
    {
        var eventSubscriptionResult = new Humidifier.Redshift.EventSubscription
        {
            GivenName = InputResourceName,
        };

        return eventSubscriptionResult;
    }

} // End Of Class

public static class EventSubscriptionFactoryExtensions
{
}
