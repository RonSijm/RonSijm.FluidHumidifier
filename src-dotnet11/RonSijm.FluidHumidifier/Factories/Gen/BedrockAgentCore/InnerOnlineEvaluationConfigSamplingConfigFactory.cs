// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigSamplingConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig Create()
    {
        var samplingConfigResult = CreateSamplingConfig();
        factoryAction?.Invoke(samplingConfigResult);

        return samplingConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig CreateSamplingConfig()
    {
        var samplingConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig();

        return samplingConfigResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigSamplingConfigFactoryExtensions
{
}
