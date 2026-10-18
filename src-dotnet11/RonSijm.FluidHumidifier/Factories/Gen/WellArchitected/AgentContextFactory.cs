// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class AgentContextFactory(string resourceName = null, Action<Humidifier.WellArchitected.AgentContext> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.AgentContext>(resourceName)
{

    protected override Humidifier.WellArchitected.AgentContext Create()
    {
        var agentContextResult = CreateAgentContext();
        factoryAction?.Invoke(agentContextResult);

        return agentContextResult;
    }

    private Humidifier.WellArchitected.AgentContext CreateAgentContext()
    {
        var agentContextResult = new Humidifier.WellArchitected.AgentContext
        {
            GivenName = InputResourceName,
        };

        return agentContextResult;
    }

} // End Of Class

public static class AgentContextFactoryExtensions
{
}
