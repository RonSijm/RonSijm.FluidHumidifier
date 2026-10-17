// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobExperimentConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.ExperimentConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.ExperimentConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.ExperimentConfig Create()
    {
        var experimentConfigResult = CreateExperimentConfig();
        factoryAction?.Invoke(experimentConfigResult);

        return experimentConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.ExperimentConfig CreateExperimentConfig()
    {
        var experimentConfigResult = new Humidifier.SageMaker.TrainingJobTypes.ExperimentConfig();

        return experimentConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobExperimentConfigFactoryExtensions
{
}
