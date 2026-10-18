// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAIRecommendationOutputConfigFactory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig>
{

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig Create()
    {
        var aIRecommendationOutputConfigResult = CreateAIRecommendationOutputConfig();
        factoryAction?.Invoke(aIRecommendationOutputConfigResult);

        return aIRecommendationOutputConfigResult;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig CreateAIRecommendationOutputConfig()
    {
        var aIRecommendationOutputConfigResult = new Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig();

        return aIRecommendationOutputConfigResult;
    }

} // End Of Class

public static class InnerAIRecommendationJobAIRecommendationOutputConfigFactoryExtensions
{
}
