// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearch;

public class InnerDataSourceS3GlueDataCatalogFactory(Action<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog>
{

    protected override Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog Create()
    {
        var s3GlueDataCatalogResult = CreateS3GlueDataCatalog();
        factoryAction?.Invoke(s3GlueDataCatalogResult);

        return s3GlueDataCatalogResult;
    }

    private Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog CreateS3GlueDataCatalog()
    {
        var s3GlueDataCatalogResult = new Humidifier.OpenSearch.DataSourceTypes.S3GlueDataCatalog();

        return s3GlueDataCatalogResult;
    }

} // End Of Class

public static class InnerDataSourceS3GlueDataCatalogFactoryExtensions
{
}
