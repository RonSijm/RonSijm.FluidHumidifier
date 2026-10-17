// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTTwinMaker;

public class InnerMetadataTransferJobS3DestinationConfigurationFactory(Action<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration>
{

    protected override Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration Create()
    {
        var s3DestinationConfigurationResult = CreateS3DestinationConfiguration();
        factoryAction?.Invoke(s3DestinationConfigurationResult);

        return s3DestinationConfigurationResult;
    }

    private Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration CreateS3DestinationConfiguration()
    {
        var s3DestinationConfigurationResult = new Humidifier.IoTTwinMaker.MetadataTransferJobTypes.S3DestinationConfiguration();

        return s3DestinationConfigurationResult;
    }

} // End Of Class

public static class InnerMetadataTransferJobS3DestinationConfigurationFactoryExtensions
{
}
