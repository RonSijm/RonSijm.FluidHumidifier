// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionClusterConfigFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig();

        return clusterConfigResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionClusterConfigFactoryExtensions
{
}
