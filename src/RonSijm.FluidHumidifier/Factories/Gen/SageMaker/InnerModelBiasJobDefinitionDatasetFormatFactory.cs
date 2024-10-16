// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionDatasetFormatFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat>
{

    internal InnerModelBiasJobDefinitionCsvFactory CsvFactory { get; set; }

    internal InnerModelBiasJobDefinitionJsonFactory JsonFactory { get; set; }

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat Create()
    {
        var datasetFormatResult = CreateDatasetFormat();
        factoryAction?.Invoke(datasetFormatResult);

        return datasetFormatResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat CreateDatasetFormat()
    {
        var datasetFormatResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat();

        return datasetFormatResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelBiasJobDefinitionTypes.DatasetFormat result)
    {
        base.CreateChildren(result);

        result.Csv ??= CsvFactory?.Build();
        result.Json ??= JsonFactory?.Build();
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionDatasetFormatFactoryExtensions
{
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionCsvFactory> WithCsv(this InnerModelBiasJobDefinitionDatasetFormatFactory parentFactory, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null)
    {
        parentFactory.CsvFactory = new InnerModelBiasJobDefinitionCsvFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CsvFactory);
    }

    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionJsonFactory> WithJson(this InnerModelBiasJobDefinitionDatasetFormatFactory parentFactory, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null)
    {
        parentFactory.JsonFactory = new InnerModelBiasJobDefinitionJsonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JsonFactory);
    }

    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3, T4, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3, T4, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3, T4, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory, T4, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3, T4, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<InnerModelBiasJobDefinitionDatasetFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3, T4, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelBiasJobDefinitionDatasetFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3, T4, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionDatasetFormatFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory, T4, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionDatasetFormatFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory, InnerModelBiasJobDefinitionJsonFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionDatasetFormatFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.Json> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T5, subFactoryAction));
}
