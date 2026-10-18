// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class ClusterFactory(string resourceName = null, Action<Humidifier.Route53RecoveryControl.Cluster> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryControl.Cluster>(resourceName)
{

    protected override Humidifier.Route53RecoveryControl.Cluster Create()
    {
        var clusterResult = CreateCluster();
        factoryAction?.Invoke(clusterResult);

        return clusterResult;
    }

    private Humidifier.Route53RecoveryControl.Cluster CreateCluster()
    {
        var clusterResult = new Humidifier.Route53RecoveryControl.Cluster
        {
            GivenName = InputResourceName,
        };

        return clusterResult;
    }

} // End Of Class

public static class ClusterFactoryExtensions
{
}
