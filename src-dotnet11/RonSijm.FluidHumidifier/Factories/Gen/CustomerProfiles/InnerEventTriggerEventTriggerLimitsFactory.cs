// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerEventTriggerEventTriggerLimitsFactory(Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits>
{

    protected override Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits Create()
    {
        var eventTriggerLimitsResult = CreateEventTriggerLimits();
        factoryAction?.Invoke(eventTriggerLimitsResult);

        return eventTriggerLimitsResult;
    }

    private Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits CreateEventTriggerLimits()
    {
        var eventTriggerLimitsResult = new Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits();

        return eventTriggerLimitsResult;
    }

} // End Of Class

public static class InnerEventTriggerEventTriggerLimitsFactoryExtensions
{
}
