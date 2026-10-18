// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class ClusterSubnetGroupFactory(string resourceName = null, Action<Humidifier.Redshift.ClusterSubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.Redshift.ClusterSubnetGroup>(resourceName)
{

    protected override Humidifier.Redshift.ClusterSubnetGroup Create()
    {
        var clusterSubnetGroupResult = CreateClusterSubnetGroup();
        factoryAction?.Invoke(clusterSubnetGroupResult);

        return clusterSubnetGroupResult;
    }

    private Humidifier.Redshift.ClusterSubnetGroup CreateClusterSubnetGroup()
    {
        var clusterSubnetGroupResult = new Humidifier.Redshift.ClusterSubnetGroup
        {
            GivenName = InputResourceName,
        };

        return clusterSubnetGroupResult;
    }

} // End Of Class

public static class ClusterSubnetGroupFactoryExtensions
{
}
