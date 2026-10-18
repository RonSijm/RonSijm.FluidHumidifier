// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigCloudWatchOutputConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig Create()
    {
        var cloudWatchOutputConfigResult = CreateCloudWatchOutputConfig();
        factoryAction?.Invoke(cloudWatchOutputConfigResult);

        return cloudWatchOutputConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig CreateCloudWatchOutputConfig()
    {
        var cloudWatchOutputConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig();

        return cloudWatchOutputConfigResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigCloudWatchOutputConfigFactoryExtensions
{
}
