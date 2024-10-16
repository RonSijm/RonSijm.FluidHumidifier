// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ModelFactory(string resourceName = null, Action<Humidifier.SageMaker.Model> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Model>(resourceName)
{

    internal List<InnerModelContainerDefinitionFactory> ContainersFactories { get; set; } = [];

    internal InnerModelContainerDefinitionFactory PrimaryContainerFactory { get; set; }

    internal InnerModelVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerModelInferenceExecutionConfigFactory InferenceExecutionConfigFactory { get; set; }

    protected override Humidifier.SageMaker.Model Create()
    {
        var modelResult = CreateModel();
        factoryAction?.Invoke(modelResult);

        return modelResult;
    }

    private Humidifier.SageMaker.Model CreateModel()
    {
        var modelResult = new Humidifier.SageMaker.Model
        {
            GivenName = InputResourceName,
        };

        return modelResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Model result)
    {
        base.CreateChildren(result);

        result.Containers = ContainersFactories.Any() ? ContainersFactories.Select(x => x.Build()).ToList() : null;
        result.PrimaryContainer ??= PrimaryContainerFactory?.Build();
        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.InferenceExecutionConfig ??= InferenceExecutionConfigFactory?.Build();
    }

} // End Of Class

public static class ModelFactoryExtensions
{
    public static CombinedResult<ModelFactory, InnerModelContainerDefinitionFactory> WithContainers(this ModelFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null)
    {
        var factory = new InnerModelContainerDefinitionFactory(subFactoryAction);
        parentFactory.ContainersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ModelFactory, InnerModelContainerDefinitionFactory> WithPrimaryContainer(this ModelFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null)
    {
        parentFactory.PrimaryContainerFactory = new InnerModelContainerDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrimaryContainerFactory);
    }

    public static CombinedResult<ModelFactory, InnerModelVpcConfigFactory> WithVpcConfig(this ModelFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerModelVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<ModelFactory, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig(this ModelFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null)
    {
        parentFactory.InferenceExecutionConfigFactory = new InnerModelInferenceExecutionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InferenceExecutionConfigFactory);
    }

    public static CombinedResult<ModelFactory, T1, InnerModelContainerDefinitionFactory> WithContainers<T1>(this CombinedResult<ModelFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, InnerModelContainerDefinitionFactory> WithContainers<T1>(this CombinedResult<T1, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, InnerModelContainerDefinitionFactory> WithContainers<T1, T2>(this CombinedResult<ModelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, InnerModelContainerDefinitionFactory> WithContainers<T1, T2>(this CombinedResult<T1, ModelFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, InnerModelContainerDefinitionFactory> WithContainers<T1, T2>(this CombinedResult<T1, T2, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3>(this CombinedResult<ModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3>(this CombinedResult<T1, ModelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3>(this CombinedResult<T1, T2, ModelFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, T4, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3, T4>(this CombinedResult<ModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, T4, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3, T4>(this CombinedResult<T1, ModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, T4, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, T4, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelFactory, InnerModelContainerDefinitionFactory> WithContainers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainers(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1>(this CombinedResult<ModelFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1>(this CombinedResult<T1, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2>(this CombinedResult<ModelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2>(this CombinedResult<T1, ModelFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2>(this CombinedResult<T1, T2, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3>(this CombinedResult<ModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3>(this CombinedResult<T1, ModelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3>(this CombinedResult<T1, T2, ModelFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, T4, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3, T4>(this CombinedResult<ModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, T4, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3, T4>(this CombinedResult<T1, ModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, T4, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, T4, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelFactory, InnerModelContainerDefinitionFactory> WithPrimaryContainer<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.ContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrimaryContainer(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, InnerModelVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<ModelFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, InnerModelVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<ModelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, ModelFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<ModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, ModelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, ModelFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, T4, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<ModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, T4, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, ModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, T4, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, T4, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelFactory, InnerModelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1>(this CombinedResult<ModelFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1>(this CombinedResult<T1, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2>(this CombinedResult<ModelFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2>(this CombinedResult<T1, ModelFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2>(this CombinedResult<T1, T2, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3>(this CombinedResult<ModelFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3>(this CombinedResult<T1, ModelFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3>(this CombinedResult<T1, T2, ModelFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ModelFactory, T1, T2, T3, T4, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3, T4>(this CombinedResult<ModelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ModelFactory, T2, T3, T4, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, ModelFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ModelFactory, T3, T4, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ModelFactory, T4, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ModelFactory, InnerModelInferenceExecutionConfigFactory> WithInferenceExecutionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInferenceExecutionConfig(combinedResult.T5, subFactoryAction));
}
