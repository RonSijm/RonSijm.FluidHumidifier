// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerDatasetDatasetImportJobFactory(Action<Humidifier.Personalize.DatasetTypes.DatasetImportJob> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.DatasetTypes.DatasetImportJob>
{

    internal InnerDatasetDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.Personalize.DatasetTypes.DatasetImportJob Create()
    {
        var datasetImportJobResult = CreateDatasetImportJob();
        factoryAction?.Invoke(datasetImportJobResult);

        return datasetImportJobResult;
    }

    private Humidifier.Personalize.DatasetTypes.DatasetImportJob CreateDatasetImportJob()
    {
        var datasetImportJobResult = new Humidifier.Personalize.DatasetTypes.DatasetImportJob();

        return datasetImportJobResult;
    }
    public override void CreateChildren(Humidifier.Personalize.DatasetTypes.DatasetImportJob result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerDatasetDatasetImportJobFactoryExtensions
{
    public static CombinedResult<InnerDatasetDatasetImportJobFactory, InnerDatasetDataSourceFactory> WithDataSource(this InnerDatasetDatasetImportJobFactory parentFactory, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerDatasetDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<InnerDatasetDatasetImportJobFactory, T1, InnerDatasetDataSourceFactory> WithDataSource<T1>(this CombinedResult<InnerDatasetDatasetImportJobFactory, T1> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetImportJobFactory, InnerDatasetDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, InnerDatasetDatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDatasetDatasetImportJobFactory, T1, T2, InnerDatasetDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<InnerDatasetDatasetImportJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetImportJobFactory, T2, InnerDatasetDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, InnerDatasetDatasetImportJobFactory, T2> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatasetImportJobFactory, InnerDatasetDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, InnerDatasetDatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDatasetDatasetImportJobFactory, T1, T2, T3, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<InnerDatasetDatasetImportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetImportJobFactory, T2, T3, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, InnerDatasetDatasetImportJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatasetImportJobFactory, T3, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerDatasetDatasetImportJobFactory, T3> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetImportJobFactory, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDatasetDatasetImportJobFactory, T1, T2, T3, T4, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<InnerDatasetDatasetImportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDatasetDatasetImportJobFactory, T2, T3, T4, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerDatasetDatasetImportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDatasetDatasetImportJobFactory, T3, T4, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDatasetDatasetImportJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDatasetDatasetImportJobFactory, T4, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDatasetDatasetImportJobFactory, T4> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetImportJobFactory, InnerDatasetDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDatasetDatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction));
}
