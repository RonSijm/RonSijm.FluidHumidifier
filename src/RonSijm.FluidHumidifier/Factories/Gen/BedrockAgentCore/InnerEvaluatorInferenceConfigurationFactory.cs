// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorInferenceConfigurationFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration>
{

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration Create()
    {
        var inferenceConfigurationResult = CreateInferenceConfiguration();
        factoryAction?.Invoke(inferenceConfigurationResult);

        return inferenceConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration CreateInferenceConfiguration()
    {
        var inferenceConfigurationResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration();

        return inferenceConfigurationResult;
    }

} // End Of Class

public static class InnerEvaluatorInferenceConfigurationFactoryExtensions
{
}
