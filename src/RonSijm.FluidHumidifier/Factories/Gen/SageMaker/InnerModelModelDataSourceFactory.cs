// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelModelDataSourceFactory(Action<Humidifier.SageMaker.ModelTypes.ModelDataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.ModelDataSource>
{

    internal InnerModelS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.ModelTypes.ModelDataSource Create()
    {
        var modelDataSourceResult = CreateModelDataSource();
        factoryAction?.Invoke(modelDataSourceResult);

        return modelDataSourceResult;
    }

    private Humidifier.SageMaker.ModelTypes.ModelDataSource CreateModelDataSource()
    {
        var modelDataSourceResult = new Humidifier.SageMaker.ModelTypes.ModelDataSource();

        return modelDataSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelTypes.ModelDataSource result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerModelModelDataSourceFactoryExtensions
{
    public static CombinedResult<InnerModelModelDataSourceFactory, InnerModelS3DataSourceFactory> WithS3DataSource(this InnerModelModelDataSourceFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerModelS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerModelModelDataSourceFactory, T1, InnerModelS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerModelModelDataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelModelDataSourceFactory, InnerModelS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerModelModelDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelModelDataSourceFactory, T1, T2, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerModelModelDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelModelDataSourceFactory, T2, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerModelModelDataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelModelDataSourceFactory, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerModelModelDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelModelDataSourceFactory, T1, T2, T3, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerModelModelDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelModelDataSourceFactory, T2, T3, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerModelModelDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelModelDataSourceFactory, T3, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelModelDataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelModelDataSourceFactory, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelModelDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelModelDataSourceFactory, T1, T2, T3, T4, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerModelModelDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelModelDataSourceFactory, T2, T3, T4, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelModelDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelModelDataSourceFactory, T3, T4, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelModelDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelModelDataSourceFactory, T4, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelModelDataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelModelDataSourceFactory, InnerModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelModelDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction));
}
