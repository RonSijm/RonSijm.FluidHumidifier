// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobTrainingRepositoryAuthConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig Create()
    {
        var trainingRepositoryAuthConfigResult = CreateTrainingRepositoryAuthConfig();
        factoryAction?.Invoke(trainingRepositoryAuthConfigResult);

        return trainingRepositoryAuthConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig CreateTrainingRepositoryAuthConfig()
    {
        var trainingRepositoryAuthConfigResult = new Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig();

        return trainingRepositoryAuthConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobTrainingRepositoryAuthConfigFactoryExtensions
{
}
