// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobProcessingInputsObjectFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject>
{

    internal InnerProcessingJobDatasetDefinitionFactory DatasetDefinitionFactory { get; set; }

    internal InnerProcessingJobS3InputFactory S3InputFactory { get; set; }

    protected override Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject Create()
    {
        var processingInputsObjectResult = CreateProcessingInputsObject();
        factoryAction?.Invoke(processingInputsObjectResult);

        return processingInputsObjectResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject CreateProcessingInputsObject()
    {
        var processingInputsObjectResult = new Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject();

        return processingInputsObjectResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject result)
    {
        base.CreateChildren(result);

        result.DatasetDefinition ??= DatasetDefinitionFactory?.Build();
        result.S3Input ??= S3InputFactory?.Build();
    }

} // End Of Class

public static class InnerProcessingJobProcessingInputsObjectFactoryExtensions
{
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition(this InnerProcessingJobProcessingInputsObjectFactory parentFactory, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null)
    {
        parentFactory.DatasetDefinitionFactory = new InnerProcessingJobDatasetDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetDefinitionFactory);
    }

    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobS3InputFactory> WithS3Input(this InnerProcessingJobProcessingInputsObjectFactory parentFactory, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null)
    {
        parentFactory.S3InputFactory = new InnerProcessingJobS3InputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3InputFactory);
    }

    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2>(this CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3>(this CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3, T4, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3, T4>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3, T4, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3, T4>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3, T4, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory, T4, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobDatasetDefinitionFactory> WithDatasetDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetDefinition(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, InnerProcessingJobS3InputFactory> WithS3Input<T1>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Input(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobS3InputFactory> WithS3Input<T1>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Input(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2>(this CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3>(this CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3, T4, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3, T4>(this CombinedResult<InnerProcessingJobProcessingInputsObjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3, T4, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3, T4>(this CombinedResult<T1, InnerProcessingJobProcessingInputsObjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3, T4, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProcessingJobProcessingInputsObjectFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory, T4, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProcessingJobProcessingInputsObjectFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProcessingJobProcessingInputsObjectFactory, InnerProcessingJobS3InputFactory> WithS3Input<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProcessingJobProcessingInputsObjectFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.S3Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Input(combinedResult.T5, subFactoryAction).T2);
}
