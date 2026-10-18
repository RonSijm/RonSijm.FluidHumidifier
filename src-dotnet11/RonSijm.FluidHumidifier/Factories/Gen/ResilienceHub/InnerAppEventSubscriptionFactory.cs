// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class InnerAppEventSubscriptionFactory(Action<Humidifier.ResilienceHub.AppTypes.EventSubscription> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHub.AppTypes.EventSubscription>
{

    protected override Humidifier.ResilienceHub.AppTypes.EventSubscription Create()
    {
        var eventSubscriptionResult = CreateEventSubscription();
        factoryAction?.Invoke(eventSubscriptionResult);

        return eventSubscriptionResult;
    }

    private Humidifier.ResilienceHub.AppTypes.EventSubscription CreateEventSubscription()
    {
        var eventSubscriptionResult = new Humidifier.ResilienceHub.AppTypes.EventSubscription();

        return eventSubscriptionResult;
    }

} // End Of Class

public static class InnerAppEventSubscriptionFactoryExtensions
{
}
