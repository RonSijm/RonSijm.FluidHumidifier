// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionClusterConfigFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig();

        return clusterConfigResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionClusterConfigFactoryExtensions
{
}
