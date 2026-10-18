// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelS3StorageConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration>
{

    protected override Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration Create()
    {
        var s3StorageConfigurationResult = CreateS3StorageConfiguration();
        factoryAction?.Invoke(s3StorageConfigurationResult);

        return s3StorageConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration CreateS3StorageConfiguration()
    {
        var s3StorageConfigurationResult = new Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration();

        return s3StorageConfigurationResult;
    }

} // End Of Class

public static class InnerChannelS3StorageConfigurationFactoryExtensions
{
}
