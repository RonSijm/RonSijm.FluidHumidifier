// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionBatchTransformInputFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput>
{

    internal InnerModelExplainabilityJobDefinitionDatasetFormatFactory DatasetFormatFactory { get; set; }

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput Create()
    {
        var batchTransformInputResult = CreateBatchTransformInput();
        factoryAction?.Invoke(batchTransformInputResult);

        return batchTransformInputResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput CreateBatchTransformInput()
    {
        var batchTransformInputResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput();

        return batchTransformInputResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput result)
    {
        base.CreateChildren(result);

        result.DatasetFormat ??= DatasetFormatFactory?.Build();
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionBatchTransformInputFactoryExtensions
{
    public static CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat(this InnerModelExplainabilityJobDefinitionBatchTransformInputFactory parentFactory, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null)
    {
        parentFactory.DatasetFormatFactory = new InnerModelExplainabilityJobDefinitionDatasetFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetFormatFactory);
    }

    public static CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, T2, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T2, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, T2, T3, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T2, T3, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T3, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T2, T3, T4, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T3, T4, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T4, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory, InnerModelExplainabilityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T5, subFactoryAction));
}
