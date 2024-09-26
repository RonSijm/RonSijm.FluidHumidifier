// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobOutputFormatOptionsFactory(Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.OutputFormatOptions>
{

    internal InnerJobCsvOutputOptionsFactory CsvFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.OutputFormatOptions Create()
    {
        var outputFormatOptionsResult = CreateOutputFormatOptions();
        factoryAction?.Invoke(outputFormatOptionsResult);

        return outputFormatOptionsResult;
    }

    private Humidifier.DataBrew.JobTypes.OutputFormatOptions CreateOutputFormatOptions()
    {
        var outputFormatOptionsResult = new Humidifier.DataBrew.JobTypes.OutputFormatOptions();

        return outputFormatOptionsResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.OutputFormatOptions result)
    {
        base.CreateChildren(result);

        result.Csv ??= CsvFactory?.Build();
    }

} // End Of Class

public static class InnerJobOutputFormatOptionsFactoryExtensions
{
    public static CombinedResult<InnerJobOutputFormatOptionsFactory, InnerJobCsvOutputOptionsFactory> WithCsv(this InnerJobOutputFormatOptionsFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null)
    {
        parentFactory.CsvFactory = new InnerJobCsvOutputOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CsvFactory);
    }

    public static CombinedResult<InnerJobOutputFormatOptionsFactory, T1, InnerJobCsvOutputOptionsFactory> WithCsv<T1>(this CombinedResult<InnerJobOutputFormatOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFormatOptionsFactory, InnerJobCsvOutputOptionsFactory> WithCsv<T1>(this CombinedResult<T1, InnerJobOutputFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobOutputFormatOptionsFactory, T1, T2, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2>(this CombinedResult<InnerJobOutputFormatOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFormatOptionsFactory, T2, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2>(this CombinedResult<T1, InnerJobOutputFormatOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFormatOptionsFactory, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2>(this CombinedResult<T1, T2, InnerJobOutputFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobOutputFormatOptionsFactory, T1, T2, T3, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<InnerJobOutputFormatOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFormatOptionsFactory, T2, T3, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, InnerJobOutputFormatOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFormatOptionsFactory, T3, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobOutputFormatOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobOutputFormatOptionsFactory, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobOutputFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobOutputFormatOptionsFactory, T1, T2, T3, T4, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<InnerJobOutputFormatOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFormatOptionsFactory, T2, T3, T4, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobOutputFormatOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFormatOptionsFactory, T3, T4, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobOutputFormatOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobOutputFormatOptionsFactory, T4, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobOutputFormatOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobOutputFormatOptionsFactory, InnerJobCsvOutputOptionsFactory> WithCsv<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobOutputFormatOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCsv(combinedResult.T5, subFactoryAction));
}
