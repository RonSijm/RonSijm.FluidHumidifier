// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class SnapshotFactory(string resourceName = null, Action<Humidifier.ElastiCache.Snapshot> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.Snapshot>(resourceName)
{

    protected override Humidifier.ElastiCache.Snapshot Create()
    {
        var snapshotResult = CreateSnapshot();
        factoryAction?.Invoke(snapshotResult);

        return snapshotResult;
    }

    private Humidifier.ElastiCache.Snapshot CreateSnapshot()
    {
        var snapshotResult = new Humidifier.ElastiCache.Snapshot
        {
            GivenName = InputResourceName,
        };

        return snapshotResult;
    }

} // End Of Class

public static class SnapshotFactoryExtensions
{
}
