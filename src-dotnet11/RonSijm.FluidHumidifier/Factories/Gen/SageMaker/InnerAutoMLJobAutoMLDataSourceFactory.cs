// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLDataSourceFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource>
{

    internal InnerAutoMLJobAutoMLS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource Create()
    {
        var autoMLDataSourceResult = CreateAutoMLDataSource();
        factoryAction?.Invoke(autoMLDataSourceResult);

        return autoMLDataSourceResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource CreateAutoMLDataSource()
    {
        var autoMLDataSourceResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource();

        return autoMLDataSourceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLDataSourceFactoryExtensions
{
    public static CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource(this InnerAutoMLJobAutoMLDataSourceFactory parentFactory, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerAutoMLJobAutoMLS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, T2, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, T2, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, T2> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLDataSourceFactory, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, T2, T3, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, T2, T3, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLDataSourceFactory, T3, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLDataSourceFactory, T3> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLDataSourceFactory, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, T2, T3, T4, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerAutoMLJobAutoMLDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, T2, T3, T4, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerAutoMLJobAutoMLDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAutoMLJobAutoMLDataSourceFactory, T3, T4, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAutoMLJobAutoMLDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLDataSourceFactory, T4, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAutoMLJobAutoMLDataSourceFactory, T4> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLDataSourceFactory, InnerAutoMLJobAutoMLS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAutoMLJobAutoMLDataSourceFactory> combinedResult, Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
