// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobCheckpointConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.CheckpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.CheckpointConfig>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.CheckpointConfig Create()
    {
        var checkpointConfigResult = CreateCheckpointConfig();
        factoryAction?.Invoke(checkpointConfigResult);

        return checkpointConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.CheckpointConfig CreateCheckpointConfig()
    {
        var checkpointConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.CheckpointConfig();

        return checkpointConfigResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobCheckpointConfigFactoryExtensions
{
}
