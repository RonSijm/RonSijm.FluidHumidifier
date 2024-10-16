// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class EventSubscriptionFactory(string resourceName = null, Action<Humidifier.RDS.EventSubscription> factoryAction = null) : ResourceFactory<Humidifier.RDS.EventSubscription>(resourceName)
{

    protected override Humidifier.RDS.EventSubscription Create()
    {
        var eventSubscriptionResult = CreateEventSubscription();
        factoryAction?.Invoke(eventSubscriptionResult);

        return eventSubscriptionResult;
    }

    private Humidifier.RDS.EventSubscription CreateEventSubscription()
    {
        var eventSubscriptionResult = new Humidifier.RDS.EventSubscription
        {
            GivenName = InputResourceName,
        };

        return eventSubscriptionResult;
    }

} // End Of Class

public static class EventSubscriptionFactoryExtensions
{
}
