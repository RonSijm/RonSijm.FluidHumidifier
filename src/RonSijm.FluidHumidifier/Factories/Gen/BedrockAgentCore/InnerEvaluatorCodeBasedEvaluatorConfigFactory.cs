// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerEvaluatorCodeBasedEvaluatorConfigFactory(Action<Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig>
{

    internal InnerEvaluatorLambdaEvaluatorConfigFactory LambdaConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig Create()
    {
        var codeBasedEvaluatorConfigResult = CreateCodeBasedEvaluatorConfig();
        factoryAction?.Invoke(codeBasedEvaluatorConfigResult);

        return codeBasedEvaluatorConfigResult;
    }

    private Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig CreateCodeBasedEvaluatorConfig()
    {
        var codeBasedEvaluatorConfigResult = new Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig();

        return codeBasedEvaluatorConfigResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig result)
    {
        base.CreateChildren(result);

        result.LambdaConfig ??= LambdaConfigFactory?.Build();
    }

} // End Of Class

public static class InnerEvaluatorCodeBasedEvaluatorConfigFactoryExtensions
{
    public static CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig(this InnerEvaluatorCodeBasedEvaluatorConfigFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null)
    {
        parentFactory.LambdaConfigFactory = new InnerEvaluatorLambdaEvaluatorConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaConfigFactory);
    }

    public static CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1>(this CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1>(this CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, T2, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2>(this CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T2, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2>(this CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorCodeBasedEvaluatorConfigFactory, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2>(this CombinedResult<T1, T2, InnerEvaluatorCodeBasedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, T2, T3, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T2, T3, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T3, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorCodeBasedEvaluatorConfigFactory, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEvaluatorCodeBasedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, T2, T3, T4, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<InnerEvaluatorCodeBasedEvaluatorConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T2, T3, T4, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T3, T4, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T4, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEvaluatorCodeBasedEvaluatorConfigFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEvaluatorCodeBasedEvaluatorConfigFactory, InnerEvaluatorLambdaEvaluatorConfigFactory> WithLambdaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEvaluatorCodeBasedEvaluatorConfigFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaConfig(combinedResult.T5, subFactoryAction).T2);
}
