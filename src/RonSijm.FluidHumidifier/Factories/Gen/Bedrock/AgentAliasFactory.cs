// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class AgentAliasFactory(string resourceName = null, Action<Humidifier.Bedrock.AgentAlias> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.AgentAlias>(resourceName)
{

    internal List<InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> RoutingConfigurationFactories { get; set; } = [];

    protected override Humidifier.Bedrock.AgentAlias Create()
    {
        var agentAliasResult = CreateAgentAlias();
        factoryAction?.Invoke(agentAliasResult);

        return agentAliasResult;
    }

    private Humidifier.Bedrock.AgentAlias CreateAgentAlias()
    {
        var agentAliasResult = new Humidifier.Bedrock.AgentAlias
        {
            GivenName = InputResourceName,
        };

        return agentAliasResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.AgentAlias result)
    {
        base.CreateChildren(result);

        result.RoutingConfiguration = RoutingConfigurationFactories.Any() ? RoutingConfigurationFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AgentAliasFactoryExtensions
{
    public static CombinedResult<AgentAliasFactory, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration(this AgentAliasFactory parentFactory, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null)
    {
        var factory = new InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory(subFactoryAction);
        parentFactory.RoutingConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AgentAliasFactory, T1, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1>(this CombinedResult<AgentAliasFactory, T1> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AgentAliasFactory, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1>(this CombinedResult<T1, AgentAliasFactory> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AgentAliasFactory, T1, T2, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<AgentAliasFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AgentAliasFactory, T2, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<T1, AgentAliasFactory, T2> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AgentAliasFactory, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2>(this CombinedResult<T1, T2, AgentAliasFactory> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AgentAliasFactory, T1, T2, T3, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<AgentAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AgentAliasFactory, T2, T3, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, AgentAliasFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AgentAliasFactory, T3, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AgentAliasFactory, T3> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AgentAliasFactory, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentAliasFactory> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AgentAliasFactory, T1, T2, T3, T4, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<AgentAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AgentAliasFactory, T2, T3, T4, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AgentAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AgentAliasFactory, T3, T4, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentAliasFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AgentAliasFactory, T4, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentAliasFactory, T4> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AgentAliasFactory, InnerAgentAliasAgentAliasRoutingConfigurationListItemFactory> WithRoutingConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentAliasFactory> combinedResult, Action<Humidifier.Bedrock.AgentAliasTypes.AgentAliasRoutingConfigurationListItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfiguration(combinedResult.T5, subFactoryAction));
}
