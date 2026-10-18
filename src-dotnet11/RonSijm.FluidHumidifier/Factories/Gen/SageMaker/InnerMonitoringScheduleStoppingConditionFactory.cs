// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleStoppingConditionFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.MonitoringScheduleTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleStoppingConditionFactoryExtensions
{
}
