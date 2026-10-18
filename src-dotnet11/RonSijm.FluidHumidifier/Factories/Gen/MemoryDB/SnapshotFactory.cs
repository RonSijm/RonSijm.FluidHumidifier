// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class SnapshotFactory(string resourceName = null, Action<Humidifier.MemoryDB.Snapshot> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.Snapshot>(resourceName)
{

    protected override Humidifier.MemoryDB.Snapshot Create()
    {
        var snapshotResult = CreateSnapshot();
        factoryAction?.Invoke(snapshotResult);

        return snapshotResult;
    }

    private Humidifier.MemoryDB.Snapshot CreateSnapshot()
    {
        var snapshotResult = new Humidifier.MemoryDB.Snapshot
        {
            GivenName = InputResourceName,
        };

        return snapshotResult;
    }

} // End Of Class

public static class SnapshotFactoryExtensions
{
}
