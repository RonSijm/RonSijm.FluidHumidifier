// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig>
{

    internal InnerEvaluatorEvaluatorModelConfigFactory ModelConfigFactory { get; set; }

    internal InnerEvaluatorRatingScaleFactory RatingScaleFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig Create()
    {
        var llmAsAJudgeEvaluatorConfigResult = CreateLlmAsAJudgeEvaluatorConfig();
        factoryAction?.Invoke(llmAsAJudgeEvaluatorConfigResult);

        return llmAsAJudgeEvaluatorConfigResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig CreateLlmAsAJudgeEvaluatorConfig()
    {
        var llmAsAJudgeEvaluatorConfigResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig();

        return llmAsAJudgeEvaluatorConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig result)
    {
        base.CreateChildren(result);

        result.ModelConfig ??= ModelConfigFactory?.Build();
        result.RatingScale ??= RatingScaleFactory?.Build();
    }

} // End Of Class

public static class InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactoryExtensions
{
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig(this InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null)
    {
        parentFactory.ModelConfigFactory = new InnerEvaluatorEvaluatorModelConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelConfigFactory);
    }

    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorRatingScaleFactory> WithRatingScale(this InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null)
    {
        parentFactory.RatingScaleFactory = new InnerEvaluatorRatingScaleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RatingScaleFactory);
    }

    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2>(this CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, WithRatingScale(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, WithRatingScale(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2>(this CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3, T4, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3, T4>(this CombinedResult<InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3, T4, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3, T4, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T4, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory, InnerEvaluatorRatingScaleFactory> WithRatingScale<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluatorLlmAsAJudgeEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRatingScale(combinedResult.T5, subFactoryAction).T2);
}
