// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerFileSystemBackupPolicyFactory(Action<Humidifier.EFS.FileSystemTypes.BackupPolicy> factoryAction = null) : SubResourceFactory<Humidifier.EFS.FileSystemTypes.BackupPolicy>
{

    protected override Humidifier.EFS.FileSystemTypes.BackupPolicy Create()
    {
        var backupPolicyResult = CreateBackupPolicy();
        factoryAction?.Invoke(backupPolicyResult);

        return backupPolicyResult;
    }

    private Humidifier.EFS.FileSystemTypes.BackupPolicy CreateBackupPolicy()
    {
        var backupPolicyResult = new Humidifier.EFS.FileSystemTypes.BackupPolicy();

        return backupPolicyResult;
    }

} // End Of Class

public static class InnerFileSystemBackupPolicyFactoryExtensions
{
}
