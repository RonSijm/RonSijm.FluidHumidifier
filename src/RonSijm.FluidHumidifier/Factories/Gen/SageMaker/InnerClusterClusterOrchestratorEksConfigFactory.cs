// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterOrchestratorEksConfigFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig Create()
    {
        var clusterOrchestratorEksConfigResult = CreateClusterOrchestratorEksConfig();
        factoryAction?.Invoke(clusterOrchestratorEksConfigResult);

        return clusterOrchestratorEksConfigResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig CreateClusterOrchestratorEksConfig()
    {
        var clusterOrchestratorEksConfigResult = new Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig();

        return clusterOrchestratorEksConfigResult;
    }

} // End Of Class

public static class InnerClusterClusterOrchestratorEksConfigFactoryExtensions
{
}
