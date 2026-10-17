// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerTriggerScheduleFactory(Action<Humidifier.DevOpsAgent.TriggerTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.TriggerTypes.Schedule>
{

    protected override Humidifier.DevOpsAgent.TriggerTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.DevOpsAgent.TriggerTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.DevOpsAgent.TriggerTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerTriggerScheduleFactoryExtensions
{
}
