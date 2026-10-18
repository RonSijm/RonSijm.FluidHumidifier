// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearch;

public class InnerDataSourceDataSourceTypeFactory(Action<Humidifier.OpenSearch.DataSourceTypes.DataSourceType> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearch.DataSourceTypes.DataSourceType>
{

    internal InnerDataSourceS3GlueDataCatalogFactory S3GlueDataCatalogFactory { get; set; }

    protected override Humidifier.OpenSearch.DataSourceTypes.DataSourceType Create()
    {
        var dataSourceTypeResult = CreateDataSourceType();
        factoryAction?.Invoke(dataSourceTypeResult);

        return dataSourceTypeResult;
    }

    private Humidifier.OpenSearch.DataSourceTypes.DataSourceType CreateDataSourceType()
    {
        var dataSourceTypeResult = new Humidifier.OpenSearch.DataSourceTypes.DataSourceType();

        return dataSourceTypeResult;
    }
    public override void CreateChildren(Humidifier.OpenSearch.DataSourceTypes.DataSourceType result)
    {
        base.CreateChildren(result);

        result.S3GlueDataCatalog ??= S3GlueDataCatalogFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDataSourceTypeFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDataSourceTypeFactory, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog(this InnerDataSourceDataSourceTypeFactory parentFactory, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null)
    {
        parentFactory.S3GlueDataCatalogFactory = new InnerDataSourceS3GlueDataCatalogFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3GlueDataCatalogFactory);
    }

    public static CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1>(this CombinedResult<InnerDataSourceDataSourceTypeFactory, T1> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1>(this CombinedResult<T1, InnerDataSourceDataSourceTypeFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, T2, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2>(this CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, T2, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2>(this CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, T2> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceTypeFactory, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDataSourceTypeFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, T2, T3, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3>(this CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, T2, T3, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceTypeFactory, T3, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDataSourceTypeFactory, T3> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceTypeFactory, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceTypeFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, T2, T3, T4, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDataSourceTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, T2, T3, T4, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDataSourceTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceTypeFactory, T3, T4, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDataSourceTypeFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceTypeFactory, T4, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceTypeFactory, T4> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceTypeFactory, InnerDataSourceS3GlueDataCatalogFactory> WithS3GlueDataCatalog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceTypeFactory> combinedResult, Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3GlueDataCatalog(combinedResult.T5, subFactoryAction).T2);
}
