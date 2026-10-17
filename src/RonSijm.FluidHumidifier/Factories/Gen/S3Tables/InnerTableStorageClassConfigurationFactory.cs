// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableStorageClassConfigurationFactory(Action<Humidifier.S3Tables.TableTypes.StorageClassConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.StorageClassConfiguration>
{

    protected override Humidifier.S3Tables.TableTypes.StorageClassConfiguration Create()
    {
        var storageClassConfigurationResult = CreateStorageClassConfiguration();
        factoryAction?.Invoke(storageClassConfigurationResult);

        return storageClassConfigurationResult;
    }

    private Humidifier.S3Tables.TableTypes.StorageClassConfiguration CreateStorageClassConfiguration()
    {
        var storageClassConfigurationResult = new Humidifier.S3Tables.TableTypes.StorageClassConfiguration();

        return storageClassConfigurationResult;
    }

} // End Of Class

public static class InnerTableStorageClassConfigurationFactoryExtensions
{
}
