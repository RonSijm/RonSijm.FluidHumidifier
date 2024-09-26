// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class ClusterSecurityGroupFactory(string resourceName = null, Action<Humidifier.Redshift.ClusterSecurityGroup> factoryAction = null) : ResourceFactory<Humidifier.Redshift.ClusterSecurityGroup>(resourceName)
{

    protected override Humidifier.Redshift.ClusterSecurityGroup Create()
    {
        var clusterSecurityGroupResult = CreateClusterSecurityGroup();
        factoryAction?.Invoke(clusterSecurityGroupResult);

        return clusterSecurityGroupResult;
    }

    private Humidifier.Redshift.ClusterSecurityGroup CreateClusterSecurityGroup()
    {
        var clusterSecurityGroupResult = new Humidifier.Redshift.ClusterSecurityGroup
        {
            GivenName = InputResourceName,
        };

        return clusterSecurityGroupResult;
    }

} // End Of Class

public static class ClusterSecurityGroupFactoryExtensions
{
}
