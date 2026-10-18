// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCM;

public class InnerScheduledReportSchedulePeriodFactory(Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> factoryAction = null) : SubResourceFactory<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod>
{

    protected override Humidifier.BCM.ScheduledReportTypes.SchedulePeriod Create()
    {
        var schedulePeriodResult = CreateSchedulePeriod();
        factoryAction?.Invoke(schedulePeriodResult);

        return schedulePeriodResult;
    }

    private Humidifier.BCM.ScheduledReportTypes.SchedulePeriod CreateSchedulePeriod()
    {
        var schedulePeriodResult = new Humidifier.BCM.ScheduledReportTypes.SchedulePeriod();

        return schedulePeriodResult;
    }

} // End Of Class

public static class InnerScheduledReportSchedulePeriodFactoryExtensions
{
}
