// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationS3S3ConfigFactory(Action<Humidifier.DataSync.LocationS3Types.S3Config> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationS3Types.S3Config>
{

    protected override Humidifier.DataSync.LocationS3Types.S3Config Create()
    {
        var s3ConfigResult = CreateS3Config();
        factoryAction?.Invoke(s3ConfigResult);

        return s3ConfigResult;
    }

    private Humidifier.DataSync.LocationS3Types.S3Config CreateS3Config()
    {
        var s3ConfigResult = new Humidifier.DataSync.LocationS3Types.S3Config();

        return s3ConfigResult;
    }

} // End Of Class

public static class InnerLocationS3S3ConfigFactoryExtensions
{
}
