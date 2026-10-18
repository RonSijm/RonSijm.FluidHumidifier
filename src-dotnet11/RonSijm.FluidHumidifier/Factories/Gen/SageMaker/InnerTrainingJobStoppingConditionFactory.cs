// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobStoppingConditionFactory(Action<Humidifier.SageMaker.TrainingJobTypes.StoppingCondition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.StoppingCondition>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.StoppingCondition Create()
    {
        var stoppingConditionResult = CreateStoppingCondition();
        factoryAction?.Invoke(stoppingConditionResult);

        return stoppingConditionResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.StoppingCondition CreateStoppingCondition()
    {
        var stoppingConditionResult = new Humidifier.SageMaker.TrainingJobTypes.StoppingCondition();

        return stoppingConditionResult;
    }

} // End Of Class

public static class InnerTrainingJobStoppingConditionFactoryExtensions
{
}
