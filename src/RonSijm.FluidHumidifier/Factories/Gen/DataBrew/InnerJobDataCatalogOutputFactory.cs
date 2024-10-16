// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobDataCatalogOutputFactory(Action<Humidifier.DataBrew.JobTypes.DataCatalogOutput> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.DataCatalogOutput>
{

    internal InnerJobS3TableOutputOptionsFactory S3OptionsFactory { get; set; }

    internal InnerJobDatabaseTableOutputOptionsFactory DatabaseOptionsFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.DataCatalogOutput Create()
    {
        var dataCatalogOutputResult = CreateDataCatalogOutput();
        factoryAction?.Invoke(dataCatalogOutputResult);

        return dataCatalogOutputResult;
    }

    private Humidifier.DataBrew.JobTypes.DataCatalogOutput CreateDataCatalogOutput()
    {
        var dataCatalogOutputResult = new Humidifier.DataBrew.JobTypes.DataCatalogOutput();

        return dataCatalogOutputResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.DataCatalogOutput result)
    {
        base.CreateChildren(result);

        result.S3Options ??= S3OptionsFactory?.Build();
        result.DatabaseOptions ??= DatabaseOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerJobDataCatalogOutputFactoryExtensions
{
    public static CombinedResult<InnerJobDataCatalogOutputFactory, InnerJobS3TableOutputOptionsFactory> WithS3Options(this InnerJobDataCatalogOutputFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null)
    {
        parentFactory.S3OptionsFactory = new InnerJobS3TableOutputOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3OptionsFactory);
    }

    public static CombinedResult<InnerJobDataCatalogOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions(this InnerJobDataCatalogOutputFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null)
    {
        parentFactory.DatabaseOptionsFactory = new InnerJobDatabaseTableOutputOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DatabaseOptionsFactory);
    }

    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Options(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Options(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2>(this CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3, T4, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3, T4>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3, T4, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3, T4, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory, T4, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDataCatalogOutputFactory, InnerJobS3TableOutputOptionsFactory> WithS3Options<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Options(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2>(this CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<InnerJobDataCatalogOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDataCatalogOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDataCatalogOutputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory, T4, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDataCatalogOutputFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDataCatalogOutputFactory, InnerJobDatabaseTableOutputOptionsFactory> WithDatabaseOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDataCatalogOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDatabaseOptions(combinedResult.T5, subFactoryAction));
}
