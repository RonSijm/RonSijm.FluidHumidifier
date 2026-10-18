// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Vectors;

public class InnerIndexEncryptionConfigurationFactory(Action<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration>
{

    protected override Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerIndexEncryptionConfigurationFactoryExtensions
{
}
