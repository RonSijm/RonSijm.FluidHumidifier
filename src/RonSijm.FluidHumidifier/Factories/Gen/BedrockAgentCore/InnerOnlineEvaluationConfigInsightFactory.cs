// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigInsightFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight Create()
    {
        var insightResult = CreateInsight();
        factoryAction?.Invoke(insightResult);

        return insightResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight CreateInsight()
    {
        var insightResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight();

        return insightResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigInsightFactoryExtensions
{
}
