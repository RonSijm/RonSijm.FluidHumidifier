// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerPipelinePipelineDefinitionFactory(Action<Humidifier.SageMaker.PipelineTypes.PipelineDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.PipelineTypes.PipelineDefinition>
{

    internal InnerPipelineS3LocationFactory PipelineDefinitionS3LocationFactory { get; set; }

    protected override Humidifier.SageMaker.PipelineTypes.PipelineDefinition Create()
    {
        var pipelineDefinitionResult = CreatePipelineDefinition();
        factoryAction?.Invoke(pipelineDefinitionResult);

        return pipelineDefinitionResult;
    }

    private Humidifier.SageMaker.PipelineTypes.PipelineDefinition CreatePipelineDefinition()
    {
        var pipelineDefinitionResult = new Humidifier.SageMaker.PipelineTypes.PipelineDefinition();

        return pipelineDefinitionResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.PipelineTypes.PipelineDefinition result)
    {
        base.CreateChildren(result);

        result.PipelineDefinitionS3Location ??= PipelineDefinitionS3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerPipelinePipelineDefinitionFactoryExtensions
{
    public static CombinedResult<InnerPipelinePipelineDefinitionFactory, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location(this InnerPipelinePipelineDefinitionFactory parentFactory, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.PipelineDefinitionS3LocationFactory = new InnerPipelineS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PipelineDefinitionS3LocationFactory);
    }

    public static CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1>(this CombinedResult<InnerPipelinePipelineDefinitionFactory, T1> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1>(this CombinedResult<T1, InnerPipelinePipelineDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, T2, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2>(this CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, T2, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2>(this CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, T2> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelinePipelineDefinitionFactory, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2>(this CombinedResult<T1, T2, InnerPipelinePipelineDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, T2, T3, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3>(this CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, T2, T3, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3>(this CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelinePipelineDefinitionFactory, T3, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipelinePipelineDefinitionFactory, T3> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelinePipelineDefinitionFactory, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipelinePipelineDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, T2, T3, T4, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<InnerPipelinePipelineDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, T2, T3, T4, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipelinePipelineDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipelinePipelineDefinitionFactory, T3, T4, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipelinePipelineDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipelinePipelineDefinitionFactory, T4, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipelinePipelineDefinitionFactory, T4> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipelinePipelineDefinitionFactory, InnerPipelineS3LocationFactory> WithPipelineDefinitionS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipelinePipelineDefinitionFactory> combinedResult, Action<Humidifier.SageMaker.PipelineTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPipelineDefinitionS3Location(combinedResult.T5, subFactoryAction));
}
