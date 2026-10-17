// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerEventTriggerEventTriggerConditionFactory(Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition>
{

    protected override Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition Create()
    {
        var eventTriggerConditionResult = CreateEventTriggerCondition();
        factoryAction?.Invoke(eventTriggerConditionResult);

        return eventTriggerConditionResult;
    }

    private Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition CreateEventTriggerCondition()
    {
        var eventTriggerConditionResult = new Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition();

        return eventTriggerConditionResult;
    }

} // End Of Class

public static class InnerEventTriggerEventTriggerConditionFactoryExtensions
{
}
