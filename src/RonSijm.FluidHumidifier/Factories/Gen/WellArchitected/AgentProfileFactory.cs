// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WellArchitected;

public class AgentProfileFactory(string resourceName = null, Action<Humidifier.WellArchitected.AgentProfile> factoryAction = null) : ResourceFactory<Humidifier.WellArchitected.AgentProfile>(resourceName)
{

    internal List<InnerAgentProfileAggregationConfigurationFactory> AggregationConfigurationFactories { get; set; } = [];

    protected override Humidifier.WellArchitected.AgentProfile Create()
    {
        var agentProfileResult = CreateAgentProfile();
        factoryAction?.Invoke(agentProfileResult);

        return agentProfileResult;
    }

    private Humidifier.WellArchitected.AgentProfile CreateAgentProfile()
    {
        var agentProfileResult = new Humidifier.WellArchitected.AgentProfile
        {
            GivenName = InputResourceName,
        };

        return agentProfileResult;
    }
    public override void CreateChildren(Humidifier.WellArchitected.AgentProfile result)
    {
        base.CreateChildren(result);

        result.AggregationConfiguration = AggregationConfigurationFactories.Any() ? AggregationConfigurationFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AgentProfileFactoryExtensions
{
    public static CombinedResult<AgentProfileFactory, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration(this AgentProfileFactory parentFactory, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null)
    {
        var factory = new InnerAgentProfileAggregationConfigurationFactory(subFactoryAction);
        parentFactory.AggregationConfigurationFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AgentProfileFactory, T1, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1>(this CombinedResult<AgentProfileFactory, T1> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentProfileFactory, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1>(this CombinedResult<T1, AgentProfileFactory> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentProfileFactory, T1, T2, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2>(this CombinedResult<AgentProfileFactory, T1, T2> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentProfileFactory, T2, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2>(this CombinedResult<T1, AgentProfileFactory, T2> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentProfileFactory, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2>(this CombinedResult<T1, T2, AgentProfileFactory> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentProfileFactory, T1, T2, T3, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3>(this CombinedResult<AgentProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentProfileFactory, T2, T3, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3>(this CombinedResult<T1, AgentProfileFactory, T2, T3> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentProfileFactory, T3, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AgentProfileFactory, T3> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentProfileFactory, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentProfileFactory> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentProfileFactory, T1, T2, T3, T4, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3, T4>(this CombinedResult<AgentProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentProfileFactory, T2, T3, T4, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AgentProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentProfileFactory, T3, T4, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentProfileFactory, T3, T4> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentProfileFactory, T4, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentProfileFactory, T4> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentProfileFactory, InnerAgentProfileAggregationConfigurationFactory> WithAggregationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentProfileFactory> combinedResult, Action<Humidifier.WellArchitected.AgentProfileTypes.AggregationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
