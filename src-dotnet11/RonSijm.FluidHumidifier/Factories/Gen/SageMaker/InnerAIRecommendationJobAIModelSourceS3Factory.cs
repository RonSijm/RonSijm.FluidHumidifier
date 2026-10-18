// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAIModelSourceS3Factory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3>
{

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3 Create()
    {
        var aIModelSourceS3Result = CreateAIModelSourceS3();
        factoryAction?.Invoke(aIModelSourceS3Result);

        return aIModelSourceS3Result;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3 CreateAIModelSourceS3()
    {
        var aIModelSourceS3Result = new Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3();

        return aIModelSourceS3Result;
    }

} // End Of Class

public static class InnerAIRecommendationJobAIModelSourceS3FactoryExtensions
{
}
