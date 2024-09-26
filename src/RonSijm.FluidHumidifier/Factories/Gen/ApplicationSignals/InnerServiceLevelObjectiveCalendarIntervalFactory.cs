// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveCalendarIntervalFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CalendarInterval> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CalendarInterval>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CalendarInterval Create()
    {
        var calendarIntervalResult = CreateCalendarInterval();
        factoryAction?.Invoke(calendarIntervalResult);

        return calendarIntervalResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CalendarInterval CreateCalendarInterval()
    {
        var calendarIntervalResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CalendarInterval();

        return calendarIntervalResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveCalendarIntervalFactoryExtensions
{
}
