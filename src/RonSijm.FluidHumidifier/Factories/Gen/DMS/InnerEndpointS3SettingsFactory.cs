// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointS3SettingsFactory(Action<Humidifier.DMS.EndpointTypes.S3Settings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.S3Settings>
{

    protected override Humidifier.DMS.EndpointTypes.S3Settings Create()
    {
        var s3SettingsResult = CreateS3Settings();
        factoryAction?.Invoke(s3SettingsResult);

        return s3SettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.S3Settings CreateS3Settings()
    {
        var s3SettingsResult = new Humidifier.DMS.EndpointTypes.S3Settings();

        return s3SettingsResult;
    }

} // End Of Class

public static class InnerEndpointS3SettingsFactoryExtensions
{
}
