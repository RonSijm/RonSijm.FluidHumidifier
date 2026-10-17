// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerModelImportJobS3DataSourceFactory(Action<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.ModelImportJobTypes.S3DataSource>
{

    protected override Humidifier.Bedrock.ModelImportJobTypes.S3DataSource Create()
    {
        var s3DataSourceResult = CreateS3DataSource();
        factoryAction?.Invoke(s3DataSourceResult);

        return s3DataSourceResult;
    }

    private Humidifier.Bedrock.ModelImportJobTypes.S3DataSource CreateS3DataSource()
    {
        var s3DataSourceResult = new Humidifier.Bedrock.ModelImportJobTypes.S3DataSource();

        return s3DataSourceResult;
    }

} // End Of Class

public static class InnerModelImportJobS3DataSourceFactoryExtensions
{
}
