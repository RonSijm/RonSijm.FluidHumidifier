// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketMetadataTableEncryptionConfigurationFactory(Action<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration>
{

    protected override Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration Create()
    {
        var metadataTableEncryptionConfigurationResult = CreateMetadataTableEncryptionConfiguration();
        factoryAction?.Invoke(metadataTableEncryptionConfigurationResult);

        return metadataTableEncryptionConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration CreateMetadataTableEncryptionConfiguration()
    {
        var metadataTableEncryptionConfigurationResult = new Humidifier.S3.BucketTypes.MetadataTableEncryptionConfiguration();

        return metadataTableEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerBucketMetadataTableEncryptionConfigurationFactoryExtensions
{
}
