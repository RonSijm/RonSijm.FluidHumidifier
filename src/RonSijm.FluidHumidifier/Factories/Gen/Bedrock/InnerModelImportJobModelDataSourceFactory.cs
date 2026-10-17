// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerModelImportJobModelDataSourceFactory(Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource>
{

    internal InnerModelImportJobS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource Create()
    {
        var modelDataSourceResult = CreateModelDataSource();
        factoryAction?.Invoke(modelDataSourceResult);

        return modelDataSourceResult;
    }

    private Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource CreateModelDataSource()
    {
        var modelDataSourceResult = new Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource();

        return modelDataSourceResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerModelImportJobModelDataSourceFactoryExtensions
{
    public static CombinedResult<InnerModelImportJobModelDataSourceFactory, InnerModelImportJobS3DataSourceFactory> WithS3DataSource(this InnerModelImportJobModelDataSourceFactory parentFactory, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerModelImportJobS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerModelImportJobModelDataSourceFactory, T1> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerModelImportJobModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, T2, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, T2, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, T2> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerModelImportJobModelDataSourceFactory, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerModelImportJobModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, T2, T3, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, T2, T3, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerModelImportJobModelDataSourceFactory, T3, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelImportJobModelDataSourceFactory, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerModelImportJobModelDataSourceFactory, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelImportJobModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, T2, T3, T4, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerModelImportJobModelDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, T2, T3, T4, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelImportJobModelDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerModelImportJobModelDataSourceFactory, T3, T4, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelImportJobModelDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerModelImportJobModelDataSourceFactory, T4, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelImportJobModelDataSourceFactory, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerModelImportJobModelDataSourceFactory, InnerModelImportJobS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelImportJobModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
