// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionClusterConfigFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig Create()
    {
        var clusterConfigResult = CreateClusterConfig();
        factoryAction?.Invoke(clusterConfigResult);

        return clusterConfigResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig CreateClusterConfig()
    {
        var clusterConfigResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig();

        return clusterConfigResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionClusterConfigFactoryExtensions
{
}
