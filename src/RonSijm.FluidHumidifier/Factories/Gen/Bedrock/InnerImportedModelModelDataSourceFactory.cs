// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerImportedModelModelDataSourceFactory(Action<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.ImportedModelTypes.ModelDataSource>
{

    internal InnerImportedModelS3DataSourceFactory S3DataSourceFactory { get; set; }

    protected override Humidifier.Bedrock.ImportedModelTypes.ModelDataSource Create()
    {
        var modelDataSourceResult = CreateModelDataSource();
        factoryAction?.Invoke(modelDataSourceResult);

        return modelDataSourceResult;
    }

    private Humidifier.Bedrock.ImportedModelTypes.ModelDataSource CreateModelDataSource()
    {
        var modelDataSourceResult = new Humidifier.Bedrock.ImportedModelTypes.ModelDataSource();

        return modelDataSourceResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.ImportedModelTypes.ModelDataSource result)
    {
        base.CreateChildren(result);

        result.S3DataSource ??= S3DataSourceFactory?.Build();
    }

} // End Of Class

public static class InnerImportedModelModelDataSourceFactoryExtensions
{
    public static CombinedResult<InnerImportedModelModelDataSourceFactory, InnerImportedModelS3DataSourceFactory> WithS3DataSource(this InnerImportedModelModelDataSourceFactory parentFactory, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null)
    {
        parentFactory.S3DataSourceFactory = new InnerImportedModelS3DataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3DataSourceFactory);
    }

    public static CombinedResult<InnerImportedModelModelDataSourceFactory, T1, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<InnerImportedModelModelDataSourceFactory, T1> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImportedModelModelDataSourceFactory, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1>(this CombinedResult<T1, InnerImportedModelModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerImportedModelModelDataSourceFactory, T1, T2, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<InnerImportedModelModelDataSourceFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImportedModelModelDataSourceFactory, T2, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, InnerImportedModelModelDataSourceFactory, T2> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerImportedModelModelDataSourceFactory, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2>(this CombinedResult<T1, T2, InnerImportedModelModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerImportedModelModelDataSourceFactory, T1, T2, T3, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<InnerImportedModelModelDataSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImportedModelModelDataSourceFactory, T2, T3, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, InnerImportedModelModelDataSourceFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerImportedModelModelDataSourceFactory, T3, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerImportedModelModelDataSourceFactory, T3> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerImportedModelModelDataSourceFactory, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerImportedModelModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerImportedModelModelDataSourceFactory, T1, T2, T3, T4, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<InnerImportedModelModelDataSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerImportedModelModelDataSourceFactory, T2, T3, T4, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerImportedModelModelDataSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerImportedModelModelDataSourceFactory, T3, T4, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerImportedModelModelDataSourceFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerImportedModelModelDataSourceFactory, T4, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerImportedModelModelDataSourceFactory, T4> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerImportedModelModelDataSourceFactory, InnerImportedModelS3DataSourceFactory> WithS3DataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerImportedModelModelDataSourceFactory> combinedResult, Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3DataSource(combinedResult.T5, subFactoryAction).T2);
}
