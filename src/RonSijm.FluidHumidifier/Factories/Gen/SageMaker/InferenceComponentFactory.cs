// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InferenceComponentFactory(string resourceName = null, Action<Humidifier.SageMaker.InferenceComponent> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.InferenceComponent>(resourceName)
{

    internal InnerInferenceComponentInferenceComponentSpecificationFactory SpecificationFactory { get; set; }

    internal InnerInferenceComponentInferenceComponentRuntimeConfigFactory RuntimeConfigFactory { get; set; }

    protected override Humidifier.SageMaker.InferenceComponent Create()
    {
        var inferenceComponentResult = CreateInferenceComponent();
        factoryAction?.Invoke(inferenceComponentResult);

        return inferenceComponentResult;
    }

    private Humidifier.SageMaker.InferenceComponent CreateInferenceComponent()
    {
        var inferenceComponentResult = new Humidifier.SageMaker.InferenceComponent
        {
            GivenName = InputResourceName,
        };

        return inferenceComponentResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.InferenceComponent result)
    {
        base.CreateChildren(result);

        result.Specification ??= SpecificationFactory?.Build();
        result.RuntimeConfig ??= RuntimeConfigFactory?.Build();
    }

} // End Of Class

public static class InferenceComponentFactoryExtensions
{
    public static CombinedResult<InferenceComponentFactory, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification(this InferenceComponentFactory parentFactory, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null)
    {
        parentFactory.SpecificationFactory = new InnerInferenceComponentInferenceComponentSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecificationFactory);
    }

    public static CombinedResult<InferenceComponentFactory, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig(this InferenceComponentFactory parentFactory, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null)
    {
        parentFactory.RuntimeConfigFactory = new InnerInferenceComponentInferenceComponentRuntimeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuntimeConfigFactory);
    }

    public static CombinedResult<InferenceComponentFactory, T1, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1>(this CombinedResult<InferenceComponentFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1>(this CombinedResult<T1, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, T2, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2>(this CombinedResult<InferenceComponentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, T2, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2>(this CombinedResult<T1, InferenceComponentFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceComponentFactory, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2>(this CombinedResult<T1, T2, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, T2, T3, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3>(this CombinedResult<InferenceComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, T2, T3, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3>(this CombinedResult<T1, InferenceComponentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceComponentFactory, T3, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InferenceComponentFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceComponentFactory, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, T2, T3, T4, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3, T4>(this CombinedResult<InferenceComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, T2, T3, T4, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InferenceComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceComponentFactory, T3, T4, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceComponentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceComponentFactory, T4, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceComponentFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceComponentFactory, InnerInferenceComponentInferenceComponentSpecificationFactory> WithSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpecification(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1>(this CombinedResult<InferenceComponentFactory, T1> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1>(this CombinedResult<T1, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, T2, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2>(this CombinedResult<InferenceComponentFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, T2, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2>(this CombinedResult<T1, InferenceComponentFactory, T2> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceComponentFactory, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2>(this CombinedResult<T1, T2, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, T2, T3, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<InferenceComponentFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, T2, T3, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<T1, InferenceComponentFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceComponentFactory, T3, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InferenceComponentFactory, T3> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceComponentFactory, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InferenceComponentFactory, T1, T2, T3, T4, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<InferenceComponentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InferenceComponentFactory, T2, T3, T4, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InferenceComponentFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InferenceComponentFactory, T3, T4, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InferenceComponentFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InferenceComponentFactory, T4, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InferenceComponentFactory, T4> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InferenceComponentFactory, InnerInferenceComponentInferenceComponentRuntimeConfigFactory> WithRuntimeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InferenceComponentFactory> combinedResult, Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentRuntimeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeConfig(combinedResult.T5, subFactoryAction));
}
