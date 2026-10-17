// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobCheckpointConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.CheckpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.CheckpointConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.CheckpointConfig Create()
    {
        var checkpointConfigResult = CreateCheckpointConfig();
        factoryAction?.Invoke(checkpointConfigResult);

        return checkpointConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.CheckpointConfig CreateCheckpointConfig()
    {
        var checkpointConfigResult = new Humidifier.SageMaker.TrainingJobTypes.CheckpointConfig();

        return checkpointConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobCheckpointConfigFactoryExtensions
{
}
