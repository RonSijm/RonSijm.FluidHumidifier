// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class DatasetImportJobFactory(string resourceName = null, Action<Humidifier.Personalize.DatasetImportJob> factoryAction = null) : ResourceFactory<Humidifier.Personalize.DatasetImportJob>(resourceName)
{

    internal InnerDatasetImportJobDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.Personalize.DatasetImportJob Create()
    {
        var datasetImportJobResult = CreateDatasetImportJob();
        factoryAction?.Invoke(datasetImportJobResult);

        return datasetImportJobResult;
    }

    private Humidifier.Personalize.DatasetImportJob CreateDatasetImportJob()
    {
        var datasetImportJobResult = new Humidifier.Personalize.DatasetImportJob
        {
            GivenName = InputResourceName,
        };

        return datasetImportJobResult;
    }
    public override void CreateChildren(Humidifier.Personalize.DatasetImportJob result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class DatasetImportJobFactoryExtensions
{
    public static CombinedResult<DatasetImportJobFactory, InnerDatasetImportJobDataSourceFactory> WithDataSource(this DatasetImportJobFactory parentFactory, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerDatasetImportJobDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<DatasetImportJobFactory, T1, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<DatasetImportJobFactory, T1> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetImportJobFactory, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, DatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DatasetImportJobFactory, T1, T2, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<DatasetImportJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetImportJobFactory, T2, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, DatasetImportJobFactory, T2> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetImportJobFactory, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, DatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DatasetImportJobFactory, T1, T2, T3, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<DatasetImportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetImportJobFactory, T2, T3, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, DatasetImportJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetImportJobFactory, T3, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, DatasetImportJobFactory, T3> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetImportJobFactory, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, DatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DatasetImportJobFactory, T1, T2, T3, T4, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<DatasetImportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DatasetImportJobFactory, T2, T3, T4, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, DatasetImportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DatasetImportJobFactory, T3, T4, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, DatasetImportJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DatasetImportJobFactory, T4, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DatasetImportJobFactory, T4> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DatasetImportJobFactory, InnerDatasetImportJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DatasetImportJobFactory> combinedResult, Action<Humidifier.Personalize.DatasetImportJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction).T2);
}
