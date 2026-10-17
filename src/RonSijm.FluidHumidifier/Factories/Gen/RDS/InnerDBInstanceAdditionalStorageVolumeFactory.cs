// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBInstanceAdditionalStorageVolumeFactory(Action<Humidifier.RDS.DBInstanceTypes.AdditionalStorageVolume> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBInstanceTypes.AdditionalStorageVolume>
{

    protected override Humidifier.RDS.DBInstanceTypes.AdditionalStorageVolume Create()
    {
        var additionalStorageVolumeResult = CreateAdditionalStorageVolume();
        factoryAction?.Invoke(additionalStorageVolumeResult);

        return additionalStorageVolumeResult;
    }

    private Humidifier.RDS.DBInstanceTypes.AdditionalStorageVolume CreateAdditionalStorageVolume()
    {
        var additionalStorageVolumeResult = new Humidifier.RDS.DBInstanceTypes.AdditionalStorageVolume();

        return additionalStorageVolumeResult;
    }

} // End Of Class

public static class InnerDBInstanceAdditionalStorageVolumeFactoryExtensions
{
}
