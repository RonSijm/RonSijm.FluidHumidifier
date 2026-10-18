// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBClusterAutomatedBackupFactory(string resourceName = null, Action<Humidifier.RDS.DBClusterAutomatedBackup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBClusterAutomatedBackup>(resourceName)
{

    protected override Humidifier.RDS.DBClusterAutomatedBackup Create()
    {
        var dBClusterAutomatedBackupResult = CreateDBClusterAutomatedBackup();
        factoryAction?.Invoke(dBClusterAutomatedBackupResult);

        return dBClusterAutomatedBackupResult;
    }

    private Humidifier.RDS.DBClusterAutomatedBackup CreateDBClusterAutomatedBackup()
    {
        var dBClusterAutomatedBackupResult = new Humidifier.RDS.DBClusterAutomatedBackup
        {
            GivenName = InputResourceName,
        };

        return dBClusterAutomatedBackupResult;
    }

} // End Of Class

public static class DBClusterAutomatedBackupFactoryExtensions
{
}
