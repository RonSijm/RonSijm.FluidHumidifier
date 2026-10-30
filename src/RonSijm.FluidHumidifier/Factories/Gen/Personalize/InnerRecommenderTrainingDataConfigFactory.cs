// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerRecommenderTrainingDataConfigFactory(Action<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig>
{

    protected override Humidifier.Personalize.RecommenderTypes.TrainingDataConfig Create()
    {
        var trainingDataConfigResult = CreateTrainingDataConfig();
        factoryAction?.Invoke(trainingDataConfigResult);

        return trainingDataConfigResult;
    }

    private Humidifier.Personalize.RecommenderTypes.TrainingDataConfig CreateTrainingDataConfig()
    {
        var trainingDataConfigResult = new Humidifier.Personalize.RecommenderTypes.TrainingDataConfig();

        return trainingDataConfigResult;
    }

} // End Of Class

public static class InnerRecommenderTrainingDataConfigFactoryExtensions
{
}
