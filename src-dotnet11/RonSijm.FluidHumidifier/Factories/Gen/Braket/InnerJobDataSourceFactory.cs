// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobDataSourceFactory(Action<Humidifier.Braket.JobTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.DataSource>
{

    internal InnerJobS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.Braket.JobTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.Braket.JobTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.Braket.JobTypes.DataSource();

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.Braket.JobTypes.DataSource result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerJobDataSourceFactoryExtensions
{
    public static CombinedResult<InnerJobDataSourceFactory, InnerJobS3DataSourceFactory> WithS3DataSource(this InnerJobDataSourceFactory parentFactory, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerJobS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerJobDataSourceFactory, T1, InnerJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerJobDataSourceFactory, T1> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobDataSourceFactory, InnerJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerJobDataSourceFactory> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobDataSourceFactory, T1, T2, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerJobDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobDataSourceFactory, T2, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerJobDataSourceFactory, T2> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobDataSourceFactory, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerJobDataSourceFactory> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobDataSourceFactory, T1, T2, T3, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerJobDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobDataSourceFactory, T2, T3, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerJobDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobDataSourceFactory, T3, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDataSourceFactory, T3> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobDataSourceFactory, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDataSourceFactory> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobDataSourceFactory, T1, T2, T3, T4, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerJobDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobDataSourceFactory, T2, T3, T4, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobDataSourceFactory, T3, T4, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobDataSourceFactory, T4, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDataSourceFactory, T4> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobDataSourceFactory, InnerJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDataSourceFactory> combinedResult, Action<Humidifier.Braket.JobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
