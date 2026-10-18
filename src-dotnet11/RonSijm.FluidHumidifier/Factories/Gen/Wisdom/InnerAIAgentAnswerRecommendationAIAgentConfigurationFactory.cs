// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentAnswerRecommendationAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration Create()
    {
        var answerRecommendationAIAgentConfigurationResult = CreateAnswerRecommendationAIAgentConfiguration();
        factoryAction?.Invoke(answerRecommendationAIAgentConfigurationResult);

        return answerRecommendationAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration CreateAnswerRecommendationAIAgentConfiguration()
    {
        var answerRecommendationAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration();

        return answerRecommendationAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentAnswerRecommendationAIAgentConfigurationFactoryExtensions
{
}
