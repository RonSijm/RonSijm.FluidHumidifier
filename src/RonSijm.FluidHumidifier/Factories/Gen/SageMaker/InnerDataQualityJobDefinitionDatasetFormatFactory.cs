// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionDatasetFormatFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat>
{

    internal InnerDataQualityJobDefinitionCsvFactory CsvFactory { get; set; }

    internal InnerDataQualityJobDefinitionJsonFactory JsonFactory { get; set; }

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat Create()
    {
        var datasetFormatResult = CreateDatasetFormat();
        factoryAction?.Invoke(datasetFormatResult);

        return datasetFormatResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat CreateDatasetFormat()
    {
        var datasetFormatResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat();

        return datasetFormatResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat result)
    {
        base.CreateChildren(result);

        result.Csv ??= CsvFactory?.Build();
        result.Json ??= JsonFactory?.Build();
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionDatasetFormatFactoryExtensions
{
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionCsvFactory> WithCsv(this InnerDataQualityJobDefinitionDatasetFormatFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null)
    {
        parentFactory.CsvFactory = new InnerDataQualityJobDefinitionCsvFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CsvFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionJsonFactory> WithJson(this InnerDataQualityJobDefinitionDatasetFormatFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null)
    {
        parentFactory.JsonFactory = new InnerDataQualityJobDefinitionJsonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JsonFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3, T4, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3, T4, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory, T4, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionDatasetFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3, T4, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionDatasetFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3, T4, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionDatasetFormatFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory, T4, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionDatasetFormatFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory, InnerDataQualityJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T5, subFactoryAction));
}
