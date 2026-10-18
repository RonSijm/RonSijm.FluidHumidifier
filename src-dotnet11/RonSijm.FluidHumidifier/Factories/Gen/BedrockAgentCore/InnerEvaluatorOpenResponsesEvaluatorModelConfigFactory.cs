// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig>
{

    internal InnerEvaluatorReasoningConfigurationFactory ReasoningFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig Create()
    {
        var openResponsesEvaluatorModelConfigResult = CreateOpenResponsesEvaluatorModelConfig();
        factoryAction?.Invoke(openResponsesEvaluatorModelConfigResult);

        return openResponsesEvaluatorModelConfigResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig CreateOpenResponsesEvaluatorModelConfig()
    {
        var openResponsesEvaluatorModelConfigResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig();

        return openResponsesEvaluatorModelConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig result)
    {
        base.CreateChildren(result);

        result.Reasoning ??= ReasoningFactory?.Build();
    }

} // End Of Class

public static class InnerEvaluatorOpenResponsesEvaluatorModelConfigFactoryExtensions
{
    public static CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, InnerEvaluatorReasoningConfigurationFactory> WithReasoning(this InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null)
    {
        parentFactory.ReasoningFactory = new InnerEvaluatorReasoningConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReasoningFactory);
    }

    public static CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1>(this CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReasoning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1>(this CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithReasoning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, T2, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2>(this CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T2, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2>(this CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2>(this CombinedResult<T1, T2, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, T2, T3, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3>(this CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T2, T3, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3>(this CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T3, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, T2, T3, T4, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3, T4>(this CombinedResult<InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T2, T3, T4, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T3, T4, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T4, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory, InnerEvaluatorReasoningConfigurationFactory> WithReasoning<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluatorOpenResponsesEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReasoning(combinedResult.T5, subFactoryAction).T2);
}
