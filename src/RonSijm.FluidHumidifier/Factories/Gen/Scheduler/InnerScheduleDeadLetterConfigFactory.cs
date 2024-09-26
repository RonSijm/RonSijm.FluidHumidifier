// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class InnerScheduleDeadLetterConfigFactory(Action<Humidifier.Scheduler.ScheduleTypes.DeadLetterConfig> factoryAction = null) : SubResourceFactory<Humidifier.Scheduler.ScheduleTypes.DeadLetterConfig>
{

    protected override Humidifier.Scheduler.ScheduleTypes.DeadLetterConfig Create()
    {
        var deadLetterConfigResult = CreateDeadLetterConfig();
        factoryAction?.Invoke(deadLetterConfigResult);

        return deadLetterConfigResult;
    }

    private Humidifier.Scheduler.ScheduleTypes.DeadLetterConfig CreateDeadLetterConfig()
    {
        var deadLetterConfigResult = new Humidifier.Scheduler.ScheduleTypes.DeadLetterConfig();

        return deadLetterConfigResult;
    }

} // End Of Class

public static class InnerScheduleDeadLetterConfigFactoryExtensions
{
}
