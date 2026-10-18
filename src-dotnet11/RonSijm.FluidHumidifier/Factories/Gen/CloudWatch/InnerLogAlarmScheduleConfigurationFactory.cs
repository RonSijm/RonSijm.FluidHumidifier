// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerLogAlarmScheduleConfigurationFactory(Action<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration>
{

    protected override Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration Create()
    {
        var scheduleConfigurationResult = CreateScheduleConfiguration();
        factoryAction?.Invoke(scheduleConfigurationResult);

        return scheduleConfigurationResult;
    }

    private Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration CreateScheduleConfiguration()
    {
        var scheduleConfigurationResult = new Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration();

        return scheduleConfigurationResult;
    }

} // End Of Class

public static class InnerLogAlarmScheduleConfigurationFactoryExtensions
{
}
