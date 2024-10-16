// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationS3ContentLocationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation Create()
    {
        var s3ContentLocationResult = CreateS3ContentLocation();
        factoryAction?.Invoke(s3ContentLocationResult);

        return s3ContentLocationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation CreateS3ContentLocation()
    {
        var s3ContentLocationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.S3ContentLocation();

        return s3ContentLocationResult;
    }

} // End Of Class

public static class InnerApplicationS3ContentLocationFactoryExtensions
{
}
