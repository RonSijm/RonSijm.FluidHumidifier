// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAIRecommendationInferenceSpecificationFactory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification>
{

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification Create()
    {
        var aIRecommendationInferenceSpecificationResult = CreateAIRecommendationInferenceSpecification();
        factoryAction?.Invoke(aIRecommendationInferenceSpecificationResult);

        return aIRecommendationInferenceSpecificationResult;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification CreateAIRecommendationInferenceSpecification()
    {
        var aIRecommendationInferenceSpecificationResult = new Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification();

        return aIRecommendationInferenceSpecificationResult;
    }

} // End Of Class

public static class InnerAIRecommendationJobAIRecommendationInferenceSpecificationFactoryExtensions
{
}
