// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class ClusterSnapshotFactory(string resourceName = null, Action<Humidifier.RDS.ClusterSnapshot> factoryAction = null) : ResourceFactory<Humidifier.RDS.ClusterSnapshot>(resourceName)
{

    protected override Humidifier.RDS.ClusterSnapshot Create()
    {
        var clusterSnapshotResult = CreateClusterSnapshot();
        factoryAction?.Invoke(clusterSnapshotResult);

        return clusterSnapshotResult;
    }

    private Humidifier.RDS.ClusterSnapshot CreateClusterSnapshot()
    {
        var clusterSnapshotResult = new Humidifier.RDS.ClusterSnapshot
        {
            GivenName = InputResourceName,
        };

        return clusterSnapshotResult;
    }

} // End Of Class

public static class ClusterSnapshotFactoryExtensions
{
}
