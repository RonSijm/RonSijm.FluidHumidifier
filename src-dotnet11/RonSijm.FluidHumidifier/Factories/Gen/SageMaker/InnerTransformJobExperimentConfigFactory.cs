// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobExperimentConfigFactory(Action<Humidifier.SageMaker.TransformJobTypes.ExperimentConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.ExperimentConfig>
{

    protected override Humidifier.SageMaker.TransformJobTypes.ExperimentConfig Create()
    {
        var experimentConfigResult = CreateExperimentConfig();
        factoryAction?.Invoke(experimentConfigResult);

        return experimentConfigResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.ExperimentConfig CreateExperimentConfig()
    {
        var experimentConfigResult = new Humidifier.SageMaker.TransformJobTypes.ExperimentConfig();

        return experimentConfigResult;
    }

} // End Of Class

public static class InnerTransformJobExperimentConfigFactoryExtensions
{
}
