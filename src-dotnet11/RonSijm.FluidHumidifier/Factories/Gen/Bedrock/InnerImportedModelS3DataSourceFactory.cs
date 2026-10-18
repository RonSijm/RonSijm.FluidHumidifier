// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerImportedModelS3DataSourceFactory(Action<Humidifier.Bedrock.ImportedModelTypes.S3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.ImportedModelTypes.S3DataSource>
{

    protected override Humidifier.Bedrock.ImportedModelTypes.S3DataSource Create()
    {
        var s3DataSourceResult = CreateS3DataSource();
        factoryAction?.Invoke(s3DataSourceResult);

        return s3DataSourceResult;
    }

    private Humidifier.Bedrock.ImportedModelTypes.S3DataSource CreateS3DataSource()
    {
        var s3DataSourceResult = new Humidifier.Bedrock.ImportedModelTypes.S3DataSource();

        return s3DataSourceResult;
    }

} // End Of Class

public static class InnerImportedModelS3DataSourceFactoryExtensions
{
}
