// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class EvaluatorFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.Evaluator> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.Evaluator>(resourceName)
{

    internal InnerEvaluatorEvaluatorConfigFactory EvaluatorConfigFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.Evaluator Create()
    {
        var evaluatorResult = CreateEvaluator();
        factoryAction?.Invoke(evaluatorResult);

        return evaluatorResult;
    }

    private Humidifier.BedrockAgentCore.Evaluator CreateEvaluator()
    {
        var evaluatorResult = new Humidifier.BedrockAgentCore.Evaluator
        {
            GivenName = InputResourceName,
        };

        return evaluatorResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.Evaluator result)
    {
        base.CreateChildren(result);

        result.EvaluatorConfig ??= EvaluatorConfigFactory?.Build();
    }

} // End Of Class

public static class EvaluatorFactoryExtensions
{
    public static CombinedResult<EvaluatorFactory, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig(this EvaluatorFactory parentFactory, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null)
    {
        parentFactory.EvaluatorConfigFactory = new InnerEvaluatorEvaluatorConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EvaluatorConfigFactory);
    }

    public static CombinedResult<EvaluatorFactory, T1, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1>(this CombinedResult<EvaluatorFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EvaluatorFactory, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1>(this CombinedResult<T1, EvaluatorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EvaluatorFactory, T1, T2, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2>(this CombinedResult<EvaluatorFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EvaluatorFactory, T2, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2>(this CombinedResult<T1, EvaluatorFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EvaluatorFactory, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2>(this CombinedResult<T1, T2, EvaluatorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EvaluatorFactory, T1, T2, T3, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3>(this CombinedResult<EvaluatorFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EvaluatorFactory, T2, T3, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3>(this CombinedResult<T1, EvaluatorFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EvaluatorFactory, T3, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3>(this CombinedResult<T1, T2, EvaluatorFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EvaluatorFactory, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EvaluatorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EvaluatorFactory, T1, T2, T3, T4, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3, T4>(this CombinedResult<EvaluatorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EvaluatorFactory, T2, T3, T4, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3, T4>(this CombinedResult<T1, EvaluatorFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EvaluatorFactory, T3, T4, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EvaluatorFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EvaluatorFactory, T4, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EvaluatorFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EvaluatorFactory, InnerEvaluatorEvaluatorConfigFactory> WithEvaluatorConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EvaluatorFactory> combinedResult, Action<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvaluatorConfig(combinedResult.T5, subFactoryAction).T2);
}
