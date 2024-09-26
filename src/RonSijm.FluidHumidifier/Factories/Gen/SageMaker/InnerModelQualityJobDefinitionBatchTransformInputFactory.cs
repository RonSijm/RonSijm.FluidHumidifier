// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionBatchTransformInputFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput>
{

    internal InnerModelQualityJobDefinitionDatasetFormatFactory DatasetFormatFactory { get; set; }

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput Create()
    {
        var batchTransformInputResult = CreateBatchTransformInput();
        factoryAction?.Invoke(batchTransformInputResult);

        return batchTransformInputResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput CreateBatchTransformInput()
    {
        var batchTransformInputResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput();

        return batchTransformInputResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput result)
    {
        base.CreateChildren(result);

        result.DatasetFormat ??= DatasetFormatFactory?.Build();
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionBatchTransformInputFactoryExtensions
{
    public static CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat(this InnerModelQualityJobDefinitionBatchTransformInputFactory parentFactory, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null)
    {
        parentFactory.DatasetFormatFactory = new InnerModelQualityJobDefinitionDatasetFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetFormatFactory);
    }

    public static CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, T2, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionBatchTransformInputFactory, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionBatchTransformInputFactory, T3, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionBatchTransformInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionBatchTransformInputFactory, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<InnerModelQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, T2, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelQualityJobDefinitionBatchTransformInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionBatchTransformInputFactory, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionBatchTransformInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionBatchTransformInputFactory, T4, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionBatchTransformInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionBatchTransformInputFactory, InnerModelQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T5, subFactoryAction));
}
