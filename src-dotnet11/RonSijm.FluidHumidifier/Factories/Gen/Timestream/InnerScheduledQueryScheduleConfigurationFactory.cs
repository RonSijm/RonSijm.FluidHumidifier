// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQueryScheduleConfigurationFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration>
{

    protected override Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration Create()
    {
        var scheduleConfigurationResult = CreateScheduleConfiguration();
        factoryAction?.Invoke(scheduleConfigurationResult);

        return scheduleConfigurationResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration CreateScheduleConfiguration()
    {
        var scheduleConfigurationResult = new Humidifier.Timestream.ScheduledQueryTypes.ScheduleConfiguration();

        return scheduleConfigurationResult;
    }

} // End Of Class

public static class InnerScheduledQueryScheduleConfigurationFactoryExtensions
{
}
