// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableBucketStorageClassConfigurationFactory(Action<Humidifier.S3Tables.TableBucketTypes.StorageClassConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableBucketTypes.StorageClassConfiguration>
{

    protected override Humidifier.S3Tables.TableBucketTypes.StorageClassConfiguration Create()
    {
        var storageClassConfigurationResult = CreateStorageClassConfiguration();
        factoryAction?.Invoke(storageClassConfigurationResult);

        return storageClassConfigurationResult;
    }

    private Humidifier.S3Tables.TableBucketTypes.StorageClassConfiguration CreateStorageClassConfiguration()
    {
        var storageClassConfigurationResult = new Humidifier.S3Tables.TableBucketTypes.StorageClassConfiguration();

        return storageClassConfigurationResult;
    }

} // End Of Class

public static class InnerTableBucketStorageClassConfigurationFactoryExtensions
{
}
