// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleScheduleConfigFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.ScheduleConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.ScheduleConfig>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.ScheduleConfig Create()
    {
        var scheduleConfigResult = CreateScheduleConfig();
        factoryAction?.Invoke(scheduleConfigResult);

        return scheduleConfigResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.ScheduleConfig CreateScheduleConfig()
    {
        var scheduleConfigResult = new Humidifier.SageMaker.MonitoringScheduleTypes.ScheduleConfig();

        return scheduleConfigResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleScheduleConfigFactoryExtensions
{
}
