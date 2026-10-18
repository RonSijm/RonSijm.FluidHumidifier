// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobJobStoppingConditionFactory(Action<Humidifier.Braket.JobTypes.JobStoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.JobStoppingCondition>
{

    protected override Humidifier.Braket.JobTypes.JobStoppingCondition Create()
    {
        var jobStoppingConditionResult = CreateJobStoppingCondition();
        factoryAction?.Invoke(jobStoppingConditionResult);

        return jobStoppingConditionResult;
    }

    private Humidifier.Braket.JobTypes.JobStoppingCondition CreateJobStoppingCondition()
    {
        var jobStoppingConditionResult = new Humidifier.Braket.JobTypes.JobStoppingCondition();

        return jobStoppingConditionResult;
    }

} // End Of Class

public static class InnerJobJobStoppingConditionFactoryExtensions
{
}
