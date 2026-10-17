// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterPodGcControllerConfigFactory(Action<Humidifier.EKS.ClusterTypes.PodGcControllerConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.PodGcControllerConfig>
{

    protected override Humidifier.EKS.ClusterTypes.PodGcControllerConfig Create()
    {
        var podGcControllerConfigResult = CreatePodGcControllerConfig();
        factoryAction?.Invoke(podGcControllerConfigResult);

        return podGcControllerConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.PodGcControllerConfig CreatePodGcControllerConfig()
    {
        var podGcControllerConfigResult = new Humidifier.EKS.ClusterTypes.PodGcControllerConfig();

        return podGcControllerConfigResult;
    }

} // End Of Class

public static class InnerClusterPodGcControllerConfigFactoryExtensions
{
}
