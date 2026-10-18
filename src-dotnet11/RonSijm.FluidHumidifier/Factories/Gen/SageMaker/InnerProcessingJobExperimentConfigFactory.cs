// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobExperimentConfigFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig Create()
    {
        var experimentConfigResult = CreateExperimentConfig();
        factoryAction?.Invoke(experimentConfigResult);

        return experimentConfigResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig CreateExperimentConfig()
    {
        var experimentConfigResult = new Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig();

        return experimentConfigResult;
    }

} // End Of Class

public static class InnerProcessingJobExperimentConfigFactoryExtensions
{
}
