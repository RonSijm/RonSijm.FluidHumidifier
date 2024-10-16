// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetFormatOptionsFactory(Action<Humidifier.DataBrew.DatasetTypes.FormatOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.FormatOptions>
{

    internal InnerDatasetExcelOptionsFactory ExcelFactory { get; set; }

    internal InnerDatasetCsvOptionsFactory CsvFactory { get; set; }

    internal InnerDatasetJsonOptionsFactory JsonFactory { get; set; }

    protected override Humidifier.DataBrew.DatasetTypes.FormatOptions Create()
    {
        var formatOptionsResult = CreateFormatOptions();
        factoryAction?.Invoke(formatOptionsResult);

        return formatOptionsResult;
    }

    private Humidifier.DataBrew.DatasetTypes.FormatOptions CreateFormatOptions()
    {
        var formatOptionsResult = new Humidifier.DataBrew.DatasetTypes.FormatOptions();

        return formatOptionsResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.DatasetTypes.FormatOptions result)
    {
        base.CreateChildren(result);

        result.Excel ??= ExcelFactory?.Build();
        result.Csv ??= CsvFactory?.Build();
        result.Json ??= JsonFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetFormatOptionsFactoryExtensions
{
    public static CombinedResult<InnerDatasetFormatOptionsFactory, InnerDatasetExcelOptionsFactory> WithExcel(this InnerDatasetFormatOptionsFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null)
    {
        parentFactory.ExcelFactory = new InnerDatasetExcelOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExcelFactory);
    }

    public static CombinedResult<InnerDatasetFormatOptionsFactory, InnerDatasetCsvOptionsFactory> WithCsv(this InnerDatasetFormatOptionsFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null)
    {
        parentFactory.CsvFactory = new InnerDatasetCsvOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CsvFactory);
    }

    public static CombinedResult<InnerDatasetFormatOptionsFactory, InnerDatasetJsonOptionsFactory> WithJson(this InnerDatasetFormatOptionsFactory parentFactory, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null)
    {
        parentFactory.JsonFactory = new InnerDatasetJsonOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JsonFactory);
    }

    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, InnerDatasetExcelOptionsFactory> WithExcel<T1>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, InnerDatasetExcelOptionsFactory> WithExcel<T1>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, T4, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3, T4>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, T4, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, T4, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, T4, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetFormatOptionsFactory, InnerDatasetExcelOptionsFactory> WithExcel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcel(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, InnerDatasetCsvOptionsFactory> WithCsv<T1>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, InnerDatasetCsvOptionsFactory> WithCsv<T1>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, T4, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, T4, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, T4, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, T4, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetFormatOptionsFactory, InnerDatasetCsvOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, InnerDatasetJsonOptionsFactory> WithJson<T1>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, InnerDatasetJsonOptionsFactory> WithJson<T1>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, InnerDatasetJsonOptionsFactory> WithJson<T1, T2>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, InnerDatasetJsonOptionsFactory> WithJson<T1, T2>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, InnerDatasetJsonOptionsFactory> WithJson<T1, T2>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, T4, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<InnerDatasetFormatOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, T4, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetFormatOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, T4, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetFormatOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, T4, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetFormatOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetFormatOptionsFactory, InnerDatasetJsonOptionsFactory> WithJson<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.DatasetTypes.JsonOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJson(combinedResult.T5, subFactoryAction));
}
