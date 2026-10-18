// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDBElastic;

public class ClusterFactory(string resourceName = null, Action<Humidifier.DocDBElastic.Cluster> factoryAction = null) : ResourceFactory<Humidifier.DocDBElastic.Cluster>(resourceName)
{

    protected override Humidifier.DocDBElastic.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.DocDBElastic.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.DocDBElastic.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
}
