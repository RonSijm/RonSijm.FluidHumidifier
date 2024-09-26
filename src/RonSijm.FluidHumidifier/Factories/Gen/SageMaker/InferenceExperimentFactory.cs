// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InferenceExperimentFactory(string resourceName = null, Action<Humidifier.SageMaker.InferenceExperiment> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.InferenceExperiment>(resourceName)
{

    internal List<InnerInferenceExperimentModelVariantConfigFactory> ModelVariantsFactories { get; set; } = [];

    internal InnerInferenceExperimentDataStorageConfigFactory DataStorageConfigFactory { get; set; }

    internal InnerInferenceExperimentShadowModeConfigFactory ShadowModeConfigFactory { get; set; }

    internal InnerInferenceExperimentInferenceExperimentScheduleFactory ScheduleFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceExperiment Create()
    {
        var inferenceExperimentResult = CreateInferenceExperiment();
        factoryAction?.Invoke(inferenceExperimentResult);

        return inferenceExperimentResult;
    }

    private Humidifier.SageMaker.InferenceExperiment CreateInferenceExperiment()
    {
        var inferenceExperimentResult = new Humidifier.SageMaker.InferenceExperiment
        {
            GivenName = InputResourceName,
        };

        return inferenceExperimentResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceExperiment result)
    {
        base.CreateChildren(result);

        result.ModelVariants = ModelVariantsFactories.Any() ? ModelVariantsFactories.Select(x => x.Build()).ToList() : null;
        result.DataStorageConfig ??= DataStorageConfigFactory?.Build();
        result.ShadowModeConfig ??= ShadowModeConfigFactory?.Build();
        result.Schedule ??= ScheduleFactory?.Build();
    }

} // End Of Class

public static class InferenceExperimentFactoryExtensions
{
    public static CombinedResult<InferenceExperimentFactory, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants(this InferenceExperimentFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null)
    {
        var factory = new InnerInferenceExperimentModelVariantConfigFactory(subFactoryAction);
        parentFactory.ModelVariantsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InferenceExperimentFactory, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig(this InferenceExperimentFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null)
    {
        parentFactory.DataStorageConfigFactory = new InnerInferenceExperimentDataStorageConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataStorageConfigFactory);
    }

    public static CombinedResult<InferenceExperimentFactory, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig(this InferenceExperimentFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null)
    {
        parentFactory.ShadowModeConfigFactory = new InnerInferenceExperimentShadowModeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ShadowModeConfigFactory);
    }

    public static CombinedResult<InferenceExperimentFactory, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule(this InferenceExperimentFactory parentFactory, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerInferenceExperimentInferenceExperimentScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<InferenceExperimentFactory, T1, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1>(this CombinedResult<InferenceExperimentFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1>(this CombinedResult<T1, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2>(this CombinedResult<InferenceExperimentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2>(this CombinedResult<T1, InferenceExperimentFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2>(this CombinedResult<T1, T2, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3, T4>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3, T4>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory, InnerInferenceExperimentModelVariantConfigFactory> WithModelVariants<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ModelVariantConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelVariants(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1>(this CombinedResult<InferenceExperimentFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1>(this CombinedResult<T1, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2>(this CombinedResult<InferenceExperimentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2>(this CombinedResult<T1, InferenceExperimentFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2>(this CombinedResult<T1, T2, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3, T4>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory, InnerInferenceExperimentDataStorageConfigFactory> WithDataStorageConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.DataStorageConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataStorageConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1>(this CombinedResult<InferenceExperimentFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1>(this CombinedResult<T1, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2>(this CombinedResult<InferenceExperimentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2>(this CombinedResult<T1, InferenceExperimentFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2>(this CombinedResult<T1, T2, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3, T4>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory, InnerInferenceExperimentShadowModeConfigFactory> WithShadowModeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.ShadowModeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithShadowModeConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1>(this CombinedResult<InferenceExperimentFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<InferenceExperimentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, InferenceExperimentFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<InferenceExperimentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, InferenceExperimentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceExperimentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceExperimentFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory, InnerInferenceExperimentInferenceExperimentScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceExperimentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceExperimentTypes.InferenceExperimentSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction));
}
