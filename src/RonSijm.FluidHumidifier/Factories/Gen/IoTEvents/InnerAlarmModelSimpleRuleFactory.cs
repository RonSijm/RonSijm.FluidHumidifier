// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerAlarmModelSimpleRuleFactory(Action<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.AlarmModelTypes.SimpleRule>
{

    protected override Humidifier.IoTEvents.AlarmModelTypes.SimpleRule Create()
    {
        var simpleRuleResult = CreateSimpleRule();
        factoryAction?.Invoke(simpleRuleResult);

        return simpleRuleResult;
    }

    private Humidifier.IoTEvents.AlarmModelTypes.SimpleRule CreateSimpleRule()
    {
        var simpleRuleResult = new Humidifier.IoTEvents.AlarmModelTypes.SimpleRule();

        return simpleRuleResult;
    }

} // End Of Class

public static class InnerAlarmModelSimpleRuleFactoryExtensions
{
}
