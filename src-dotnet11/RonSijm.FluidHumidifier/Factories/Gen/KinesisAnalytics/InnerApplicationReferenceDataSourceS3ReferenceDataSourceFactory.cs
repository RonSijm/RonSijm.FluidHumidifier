// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationReferenceDataSourceS3ReferenceDataSourceFactory(Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource>
{

    protected override Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource Create()
    {
        var s3ReferenceDataSourceResult = CreateS3ReferenceDataSource();
        factoryAction?.Invoke(s3ReferenceDataSourceResult);

        return s3ReferenceDataSourceResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource CreateS3ReferenceDataSource()
    {
        var s3ReferenceDataSourceResult = new Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.S3ReferenceDataSource();

        return s3ReferenceDataSourceResult;
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceS3ReferenceDataSourceFactoryExtensions
{
}
