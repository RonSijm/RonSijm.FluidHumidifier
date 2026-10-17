// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class EventBusPolicyFactory(string resourceName = null, Action<Humidifier.Events.EventBusPolicy> factoryAction = null) : ResourceFactory<Humidifier.Events.EventBusPolicy>(resourceName)
{

    protected override Humidifier.Events.EventBusPolicy Create()
    {
        var eventBusPolicyResult = CreateEventBusPolicy();
        factoryAction?.Invoke(eventBusPolicyResult);

        return eventBusPolicyResult;
    }

    private Humidifier.Events.EventBusPolicy CreateEventBusPolicy()
    {
        var eventBusPolicyResult = new Humidifier.Events.EventBusPolicy
        {
            GivenName = InputResourceName,
        };

        return eventBusPolicyResult;
    }

} // End Of Class

public static class EventBusPolicyFactoryExtensions
{
}
