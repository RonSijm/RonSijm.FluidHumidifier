// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ComputeOptimizer;

public class InnerAutomationRuleScheduleFactory(Action<Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule>
{

    protected override Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerAutomationRuleScheduleFactoryExtensions
{
}
