// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobStoppingConditionFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerProcessingJobStoppingConditionFactoryExtensions
{
}
