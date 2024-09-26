// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerRecordingConfigurationS3DestinationConfigurationFactory(Action<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration>
{

    protected override Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration Create()
    {
        var s3DestinationConfigurationResult = CreateS3DestinationConfiguration();
        factoryAction?.Invoke(s3DestinationConfigurationResult);

        return s3DestinationConfigurationResult;
    }

    private Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration CreateS3DestinationConfiguration()
    {
        var s3DestinationConfigurationResult = new Humidifier.IVS.RecordingConfigurationTypes.S3DestinationConfiguration();

        return s3DestinationConfigurationResult;
    }

} // End Of Class

public static class InnerRecordingConfigurationS3DestinationConfigurationFactoryExtensions
{
}
