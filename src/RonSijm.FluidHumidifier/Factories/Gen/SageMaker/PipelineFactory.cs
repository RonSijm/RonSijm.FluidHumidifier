// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class PipelineFactory(string resourceName = null, Action<Humidifier.SageMaker.Pipeline> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Pipeline>(resourceName)
{

    internal InnerPipelineParallelismConfigurationFactory ParallelismConfigurationFactory { get; set; }

    internal InnerPipelinePipelineDefinitionFactory PipelineDefinitionFactory { get; set; }

    protected override Humidifier.SageMaker.Pipeline Create()
    {
        var pipelineResult = CreatePipeline();
        factoryAction?.Invoke(pipelineResult);

        return pipelineResult;
    }

    private Humidifier.SageMaker.Pipeline CreatePipeline()
    {
        var pipelineResult = new Humidifier.SageMaker.Pipeline
        {
            GivenName = InputResourceName,
        };

        return pipelineResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Pipeline result)
    {
        base.CreateChildren(result);

        result.ParallelismConfiguration ??= ParallelismConfigurationFactory?.Build();
        result.PipelineDefinition ??= PipelineDefinitionFactory?.Build();
    }

} // End Of Class

public static class PipelineFactoryExtensions
{
    public static CombinedResult<PipelineFactory, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration(this PipelineFactory parentFactory, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null)
    {
        parentFactory.ParallelismConfigurationFactory = new InnerPipelineParallelismConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParallelismConfigurationFactory);
    }

    public static CombinedResult<PipelineFactory, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition(this PipelineFactory parentFactory, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null)
    {
        parentFactory.PipelineDefinitionFactory = new InnerPipelinePipelineDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PipelineDefinitionFactory);
    }

    public static CombinedResult<PipelineFactory, T1, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1>(this CombinedResult<PipelineFactory, T1> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1>(this CombinedResult<T1, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2>(this CombinedResult<PipelineFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2>(this CombinedResult<T1, PipelineFactory, T2> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2>(this CombinedResult<T1, T2, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, T3, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3>(this CombinedResult<PipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, T3, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3>(this CombinedResult<T1, PipelineFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, T3, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PipelineFactory, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PipelineFactory, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, T3, T4, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3, T4>(this CombinedResult<PipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, T3, T4, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, T3, T4, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PipelineFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PipelineFactory, T4, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PipelineFactory, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PipelineFactory, InnerPipelineParallelismConfigurationFactory> WithParallelismConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParallelismConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1>(this CombinedResult<PipelineFactory, T1> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1>(this CombinedResult<T1, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2>(this CombinedResult<PipelineFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2>(this CombinedResult<T1, PipelineFactory, T2> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2>(this CombinedResult<T1, T2, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, T3, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3>(this CombinedResult<PipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, T3, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3>(this CombinedResult<T1, PipelineFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, T3, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3>(this CombinedResult<T1, T2, PipelineFactory, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PipelineFactory, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PipelineFactory, T1, T2, T3, T4, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3, T4>(this CombinedResult<PipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PipelineFactory, T2, T3, T4, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3, T4>(this CombinedResult<T1, PipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PipelineFactory, T3, T4, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, PipelineFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PipelineFactory, T4, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PipelineFactory, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PipelineFactory, InnerPipelinePipelineDefinitionFactory> WithPipelineDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PipelineFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinition(combinedResult.T5, subFactoryAction));
}
