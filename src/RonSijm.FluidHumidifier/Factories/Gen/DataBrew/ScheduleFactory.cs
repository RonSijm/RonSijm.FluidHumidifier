// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class ScheduleFactory(string resourceName = null, Action<Humidifier.DataBrew.Schedule> factoryAction = null) : ResourceFactory<Humidifier.DataBrew.Schedule>(resourceName)
{

    protected override Humidifier.DataBrew.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.DataBrew.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.DataBrew.Schedule
        {
            GivenName = InputResourceName,
        };

        return scheduleResult;
    }

} // End Of Class

public static class ScheduleFactoryExtensions
{
}
