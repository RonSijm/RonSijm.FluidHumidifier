// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory(Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem>
{

    protected override Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem Create()
    {
        var agentAliasRoutingConfigurationListItemResult = CreateAgentAliasRoutingConfigurationListItem();
        factoryAction?.Invoke(agentAliasRoutingConfigurationListItemResult);

        return agentAliasRoutingConfigurationListItemResult;
    }

    private Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem CreateAgentAliasRoutingConfigurationListItem()
    {
        var agentAliasRoutingConfigurationListItemResult = new Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem();

        return agentAliasRoutingConfigurationListItemResult;
    }

} // End Of Class

public static class InnerAgentAliasAgentAliasRoutingConfigurationListItemFactoryExtensions
{
}
