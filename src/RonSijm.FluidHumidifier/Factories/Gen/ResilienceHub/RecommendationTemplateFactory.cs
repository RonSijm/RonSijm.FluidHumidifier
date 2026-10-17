// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class RecommendationTemplateFactory(string resourceName = null, Action<Humidifier.ResilienceHub.RecommendationTemplate> factoryAction = null) : ResourceFactory<Humidifier.ResilienceHub.RecommendationTemplate>(resourceName)
{

    protected override Humidifier.ResilienceHub.RecommendationTemplate Create()
    {
        var recommendationTemplateResult = CreateRecommendationTemplate();
        factoryAction?.Invoke(recommendationTemplateResult);

        return recommendationTemplateResult;
    }

    private Humidifier.ResilienceHub.RecommendationTemplate CreateRecommendationTemplate()
    {
        var recommendationTemplateResult = new Humidifier.ResilienceHub.RecommendationTemplate
        {
            GivenName = InputResourceName,
        };

        return recommendationTemplateResult;
    }

} // End Of Class

public static class RecommendationTemplateFactoryExtensions
{
}
