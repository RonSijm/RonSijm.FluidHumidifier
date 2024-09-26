// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationReferenceDataSourceS3ReferenceDataSourceFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource Create()
    {
        var s3ReferenceDataSourceResult = CreateS3ReferenceDataSource();
        factoryAction?.Invoke(s3ReferenceDataSourceResult);

        return s3ReferenceDataSourceResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource CreateS3ReferenceDataSource()
    {
        var s3ReferenceDataSourceResult = new Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource();

        return s3ReferenceDataSourceResult;
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceS3ReferenceDataSourceFactoryExtensions
{
}
