// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class ServerlessCacheSnapshotFactory(string resourceName = null, Action<Humidifier.ElastiCache.ServerlessCacheSnapshot> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.ServerlessCacheSnapshot>(resourceName)
{

    protected override Humidifier.ElastiCache.ServerlessCacheSnapshot Create()
    {
        var serverlessCacheSnapshotResult = CreateServerlessCacheSnapshot();
        factoryAction?.Invoke(serverlessCacheSnapshotResult);

        return serverlessCacheSnapshotResult;
    }

    private Humidifier.ElastiCache.ServerlessCacheSnapshot CreateServerlessCacheSnapshot()
    {
        var serverlessCacheSnapshotResult = new Humidifier.ElastiCache.ServerlessCacheSnapshot
        {
            GivenName = InputResourceName,
        };

        return serverlessCacheSnapshotResult;
    }

} // End Of Class

public static class ServerlessCacheSnapshotFactoryExtensions
{
}
