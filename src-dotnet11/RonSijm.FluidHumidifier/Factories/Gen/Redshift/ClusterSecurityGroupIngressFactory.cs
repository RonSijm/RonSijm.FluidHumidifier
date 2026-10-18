// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class ClusterSecurityGroupIngressFactory(string resourceName = null, Action<Humidifier.Redshift.ClusterSecurityGroupIngress> factoryAction = null) : ResourceFactory<Humidifier.Redshift.ClusterSecurityGroupIngress>(resourceName)
{

    protected override Humidifier.Redshift.ClusterSecurityGroupIngress Create()
    {
        var clusterSecurityGroupIngressResult = CreateClusterSecurityGroupIngress();
        factoryAction?.Invoke(clusterSecurityGroupIngressResult);

        return clusterSecurityGroupIngressResult;
    }

    private Humidifier.Redshift.ClusterSecurityGroupIngress CreateClusterSecurityGroupIngress()
    {
        var clusterSecurityGroupIngressResult = new Humidifier.Redshift.ClusterSecurityGroupIngress
        {
            GivenName = InputResourceName,
        };

        return clusterSecurityGroupIngressResult;
    }

} // End Of Class

public static class ClusterSecurityGroupIngressFactoryExtensions
{
}
