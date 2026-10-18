// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigClusteringConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig Create()
    {
        var clusteringConfigResult = CreateClusteringConfig();
        factoryAction?.Invoke(clusteringConfigResult);

        return clusteringConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig CreateClusteringConfig()
    {
        var clusteringConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig();

        return clusteringConfigResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigClusteringConfigFactoryExtensions
{
}
