// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerBackupVaultLockConfigurationTypeFactory(Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> factoryAction = null) : SubResourceFactory<Humidifier.Backup.BackupVaultTypes.LockConfigurationType>
{

    protected override Humidifier.Backup.BackupVaultTypes.LockConfigurationType Create()
    {
        var lockConfigurationTypeResult = CreateLockConfigurationType();
        factoryAction?.Invoke(lockConfigurationTypeResult);

        return lockConfigurationTypeResult;
    }

    private Humidifier.Backup.BackupVaultTypes.LockConfigurationType CreateLockConfigurationType()
    {
        var lockConfigurationTypeResult = new Humidifier.Backup.BackupVaultTypes.LockConfigurationType();

        return lockConfigurationTypeResult;
    }

} // End Of Class

public static class InnerBackupVaultLockConfigurationTypeFactoryExtensions
{
}
