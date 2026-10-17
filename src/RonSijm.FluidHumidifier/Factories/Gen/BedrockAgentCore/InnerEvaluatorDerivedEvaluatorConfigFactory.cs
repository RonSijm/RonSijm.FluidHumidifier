// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorDerivedEvaluatorConfigFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig>
{

    internal InnerEvaluatorEvaluatorModelConfigFactory ModelConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig Create()
    {
        var derivedEvaluatorConfigResult = CreateDerivedEvaluatorConfig();
        factoryAction?.Invoke(derivedEvaluatorConfigResult);

        return derivedEvaluatorConfigResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig CreateDerivedEvaluatorConfig()
    {
        var derivedEvaluatorConfigResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig();

        return derivedEvaluatorConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig result)
    {
        base.CreateChildren(result);

        result.ModelConfig ??= ModelConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEvaluatorDerivedEvaluatorConfigFactoryExtensions
{
    public static CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig(this InnerEvaluatorDerivedEvaluatorConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null)
    {
        parentFactory.ModelConfigFactory = new InnerEvaluatorEvaluatorModelConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelConfigFactory);
    }

    public static CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1>(this CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1>(this CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, T2, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2>(this CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, T2, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2>(this CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorDerivedEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2>(this CombinedResult<T1, T2, InnerEvaluatorDerivedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, T2, T3, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, T2, T3, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorDerivedEvaluatorConfigFactory, T3, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluatorDerivedEvaluatorConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorDerivedEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluatorDerivedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, T2, T3, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<InnerEvaluatorDerivedEvaluatorConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, T2, T3, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluatorDerivedEvaluatorConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorDerivedEvaluatorConfigFactory, T3, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluatorDerivedEvaluatorConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorDerivedEvaluatorConfigFactory, T4, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluatorDerivedEvaluatorConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluatorDerivedEvaluatorConfigFactory, InnerEvaluatorEvaluatorModelConfigFactory> WithModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluatorDerivedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelConfig(combinedResult.T5, subFactoryAction).T2);
}
