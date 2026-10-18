// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerOnlineEvaluationConfigSessionConfigFactory(Action<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig>
{

    protected override Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig Create()
    {
        var sessionConfigResult = CreateSessionConfig();
        factoryAction?.Invoke(sessionConfigResult);

        return sessionConfigResult;
    }

    private Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig CreateSessionConfig()
    {
        var sessionConfigResult = new Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig();

        return sessionConfigResult;
    }

} // End Of Class

public static class InnerOnlineEvaluationConfigSessionConfigFactoryExtensions
{
}
