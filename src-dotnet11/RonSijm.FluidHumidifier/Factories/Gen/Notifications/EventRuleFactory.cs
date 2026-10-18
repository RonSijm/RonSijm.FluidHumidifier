// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class EventRuleFactory(string resourceName = null, Action<Humidifier.Notifications.EventRule> factoryAction = null) : ResourceFactory<Humidifier.Notifications.EventRule>(resourceName)
{

    protected override Humidifier.Notifications.EventRule Create()
    {
        var eventRuleResult = CreateEventRule();
        factoryAction?.Invoke(eventRuleResult);

        return eventRuleResult;
    }

    private Humidifier.Notifications.EventRule CreateEventRule()
    {
        var eventRuleResult = new Humidifier.Notifications.EventRule
        {
            GivenName = InputResourceName,
        };

        return eventRuleResult;
    }

} // End Of Class

public static class EventRuleFactoryExtensions
{
}
