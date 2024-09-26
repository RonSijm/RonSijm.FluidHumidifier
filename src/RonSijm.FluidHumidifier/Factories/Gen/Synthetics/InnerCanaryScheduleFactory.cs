// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryScheduleFactory(Action<Humidifier.Synthetics.CanaryTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.Schedule>
{

    protected override Humidifier.Synthetics.CanaryTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.Synthetics.CanaryTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.Synthetics.CanaryTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerCanaryScheduleFactoryExtensions
{
}
