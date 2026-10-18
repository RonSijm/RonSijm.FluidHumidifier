// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class TrainingPlanFactory(string resourceName = null, Action<Humidifier.SageMaker.TrainingPlan> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.TrainingPlan>(resourceName)
{

    protected override Humidifier.SageMaker.TrainingPlan Create()
    {
        var trainingPlanResult = CreateTrainingPlan();
        factoryAction?.Invoke(trainingPlanResult);

        return trainingPlanResult;
    }

    private Humidifier.SageMaker.TrainingPlan CreateTrainingPlan()
    {
        var trainingPlanResult = new Humidifier.SageMaker.TrainingPlan
        {
            GivenName = InputResourceName,
        };

        return trainingPlanResult;
    }

} // End Of Class

public static class TrainingPlanFactoryExtensions
{
}
