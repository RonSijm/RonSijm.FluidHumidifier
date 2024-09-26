// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionBatchTransformInputFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.BatchTransformInput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.BatchTransformInput>
{

    internal InnerModelBiasJobDefinitionDatasetFormatFactory DatasetFormatFactory { get; set; }

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.BatchTransformInput Create()
    {
        var batchTransformInputResult = CreateBatchTransformInput();
        factoryAction?.Invoke(batchTransformInputResult);

        return batchTransformInputResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.BatchTransformInput CreateBatchTransformInput()
    {
        var batchTransformInputResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.BatchTransformInput();

        return batchTransformInputResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelBiasJobDefinitionTypes.BatchTransformInput result)
    {
        base.CreateChildren(result);

        result.DatasetFormat ??= DatasetFormatFactory?.Build();
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionBatchTransformInputFactoryExtensions
{
    public static CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat(this InnerModelBiasJobDefinitionBatchTransformInputFactory parentFactory, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null)
    {
        parentFactory.DatasetFormatFactory = new InnerModelBiasJobDefinitionDatasetFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatasetFormatFactory);
    }

    public static CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1>(this CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, T2, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionBatchTransformInputFactory, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionBatchTransformInputFactory, T3, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionBatchTransformInputFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionBatchTransformInputFactory, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<InnerModelBiasJobDefinitionBatchTransformInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, T2, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelBiasJobDefinitionBatchTransformInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionBatchTransformInputFactory, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionBatchTransformInputFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionBatchTransformInputFactory, T4, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionBatchTransformInputFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionBatchTransformInputFactory, InnerModelBiasJobDefinitionDatasetFormatFactory> WithDatasetFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionBatchTransformInputFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatasetFormat(combinedResult.T5, subFactoryAction));
}
