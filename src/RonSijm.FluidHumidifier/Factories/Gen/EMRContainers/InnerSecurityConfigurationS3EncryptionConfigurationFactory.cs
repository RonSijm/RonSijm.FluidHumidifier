// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationS3EncryptionConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration Create()
    {
        var s3EncryptionConfigurationResult = CreateS3EncryptionConfiguration();
        factoryAction?.Invoke(s3EncryptionConfigurationResult);

        return s3EncryptionConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration CreateS3EncryptionConfiguration()
    {
        var s3EncryptionConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.S3EncryptionConfiguration();

        return s3EncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationS3EncryptionConfigurationFactoryExtensions
{
}
