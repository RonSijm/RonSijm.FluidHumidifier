// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudHSMV2;

public class BackupFactory(string resourceName = null, Action<Humidifier.CloudHSMV2.Backup> factoryAction = null) : ResourceFactory<Humidifier.CloudHSMV2.Backup>(resourceName)
{

    protected override Humidifier.CloudHSMV2.Backup Create()
    {
        var backupResult = CreateBackup();
        factoryAction?.Invoke(backupResult);

        return backupResult;
    }

    private Humidifier.CloudHSMV2.Backup CreateBackup()
    {
        var backupResult = new Humidifier.CloudHSMV2.Backup
        {
            GivenName = InputResourceName,
        };

        return backupResult;
    }

} // End Of Class

public static class BackupFactoryExtensions
{
}
