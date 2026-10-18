// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerDatasetScheduleFactory(Action<Humidifier.IoTAnalytics.DatasetTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.DatasetTypes.Schedule>
{

    protected override Humidifier.IoTAnalytics.DatasetTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.IoTAnalytics.DatasetTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.IoTAnalytics.DatasetTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerDatasetScheduleFactoryExtensions
{
}
