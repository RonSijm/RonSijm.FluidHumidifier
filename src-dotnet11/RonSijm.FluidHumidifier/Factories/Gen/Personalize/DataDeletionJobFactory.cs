// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class DataDeletionJobFactory(string resourceName = null, Action<Humidifier.Personalize.DataDeletionJob> factoryAction = null) : ResourceFactory<Humidifier.Personalize.DataDeletionJob>(resourceName)
{

    internal InnerDataDeletionJobDataSourceFactory DataSourceFactory { get; set; }

    protected override Humidifier.Personalize.DataDeletionJob Create()
    {
        var dataDeletionJobResult = CreateDataDeletionJob();
        factoryAction?.Invoke(dataDeletionJobResult);

        return dataDeletionJobResult;
    }

    private Humidifier.Personalize.DataDeletionJob CreateDataDeletionJob()
    {
        var dataDeletionJobResult = new Humidifier.Personalize.DataDeletionJob
        {
            GivenName = InputResourceName,
        };

        return dataDeletionJobResult;
    }
    public override void CreateChildren(Humidifier.Personalize.DataDeletionJob result)
    {
        base.CreateChildren(result);

        result.DataSource ??= DataSourceFactory?.Build();
    }

} // End Of Class

public static class DataDeletionJobFactoryExtensions
{
    public static CombinedResult<DataDeletionJobFactory, InnerDataDeletionJobDataSourceFactory> WithDataSource(this DataDeletionJobFactory parentFactory, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null)
    {
        parentFactory.DataSourceFactory = new InnerDataDeletionJobDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSourceFactory);
    }

    public static CombinedResult<DataDeletionJobFactory, T1, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<DataDeletionJobFactory, T1> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataDeletionJobFactory, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1>(this CombinedResult<T1, DataDeletionJobFactory> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataDeletionJobFactory, T1, T2, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<DataDeletionJobFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataDeletionJobFactory, T2, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, DataDeletionJobFactory, T2> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataDeletionJobFactory, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2>(this CombinedResult<T1, T2, DataDeletionJobFactory> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataDeletionJobFactory, T1, T2, T3, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<DataDeletionJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataDeletionJobFactory, T2, T3, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, DataDeletionJobFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataDeletionJobFactory, T3, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, DataDeletionJobFactory, T3> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataDeletionJobFactory, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataDeletionJobFactory> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataDeletionJobFactory, T1, T2, T3, T4, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<DataDeletionJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataDeletionJobFactory, T2, T3, T4, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, DataDeletionJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataDeletionJobFactory, T3, T4, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataDeletionJobFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataDeletionJobFactory, T4, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataDeletionJobFactory, T4> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataDeletionJobFactory, InnerDataDeletionJobDataSourceFactory> WithDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataDeletionJobFactory> combinedResult, Action<Humidifier.Personalize.DataDeletionJobTypes.DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSource(combinedResult.T5, subFactoryAction).T2);
}
