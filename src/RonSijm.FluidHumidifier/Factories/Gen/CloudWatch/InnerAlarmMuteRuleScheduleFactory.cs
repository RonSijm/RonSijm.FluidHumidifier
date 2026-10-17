// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmMuteRuleScheduleFactory(Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule>
{

    protected override Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerAlarmMuteRuleScheduleFactoryExtensions
{
}
