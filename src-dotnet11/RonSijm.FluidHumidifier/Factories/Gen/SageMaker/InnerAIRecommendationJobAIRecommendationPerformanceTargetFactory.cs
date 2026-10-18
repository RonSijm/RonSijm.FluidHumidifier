// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAIRecommendationPerformanceTargetFactory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget>
{

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget Create()
    {
        var aIRecommendationPerformanceTargetResult = CreateAIRecommendationPerformanceTarget();
        factoryAction?.Invoke(aIRecommendationPerformanceTargetResult);

        return aIRecommendationPerformanceTargetResult;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget CreateAIRecommendationPerformanceTarget()
    {
        var aIRecommendationPerformanceTargetResult = new Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget();

        return aIRecommendationPerformanceTargetResult;
    }

} // End Of Class

public static class InnerAIRecommendationJobAIRecommendationPerformanceTargetFactoryExtensions
{
}
