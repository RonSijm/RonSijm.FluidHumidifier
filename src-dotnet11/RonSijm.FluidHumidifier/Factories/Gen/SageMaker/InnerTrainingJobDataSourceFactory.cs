// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobDataSourceFactory(Action<Humidifier.SageMaker.TrainingJobTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.DataSource>
{

    internal InnerTrainingJobFileSystemDataSourceFactory FileSystemDataSourceFactory { get; set; }

    internal InnerTrainingJobS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.TrainingJobTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.SageMaker.TrainingJobTypes.DataSource();

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TrainingJobTypes.DataSource result)
    {
        base.CreateChildren(result);

        result.FileSystemDataSource ??= FileSystemDataSourceFactory?.Build();
        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerTrainingJobDataSourceFactoryExtensions
{
    public static CombinedResult<InnerTrainingJobDataSourceFactory, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource(this InnerTrainingJobDataSourceFactory parentFactory, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null)
    {
        parentFactory.FileSystemDataSourceFactory = new InnerTrainingJobFileSystemDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileSystemDataSourceFactory);
    }

    public static CombinedResult<InnerTrainingJobDataSourceFactory, InnerTrainingJobS3DataSourceFactory> WithS3DataSource(this InnerTrainingJobDataSourceFactory parentFactory, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerTrainingJobS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2>(this CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3, T4, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3, T4>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3, T4, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3, T4, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory, T4, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingJobDataSourceFactory, InnerTrainingJobFileSystemDataSourceFactory> WithFileSystemDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileSystemDataSource(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3, T4, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerTrainingJobDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3, T4, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTrainingJobDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3, T4, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTrainingJobDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory, T4, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTrainingJobDataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTrainingJobDataSourceFactory, InnerTrainingJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTrainingJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TrainingJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
