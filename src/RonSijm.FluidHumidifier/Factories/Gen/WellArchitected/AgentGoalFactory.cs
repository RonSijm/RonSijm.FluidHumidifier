// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class AgentGoalFactory(string resourceName = null, Action<Humidifier.WellArchitected.AgentGoal> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.AgentGoal>(resourceName)
{

    protected override Humidifier.WellArchitected.AgentGoal Create()
    {
        var agentGoalResult = CreateAgentGoal();
        factoryAction?.Invoke(agentGoalResult);

        return agentGoalResult;
    }

    private Humidifier.WellArchitected.AgentGoal CreateAgentGoal()
    {
        var agentGoalResult = new Humidifier.WellArchitected.AgentGoal
        {
            GivenName = InputResourceName,
        };

        return agentGoalResult;
    }

} // End Of Class

public static class AgentGoalFactoryExtensions
{
}
