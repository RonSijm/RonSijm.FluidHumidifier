// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerTaskTaskScheduleFactory(Action<Humidifier.DataSync.TaskTypes.TaskSchedule> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.TaskTypes.TaskSchedule>
{

    protected override Humidifier.DataSync.TaskTypes.TaskSchedule Create()
    {
        var taskScheduleResult = CreateTaskSchedule();
        factoryAction?.Invoke(taskScheduleResult);

        return taskScheduleResult;
    }

    private Humidifier.DataSync.TaskTypes.TaskSchedule CreateTaskSchedule()
    {
        var taskScheduleResult = new Humidifier.DataSync.TaskTypes.TaskSchedule();

        return taskScheduleResult;
    }

} // End Of Class

public static class InnerTaskTaskScheduleFactoryExtensions
{
}
