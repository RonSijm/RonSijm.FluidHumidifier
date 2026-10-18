// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class BackupFactory(string resourceName = null, Action<Humidifier.FSx.Backup> factoryAction = null) : ResourceFactory<Humidifier.FSx.Backup>(resourceName)
{

    protected override Humidifier.FSx.Backup Create()
    {
        var backupResult = CreateBackup();
        factoryAction?.Invoke(backupResult);

        return backupResult;
    }

    private Humidifier.FSx.Backup CreateBackup()
    {
        var backupResult = new Humidifier.FSx.Backup
        {
            GivenName = InputResourceName,
        };

        return backupResult;
    }

} // End Of Class

public static class BackupFactoryExtensions
{
}
