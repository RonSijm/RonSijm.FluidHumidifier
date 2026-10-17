// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDBElastic;

public class ClusterSnapshotFactory(string resourceName = null, Action<Humidifier.DocDBElastic.ClusterSnapshot> factoryAction = null) : ResourceFactory<Humidifier.DocDBElastic.ClusterSnapshot>(resourceName)
{

    protected override Humidifier.DocDBElastic.ClusterSnapshot Create()
    {
        var clusterSnapshotResult = CreateClusterSnapshot();
        factoryAction?.Invoke(clusterSnapshotResult);

        return clusterSnapshotResult;
    }

    private Humidifier.DocDBElastic.ClusterSnapshot CreateClusterSnapshot()
    {
        var clusterSnapshotResult = new Humidifier.DocDBElastic.ClusterSnapshot
        {
            GivenName = InputResourceName,
        };

        return clusterSnapshotResult;
    }

} // End Of Class

public static class ClusterSnapshotFactoryExtensions
{
}
