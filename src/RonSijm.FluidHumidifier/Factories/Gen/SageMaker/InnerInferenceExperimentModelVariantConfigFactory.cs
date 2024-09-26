// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentModelVariantConfigFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig>
{

    internal InnerInferenceExperimentModelInfrastructureConfigFactory InfrastructureConfigFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig Create()
    {
        var modelVariantConfigResult = CreateModelVariantConfig();
        factoryAction?.Invoke(modelVariantConfigResult);

        return modelVariantConfigResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig CreateModelVariantConfig()
    {
        var modelVariantConfigResult = new Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig();

        return modelVariantConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig result)
    {
        base.CreateChildren(result);

        result.InfrastructureConfig ??= InfrastructureConfigFactory?.Build();
    }

} // End Of Class

public static class InnerInferenceExperimentModelVariantConfigFactoryExtensions
{
    public static CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig(this InnerInferenceExperimentModelVariantConfigFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null)
    {
        parentFactory.InfrastructureConfigFactory = new InnerInferenceExperimentModelInfrastructureConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InfrastructureConfigFactory);
    }

    public static CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1>(this CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1>(this CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, T2, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2>(this CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, T2, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2>(this CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentModelVariantConfigFactory, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2>(this CombinedResult<T1, T2, InnerInferenceExperimentModelVariantConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, T2, T3, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3>(this CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, T2, T3, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3>(this CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentModelVariantConfigFactory, T3, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerInferenceExperimentModelVariantConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceExperimentModelVariantConfigFactory, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInferenceExperimentModelVariantConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, T2, T3, T4, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3, T4>(this CombinedResult<InnerInferenceExperimentModelVariantConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, T2, T3, T4, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerInferenceExperimentModelVariantConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInferenceExperimentModelVariantConfigFactory, T3, T4, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInferenceExperimentModelVariantConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInferenceExperimentModelVariantConfigFactory, T4, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInferenceExperimentModelVariantConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInferenceExperimentModelVariantConfigFactory, InnerInferenceExperimentModelInfrastructureConfigFactory> WithInfrastructureConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInferenceExperimentModelVariantConfigFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelInfrastructureConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInfrastructureConfig(combinedResult.T5, subFactoryAction));
}
