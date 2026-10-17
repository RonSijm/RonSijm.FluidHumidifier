// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobOutputDataConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.OutputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.OutputDataConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.OutputDataConfig Create()
    {
        var outputDataConfigResult = CreateOutputDataConfig();
        factoryAction?.Invoke(outputDataConfigResult);

        return outputDataConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.OutputDataConfig CreateOutputDataConfig()
    {
        var outputDataConfigResult = new Humidifier.SageMaker.TrainingJobTypes.OutputDataConfig();

        return outputDataConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobOutputDataConfigFactoryExtensions
{
}
