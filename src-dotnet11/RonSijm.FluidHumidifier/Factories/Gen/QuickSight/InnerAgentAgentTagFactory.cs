// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAgentAgentTagFactory(Action<Humidifier.QuickSight.AgentTypes.AgentTag> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AgentTypes.AgentTag>
{

    protected override Humidifier.QuickSight.AgentTypes.AgentTag Create()
    {
        var agentTagResult = CreateAgentTag();
        factoryAction?.Invoke(agentTagResult);

        return agentTagResult;
    }

    private Humidifier.QuickSight.AgentTypes.AgentTag CreateAgentTag()
    {
        var agentTagResult = new Humidifier.QuickSight.AgentTypes.AgentTag();

        return agentTagResult;
    }

} // End Of Class

public static class InnerAgentAgentTagFactoryExtensions
{
}
