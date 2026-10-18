// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorBedrockEvaluatorModelConfigFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig>
{

    internal InnerEvaluatorInferenceConfigurationFactory InferenceConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig Create()
    {
        var bedrockEvaluatorModelConfigResult = CreateBedrockEvaluatorModelConfig();
        factoryAction?.Invoke(bedrockEvaluatorModelConfigResult);

        return bedrockEvaluatorModelConfigResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig CreateBedrockEvaluatorModelConfig()
    {
        var bedrockEvaluatorModelConfigResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig();

        return bedrockEvaluatorModelConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig result)
    {
        base.CreateChildren(result);

        result.InferenceConfig ??= InferenceConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEvaluatorBedrockEvaluatorModelConfigFactoryExtensions
{
    public static CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig(this InnerEvaluatorBedrockEvaluatorModelConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null)
    {
        parentFactory.InferenceConfigFactory = new InnerEvaluatorInferenceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InferenceConfigFactory);
    }

    public static CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1>(this CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1>(this CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, T2, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2>(this CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T2, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2>(this CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorBedrockEvaluatorModelConfigFactory, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2>(this CombinedResult<T1, T2, InnerEvaluatorBedrockEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, T2, T3, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3>(this CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T2, T3, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3>(this CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T3, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorBedrockEvaluatorModelConfigFactory, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluatorBedrockEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, T2, T3, T4, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3, T4>(this CombinedResult<InnerEvaluatorBedrockEvaluatorModelConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T2, T3, T4, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T3, T4, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T4, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluatorBedrockEvaluatorModelConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluatorBedrockEvaluatorModelConfigFactory, InnerEvaluatorInferenceConfigurationFactory> WithInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluatorBedrockEvaluatorModelConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceConfig(combinedResult.T5, subFactoryAction).T2);
}
