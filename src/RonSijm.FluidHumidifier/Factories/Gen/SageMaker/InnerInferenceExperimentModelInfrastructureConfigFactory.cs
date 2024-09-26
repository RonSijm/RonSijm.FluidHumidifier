// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentModelInfrastructureConfigFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig>
{

    internal InnerInferenceExperimentRealTimeInferenceConfigFactory RealTimeInferenceConfigFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig Create()
    {
        var modelInfrastructureConfigResult = CreateModelInfrastructureConfig();
        factoryAction?.Invoke(modelInfrastructureConfigResult);

        return modelInfrastructureConfigResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig CreateModelInfrastructureConfig()
    {
        var modelInfrastructureConfigResult = new Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig();

        return modelInfrastructureConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig result)
    {
        base.CreateChildren(result);

        result.RealTimeInferenceConfig ??= RealTimeInferenceConfigFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceExperimentModelInfrastructureConfigFactoryExtensions
{
    public static CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig(this InnerInferenceExperimentModelInfrastructureConfigFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null)
    {
        parentFactory.RealTimeInferenceConfigFactory = new InnerInferenceExperimentRealTimeInferenceConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RealTimeInferenceConfigFactory);
    }

    public static CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1>(this CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1>(this CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, T2, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2>(this CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, T2, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2>(this CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2>(this CombinedResult<T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, T2, T3, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3>(this CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, T2, T3, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3>(this CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory, T3, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceExperimentModelInfrastructureConfigFactory, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceExperimentModelInfrastructureConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, T2, T3, T4, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3, T4>(this CombinedResult<InnerInferenceExperimentModelInfrastructureConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, T2, T3, T4, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceExperimentModelInfrastructureConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory, T3, T4, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceExperimentModelInfrastructureConfigFactory, T4, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceExperimentModelInfrastructureConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceExperimentModelInfrastructureConfigFactory, InnerInferenceExperimentRealTimeInferenceConfigFactory> WithRealTimeInferenceConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceExperimentModelInfrastructureConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.RealTimeInferenceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRealTimeInferenceConfig(combinedResult.T5, subFactoryAction));
}
