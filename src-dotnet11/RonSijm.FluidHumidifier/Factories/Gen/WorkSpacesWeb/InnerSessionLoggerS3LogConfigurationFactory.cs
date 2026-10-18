// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerSessionLoggerS3LogConfigurationFactory(Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration>
{

    protected override Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration Create()
    {
        var s3LogConfigurationResult = CreateS3LogConfiguration();
        factoryAction?.Invoke(s3LogConfigurationResult);

        return s3LogConfigurationResult;
    }

    private Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration CreateS3LogConfiguration()
    {
        var s3LogConfigurationResult = new Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration();

        return s3LogConfigurationResult;
    }

} // End Of Class

public static class InnerSessionLoggerS3LogConfigurationFactoryExtensions
{
}
