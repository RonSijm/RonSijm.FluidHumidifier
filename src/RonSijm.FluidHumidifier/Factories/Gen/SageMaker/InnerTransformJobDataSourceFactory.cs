// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobDataSourceFactory(Action<Humidifier.SageMaker.TransformJobTypes.DataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.DataSource>
{

    internal InnerTransformJobS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.TransformJobTypes.DataSource Create()
    {
        var dataSourceResult = CreateDataSource();
        factoryAction?.Invoke(dataSourceResult);

        return dataSourceResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.DataSource CreateDataSource()
    {
        var dataSourceResult = new Humidifier.SageMaker.TransformJobTypes.DataSource();

        return dataSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.TransformJobTypes.DataSource result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerTransformJobDataSourceFactoryExtensions
{
    public static CombinedResult<InnerTransformJobDataSourceFactory, InnerTransformJobS3DataSourceFactory> WithS3DataSource(this InnerTransformJobDataSourceFactory parentFactory, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerTransformJobS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerTransformJobDataSourceFactory, T1, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerTransformJobDataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobDataSourceFactory, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerTransformJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTransformJobDataSourceFactory, T1, T2, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerTransformJobDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobDataSourceFactory, T2, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerTransformJobDataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformJobDataSourceFactory, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerTransformJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTransformJobDataSourceFactory, T1, T2, T3, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerTransformJobDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobDataSourceFactory, T2, T3, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerTransformJobDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformJobDataSourceFactory, T3, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTransformJobDataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformJobDataSourceFactory, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTransformJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTransformJobDataSourceFactory, T1, T2, T3, T4, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerTransformJobDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTransformJobDataSourceFactory, T2, T3, T4, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTransformJobDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTransformJobDataSourceFactory, T3, T4, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTransformJobDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTransformJobDataSourceFactory, T4, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTransformJobDataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTransformJobDataSourceFactory, InnerTransformJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTransformJobDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.TransformJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
