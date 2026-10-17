// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableBucketEncryptionConfigurationFactory(Action<Humidifier.S3Tables.TableBucketTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableBucketTypes.EncryptionConfiguration>
{

    protected override Humidifier.S3Tables.TableBucketTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.S3Tables.TableBucketTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.S3Tables.TableBucketTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerTableBucketEncryptionConfigurationFactoryExtensions
{
}
