// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterHorizontalPodAutoscalerControllerConfigFactory(Action<Humidifier.EKS.ClusterTypes.HorizontalPodAutoscalerControllerConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.HorizontalPodAutoscalerControllerConfig>
{

    protected override Humidifier.EKS.ClusterTypes.HorizontalPodAutoscalerControllerConfig Create()
    {
        var horizontalPodAutoscalerControllerConfigResult = CreateHorizontalPodAutoscalerControllerConfig();
        factoryAction?.Invoke(horizontalPodAutoscalerControllerConfigResult);

        return horizontalPodAutoscalerControllerConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.HorizontalPodAutoscalerControllerConfig CreateHorizontalPodAutoscalerControllerConfig()
    {
        var horizontalPodAutoscalerControllerConfigResult = new Humidifier.EKS.ClusterTypes.HorizontalPodAutoscalerControllerConfig();

        return horizontalPodAutoscalerControllerConfigResult;
    }

} // End Of Class

public static class InnerClusterHorizontalPodAutoscalerControllerConfigFactoryExtensions
{
}
