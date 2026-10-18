// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorReasoningConfigurationFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration>
{

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration Create()
    {
        var reasoningConfigurationResult = CreateReasoningConfiguration();
        factoryAction?.Invoke(reasoningConfigurationResult);

        return reasoningConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration CreateReasoningConfiguration()
    {
        var reasoningConfigurationResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration();

        return reasoningConfigurationResult;
    }

} // End Of Class

public static class InnerEvaluatorReasoningConfigurationFactoryExtensions
{
}
