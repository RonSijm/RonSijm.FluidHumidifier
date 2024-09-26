// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerAlarmModelAlarmEventActionsFactory(Action<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions>
{

    protected override Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions Create()
    {
        var alarmEventActionsResult = CreateAlarmEventActions();
        factoryAction?.Invoke(alarmEventActionsResult);

        return alarmEventActionsResult;
    }

    private Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions CreateAlarmEventActions()
    {
        var alarmEventActionsResult = new Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions();

        return alarmEventActionsResult;
    }

} // End Of Class

public static class InnerAlarmModelAlarmEventActionsFactoryExtensions
{
}
