// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardTrainingEnvironmentFactory(Action<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment>
{

    protected override Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment Create()
    {
        var trainingEnvironmentResult = CreateTrainingEnvironment();
        factoryAction?.Invoke(trainingEnvironmentResult);

        return trainingEnvironmentResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment CreateTrainingEnvironment()
    {
        var trainingEnvironmentResult = new Humidifier.SageMaker.ModelCardTypes.TrainingEnvironment();

        return trainingEnvironmentResult;
    }

} // End Of Class

public static class InnerModelCardTrainingEnvironmentFactoryExtensions
{
}
