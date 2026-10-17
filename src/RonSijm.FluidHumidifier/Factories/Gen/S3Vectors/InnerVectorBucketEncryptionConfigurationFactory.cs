// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Vectors;

public class InnerVectorBucketEncryptionConfigurationFactory(Action<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration>
{

    protected override Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerVectorBucketEncryptionConfigurationFactoryExtensions
{
}
