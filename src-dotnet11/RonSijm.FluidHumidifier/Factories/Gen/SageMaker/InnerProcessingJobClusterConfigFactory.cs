// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobClusterConfigFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig();

        return clusterConfigResult;
    }

} // End Of Class

public static class InnerProcessingJobClusterConfigFactoryExtensions
{
}
