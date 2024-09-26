// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionDatasetFormatFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat>
{

    internal InnerModelQualityJobDefinitionCsvFactory CsvFactory { get; set; }

    internal InnerModelQualityJobDefinitionJsonFactory JsonFactory { get; set; }

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat Create()
    {
        var datasetFormatResult = CreateDatasetFormat();
        factoryAction?.Invoke(datasetFormatResult);

        return datasetFormatResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat CreateDatasetFormat()
    {
        var datasetFormatResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat();

        return datasetFormatResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat result)
    {
        base.CreateChildren(result);

        result.Csv ??= CsvFactory?.Build();
        result.Json ??= JsonFactory?.Build();
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionDatasetFormatFactoryExtensions
{
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionCsvFactory> WithCsv(this InnerModelQualityJobDefinitionDatasetFormatFactory parentFactory, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null)
    {
        parentFactory.CsvFactory = new InnerModelQualityJobDefinitionCsvFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CsvFactory);
    }

    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionJsonFactory> WithJson(this InnerModelQualityJobDefinitionDatasetFormatFactory parentFactory, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null)
    {
        parentFactory.JsonFactory = new InnerModelQualityJobDefinitionJsonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JsonFactory);
    }

    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3, T4, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3, T4, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory, T4, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<InnerModelQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3, T4, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelQualityJobDefinitionDatasetFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3, T4, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionDatasetFormatFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory, T4, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionDatasetFormatFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory, InnerModelQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T5, subFactoryAction));
}
