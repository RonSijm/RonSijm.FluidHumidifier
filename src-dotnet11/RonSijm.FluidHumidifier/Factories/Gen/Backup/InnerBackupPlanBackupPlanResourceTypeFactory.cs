// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerBackupPlanBackupPlanResourceTypeFactory(Action<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType> factoryAction = null) : SubResourceFactory<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType>
{

    protected override Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType Create()
    {
        var backupPlanResourceTypeResult = CreateBackupPlanResourceType();
        factoryAction?.Invoke(backupPlanResourceTypeResult);

        return backupPlanResourceTypeResult;
    }

    private Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType CreateBackupPlanResourceType()
    {
        var backupPlanResourceTypeResult = new Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType();

        return backupPlanResourceTypeResult;
    }

} // End Of Class

public static class InnerBackupPlanBackupPlanResourceTypeFactoryExtensions
{
}
