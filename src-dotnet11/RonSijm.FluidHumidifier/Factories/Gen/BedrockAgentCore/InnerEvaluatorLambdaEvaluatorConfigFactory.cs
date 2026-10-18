// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorLambdaEvaluatorConfigFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig>
{

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig Create()
    {
        var lambdaEvaluatorConfigResult = CreateLambdaEvaluatorConfig();
        factoryAction?.Invoke(lambdaEvaluatorConfigResult);

        return lambdaEvaluatorConfigResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig CreateLambdaEvaluatorConfig()
    {
        var lambdaEvaluatorConfigResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig();

        return lambdaEvaluatorConfigResult;
    }

} // End Of Class

public static class InnerEvaluatorLambdaEvaluatorConfigFactoryExtensions
{
}
