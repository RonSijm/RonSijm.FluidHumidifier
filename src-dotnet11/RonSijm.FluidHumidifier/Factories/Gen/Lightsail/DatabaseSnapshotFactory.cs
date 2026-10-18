// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class DatabaseSnapshotFactory(string resourceName = null, Action<Humidifier.Lightsail.DatabaseSnapshot> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.DatabaseSnapshot>(resourceName)
{

    protected override Humidifier.Lightsail.DatabaseSnapshot Create()
    {
        var databaseSnapshotResult = CreateDatabaseSnapshot();
        factoryAction?.Invoke(databaseSnapshotResult);

        return databaseSnapshotResult;
    }

    private Humidifier.Lightsail.DatabaseSnapshot CreateDatabaseSnapshot()
    {
        var databaseSnapshotResult = new Humidifier.Lightsail.DatabaseSnapshot
        {
            GivenName = InputResourceName,
        };

        return databaseSnapshotResult;
    }

} // End Of Class

public static class DatabaseSnapshotFactoryExtensions
{
}
