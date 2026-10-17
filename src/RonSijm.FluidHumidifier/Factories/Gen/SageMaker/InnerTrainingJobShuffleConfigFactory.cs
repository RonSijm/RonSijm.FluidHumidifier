// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobShuffleConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig Create()
    {
        var shuffleConfigResult = CreateShuffleConfig();
        factoryAction?.Invoke(shuffleConfigResult);

        return shuffleConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig CreateShuffleConfig()
    {
        var shuffleConfigResult = new Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig();

        return shuffleConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobShuffleConfigFactoryExtensions
{
}
