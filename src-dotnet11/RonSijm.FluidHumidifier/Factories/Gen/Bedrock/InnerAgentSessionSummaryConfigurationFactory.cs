// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentSessionSummaryConfigurationFactory(Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration>
{

    protected override Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration Create()
    {
        var sessionSummaryConfigurationResult = CreateSessionSummaryConfiguration();
        factoryAction?.Invoke(sessionSummaryConfigurationResult);

        return sessionSummaryConfigurationResult;
    }

    private Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration CreateSessionSummaryConfiguration()
    {
        var sessionSummaryConfigurationResult = new Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration();

        return sessionSummaryConfigurationResult;
    }

} // End Of Class

public static class InnerAgentSessionSummaryConfigurationFactoryExtensions
{
}
