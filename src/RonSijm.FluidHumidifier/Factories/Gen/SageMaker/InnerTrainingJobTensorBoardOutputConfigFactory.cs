// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobTensorBoardOutputConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.TensorBoardOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.TensorBoardOutputConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.TensorBoardOutputConfig Create()
    {
        var tensorBoardOutputConfigResult = CreateTensorBoardOutputConfig();
        factoryAction?.Invoke(tensorBoardOutputConfigResult);

        return tensorBoardOutputConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.TensorBoardOutputConfig CreateTensorBoardOutputConfig()
    {
        var tensorBoardOutputConfigResult = new Humidifier.SageMaker.TrainingJobTypes.TensorBoardOutputConfig();

        return tensorBoardOutputConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobTensorBoardOutputConfigFactoryExtensions
{
}
