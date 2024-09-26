// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableInputFormatOptionsFactory(Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.InputFormatOptions>
{

    internal InnerTableCsvFactory CsvFactory { get; set; }

    protected override Humidifier.DynamoDB.TableTypes.InputFormatOptions Create()
    {
        var inputFormatOptionsResult = CreateInputFormatOptions();
        factoryAction?.Invoke(inputFormatOptionsResult);

        return inputFormatOptionsResult;
    }

    private Humidifier.DynamoDB.TableTypes.InputFormatOptions CreateInputFormatOptions()
    {
        var inputFormatOptionsResult = new Humidifier.DynamoDB.TableTypes.InputFormatOptions();

        return inputFormatOptionsResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.TableTypes.InputFormatOptions result)
    {
        base.CreateChildren(result);

        result.Csv ??= CsvFactory?.Build();
    }

} // End Of Class

public static class InnerTableInputFormatOptionsFactoryExtensions
{
    public static CombinedResult<InnerTableInputFormatOptionsFactory, InnerTableCsvFactory> WithCsv(this InnerTableInputFormatOptionsFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null)
    {
        parentFactory.CsvFactory = new InnerTableCsvFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CsvFactory);
    }

    public static CombinedResult<InnerTableInputFormatOptionsFactory, T1, InnerTableCsvFactory> WithCsv<T1>(this CombinedResult<InnerTableInputFormatOptionsFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableInputFormatOptionsFactory, InnerTableCsvFactory> WithCsv<T1>(this CombinedResult<T1, InnerTableInputFormatOptionsFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableInputFormatOptionsFactory, T1, T2, InnerTableCsvFactory> WithCsv<T1, T2>(this CombinedResult<InnerTableInputFormatOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableInputFormatOptionsFactory, T2, InnerTableCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, InnerTableInputFormatOptionsFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableInputFormatOptionsFactory, InnerTableCsvFactory> WithCsv<T1, T2>(this CombinedResult<T1, T2, InnerTableInputFormatOptionsFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableInputFormatOptionsFactory, T1, T2, T3, InnerTableCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<InnerTableInputFormatOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableInputFormatOptionsFactory, T2, T3, InnerTableCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, InnerTableInputFormatOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableInputFormatOptionsFactory, T3, InnerTableCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableInputFormatOptionsFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableInputFormatOptionsFactory, InnerTableCsvFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableInputFormatOptionsFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableInputFormatOptionsFactory, T1, T2, T3, T4, InnerTableCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<InnerTableInputFormatOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableInputFormatOptionsFactory, T2, T3, T4, InnerTableCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableInputFormatOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableInputFormatOptionsFactory, T3, T4, InnerTableCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableInputFormatOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableInputFormatOptionsFactory, T4, InnerTableCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableInputFormatOptionsFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableInputFormatOptionsFactory, InnerTableCsvFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableInputFormatOptionsFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.Csv> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T5, subFactoryAction));
}
