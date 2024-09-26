// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class AgentStatusFactory(string resourceName = null, Action<Humidifier.Connect.AgentStatus> factoryAction = null) : ResourceFactory<Humidifier.Connect.AgentStatus>(resourceName)
{

    protected override Humidifier.Connect.AgentStatus Create()
    {
        var agentStatusResult = CreateAgentStatus();
        factoryAction?.Invoke(agentStatusResult);

        return agentStatusResult;
    }

    private Humidifier.Connect.AgentStatus CreateAgentStatus()
    {
        var agentStatusResult = new Humidifier.Connect.AgentStatus
        {
            GivenName = InputResourceName,
        };

        return agentStatusResult;
    }

} // End Of Class

public static class AgentStatusFactoryExtensions
{
}
