// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class ScheduleGroupFactory(string resourceName = null, Action<Humidifier.Scheduler.ScheduleGroup> factoryAction = null) : ResourceFactory<Humidifier.Scheduler.ScheduleGroup>(resourceName)
{

    protected override Humidifier.Scheduler.ScheduleGroup Create()
    {
        var scheduleGroupResult = CreateScheduleGroup();
        factoryAction?.Invoke(scheduleGroupResult);

        return scheduleGroupResult;
    }

    private Humidifier.Scheduler.ScheduleGroup CreateScheduleGroup()
    {
        var scheduleGroupResult = new Humidifier.Scheduler.ScheduleGroup
        {
            GivenName = InputResourceName,
        };

        return scheduleGroupResult;
    }

} // End Of Class

public static class ScheduleGroupFactoryExtensions
{
}
