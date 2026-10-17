// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIRecommendationJobAICapacityReservationConfigFactory(Action<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig>
{

    protected override Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig Create()
    {
        var aICapacityReservationConfigResult = CreateAICapacityReservationConfig();
        factoryAction?.Invoke(aICapacityReservationConfigResult);

        return aICapacityReservationConfigResult;
    }

    private Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig CreateAICapacityReservationConfig()
    {
        var aICapacityReservationConfigResult = new Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig();

        return aICapacityReservationConfigResult;
    }

} // End Of Class

public static class InnerAIRecommendationJobAICapacityReservationConfigFactoryExtensions
{
}
