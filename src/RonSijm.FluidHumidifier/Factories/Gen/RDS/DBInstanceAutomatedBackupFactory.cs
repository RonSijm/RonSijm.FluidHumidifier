// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBInstanceAutomatedBackupFactory(string resourceName = null, Action<Humidifier.RDS.DBInstanceAutomatedBackup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBInstanceAutomatedBackup>(resourceName)
{

    protected override Humidifier.RDS.DBInstanceAutomatedBackup Create()
    {
        var dBInstanceAutomatedBackupResult = CreateDBInstanceAutomatedBackup();
        factoryAction?.Invoke(dBInstanceAutomatedBackupResult);

        return dBInstanceAutomatedBackupResult;
    }

    private Humidifier.RDS.DBInstanceAutomatedBackup CreateDBInstanceAutomatedBackup()
    {
        var dBInstanceAutomatedBackupResult = new Humidifier.RDS.DBInstanceAutomatedBackup
        {
            GivenName = InputResourceName,
        };

        return dBInstanceAutomatedBackupResult;
    }

} // End Of Class

public static class DBInstanceAutomatedBackupFactoryExtensions
{
}
