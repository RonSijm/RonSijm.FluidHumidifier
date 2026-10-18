// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleFlexibleTimeWindowFactory(Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow>
{

    protected override Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow Create()
    {
        var flexibleTimeWindowResult = CreateFlexibleTimeWindow();
        factoryAction?.Invoke(flexibleTimeWindowResult);

        return flexibleTimeWindowResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow CreateFlexibleTimeWindow()
    {
        var flexibleTimeWindowResult = new Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow();

        return flexibleTimeWindowResult;
    }

} // End Of Class

public static class InnerScheduleFlexibleTimeWindowFactoryExtensions
{
}
