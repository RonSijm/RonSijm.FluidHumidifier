// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class ClusterPolicyFactory(string resourceName = null, Action<Humidifier.MSK.ClusterPolicy> factoryAction = null) : ResourceFactory<Humidifier.MSK.ClusterPolicy>(resourceName)
{

    protected override Humidifier.MSK.ClusterPolicy Create()
    {
        var clusterPolicyResult = CreateClusterPolicy();
        factoryAction?.Invoke(clusterPolicyResult);

        return clusterPolicyResult;
    }

    private Humidifier.MSK.ClusterPolicy CreateClusterPolicy()
    {
        var clusterPolicyResult = new Humidifier.MSK.ClusterPolicy
        {
            GivenName = InputResourceName,
        };

        return clusterPolicyResult;
    }

} // End Of Class

public static class ClusterPolicyFactoryExtensions
{
}
