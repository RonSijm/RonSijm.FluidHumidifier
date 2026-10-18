// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationS3ContentBaseLocationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation Create()
    {
        var s3ContentBaseLocationResult = CreateS3ContentBaseLocation();
        factoryAction?.Invoke(s3ContentBaseLocationResult);

        return s3ContentBaseLocationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation CreateS3ContentBaseLocation()
    {
        var s3ContentBaseLocationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentBaseLocation();

        return s3ContentBaseLocationResult;
    }

} // End Of Class

public static class InnerApplicationS3ContentBaseLocationFactoryExtensions
{
}
