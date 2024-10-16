// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class AgentFactory(string resourceName = null, Action<Humidifier.DataSync.Agent> factoryAction = null) : ResourceFactory<Humidifier.DataSync.Agent>(resourceName)
{

    protected override Humidifier.DataSync.Agent Create()
    {
        var agentResult = CreateAgent();
        factoryAction?.Invoke(agentResult);

        return agentResult;
    }

    private Humidifier.DataSync.Agent CreateAgent()
    {
        var agentResult = new Humidifier.DataSync.Agent
        {
            GivenName = InputResourceName,
        };

        return agentResult;
    }

} // End Of Class

public static class AgentFactoryExtensions
{
}
