// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVSChat;

public class InnerLoggingConfigurationS3DestinationConfigurationFactory(Action<Humidifier.IVSChat.LoggingConfigurationTypes.S3DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVSChat.LoggingConfigurationTypes.S3DestinationConfiguration>
{

    protected override Humidifier.IVSChat.LoggingConfigurationTypes.S3DestinationConfiguration Create()
    {
        var s3DestinationConfigurationResult = CreateS3DestinationConfiguration();
        factoryAction?.Invoke(s3DestinationConfigurationResult);

        return s3DestinationConfigurationResult;
    }

    private Humidifier.IVSChat.LoggingConfigurationTypes.S3DestinationConfiguration CreateS3DestinationConfiguration()
    {
        var s3DestinationConfigurationResult = new Humidifier.IVSChat.LoggingConfigurationTypes.S3DestinationConfiguration();

        return s3DestinationConfigurationResult;
    }

} // End Of Class

public static class InnerLoggingConfigurationS3DestinationConfigurationFactoryExtensions
{
}
