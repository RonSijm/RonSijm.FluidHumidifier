// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterKubernetesNetworkConfigFactory(Action<Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig>
{

    protected override Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig Create()
    {
        var kubernetesNetworkConfigResult = CreateKubernetesNetworkConfig();
        factoryAction?.Invoke(kubernetesNetworkConfigResult);

        return kubernetesNetworkConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig CreateKubernetesNetworkConfig()
    {
        var kubernetesNetworkConfigResult = new Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig();

        return kubernetesNetworkConfigResult;
    }

} // End Of Class

public static class InnerClusterKubernetesNetworkConfigFactoryExtensions
{
}
