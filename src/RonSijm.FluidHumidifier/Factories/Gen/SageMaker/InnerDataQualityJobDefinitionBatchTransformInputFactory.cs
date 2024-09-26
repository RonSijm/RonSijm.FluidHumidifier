// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionBatchTransformInputFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput>
{

    internal InnerDataQualityJobDefinitionDatasetFormatFactory DatasetFormatFactory { get; set; }

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput Create()
    {
        var batchTransformInputResult = CreateBatchTransformInput();
        factoryAction?.Invoke(batchTransformInputResult);

        return batchTransformInputResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput CreateBatchTransformInput()
    {
        var batchTransformInputResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput();

        return batchTransformInputResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput result)
    {
        base.CreateChildren(result);

        result.DatasetFormat ??= DatasetFormatFactory?.Build();
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionBatchTransformInputFactoryExtensions
{
    public static CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat(this InnerDataQualityJobDefinitionBatchTransformInputFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null)
    {
        parentFactory.DatasetFormatFactory = new InnerDataQualityJobDefinitionDatasetFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetFormatFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, T2, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory, T3, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, T2, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionBatchTransformInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionBatchTransformInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory, T4, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionBatchTransformInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionBatchTransformInputFactory, InnerDataQualityJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T5, subFactoryAction));
}
