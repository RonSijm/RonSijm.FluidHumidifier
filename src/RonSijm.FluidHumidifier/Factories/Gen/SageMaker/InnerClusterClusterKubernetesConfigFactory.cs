// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterKubernetesConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterKubernetesConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterKubernetesConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterKubernetesConfig Create()
    {
        var clusterKubernetesConfigResult = CreateClusterKubernetesConfig();
        factoryAction?.Invoke(clusterKubernetesConfigResult);

        return clusterKubernetesConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterKubernetesConfig CreateClusterKubernetesConfig()
    {
        var clusterKubernetesConfigResult = new Humidifier.SageMaker.ClusterTypes.ClusterKubernetesConfig();

        return clusterKubernetesConfigResult;
    }

} // End Of Class

public static class InnerClusterClusterKubernetesConfigFactoryExtensions
{
}
