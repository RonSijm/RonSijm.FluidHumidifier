// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentAgentKnowledgeBaseFactory(Action<Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase>
{

    protected override Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase Create()
    {
        var agentKnowledgeBaseResult = CreateAgentKnowledgeBase();
        factoryAction?.Invoke(agentKnowledgeBaseResult);

        return agentKnowledgeBaseResult;
    }

    private Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase CreateAgentKnowledgeBase()
    {
        var agentKnowledgeBaseResult = new Humidifier.Bedrock.AgentTypes.AgentKnowledgeBase();

        return agentKnowledgeBaseResult;
    }

} // End Of Class

public static class InnerAgentAgentKnowledgeBaseFactoryExtensions
{
}
