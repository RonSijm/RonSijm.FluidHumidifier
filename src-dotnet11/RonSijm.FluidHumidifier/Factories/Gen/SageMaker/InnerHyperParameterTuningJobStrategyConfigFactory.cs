// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobStrategyConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig>
{

    internal InnerHyperParameterTuningJobHyperbandStrategyConfigFactory HyperbandStrategyConfigFactory { get; set; }

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig Create()
    {
        var strategyConfigResult = CreateStrategyConfig();
        factoryAction?.Invoke(strategyConfigResult);

        return strategyConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig CreateStrategyConfig()
    {
        var strategyConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig();

        return strategyConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig result)
    {
        base.CreateChildren(result);

        result.HyperbandStrategyConfig ??= HyperbandStrategyConfigFactory?.Build();
    }

} // End Of Class

public static class InnerHyperParameterTuningJobStrategyConfigFactoryExtensions
{
    public static CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig(this InnerHyperParameterTuningJobStrategyConfigFactory parentFactory, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null)
    {
        parentFactory.HyperbandStrategyConfigFactory = new InnerHyperParameterTuningJobHyperbandStrategyConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HyperbandStrategyConfigFactory);
    }

    public static CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1>(this CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1>(this CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, T2, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2>(this CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, T2, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2>(this CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHyperParameterTuningJobStrategyConfigFactory, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2>(this CombinedResult<T1, T2, InnerHyperParameterTuningJobStrategyConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, T2, T3, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3>(this CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, T2, T3, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3>(this CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHyperParameterTuningJobStrategyConfigFactory, T3, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerHyperParameterTuningJobStrategyConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobStrategyConfigFactory, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobStrategyConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, T2, T3, T4, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3, T4>(this CombinedResult<InnerHyperParameterTuningJobStrategyConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, T2, T3, T4, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerHyperParameterTuningJobStrategyConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHyperParameterTuningJobStrategyConfigFactory, T3, T4, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHyperParameterTuningJobStrategyConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobStrategyConfigFactory, T4, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHyperParameterTuningJobStrategyConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHyperParameterTuningJobStrategyConfigFactory, InnerHyperParameterTuningJobHyperbandStrategyConfigFactory> WithHyperbandStrategyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHyperParameterTuningJobStrategyConfigFactory> combinedResult, Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHyperbandStrategyConfig(combinedResult.T5, subFactoryAction).T2);
}
