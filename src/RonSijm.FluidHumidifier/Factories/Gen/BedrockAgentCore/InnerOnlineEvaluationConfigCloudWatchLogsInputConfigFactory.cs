// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig Create()
    {
        var cloudWatchLogsInputConfigResult = CreateCloudWatchLogsInputConfig();
        factoryAction?.Invoke(cloudWatchLogsInputConfigResult);

        return cloudWatchLogsInputConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig CreateCloudWatchLogsInputConfig()
    {
        var cloudWatchLogsInputConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig();

        return cloudWatchLogsInputConfigResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigCloudWatchLogsInputConfigFactoryExtensions
{
}
