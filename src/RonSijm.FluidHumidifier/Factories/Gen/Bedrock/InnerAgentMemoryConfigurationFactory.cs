// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentMemoryConfigurationFactory(Action<Humidifier.Bedrock.AgentTypes.MemoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.MemoryConfiguration>
{

    internal InnerAgentSessionSummaryConfigurationFactory SessionSummaryConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.AgentTypes.MemoryConfiguration Create()
    {
        var memoryConfigurationResult = CreateMemoryConfiguration();
        factoryAction?.Invoke(memoryConfigurationResult);

        return memoryConfigurationResult;
    }

    private Humidifier.Bedrock.AgentTypes.MemoryConfiguration CreateMemoryConfiguration()
    {
        var memoryConfigurationResult = new Humidifier.Bedrock.AgentTypes.MemoryConfiguration();

        return memoryConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.AgentTypes.MemoryConfiguration result)
    {
        base.CreateChildren(result);

        result.SessionSummaryConfiguration ??= SessionSummaryConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAgentMemoryConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAgentMemoryConfigurationFactory, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration(this InnerAgentMemoryConfigurationFactory parentFactory, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null)
    {
        parentFactory.SessionSummaryConfigurationFactory = new InnerAgentSessionSummaryConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SessionSummaryConfigurationFactory);
    }

    public static CombinedResult<InnerAgentMemoryConfigurationFactory, T1, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1>(this CombinedResult<InnerAgentMemoryConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentMemoryConfigurationFactory, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1>(this CombinedResult<T1, InnerAgentMemoryConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAgentMemoryConfigurationFactory, T1, T2, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2>(this CombinedResult<InnerAgentMemoryConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentMemoryConfigurationFactory, T2, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2>(this CombinedResult<T1, InnerAgentMemoryConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentMemoryConfigurationFactory, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAgentMemoryConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAgentMemoryConfigurationFactory, T1, T2, T3, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3>(this CombinedResult<InnerAgentMemoryConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentMemoryConfigurationFactory, T2, T3, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAgentMemoryConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentMemoryConfigurationFactory, T3, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAgentMemoryConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentMemoryConfigurationFactory, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAgentMemoryConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAgentMemoryConfigurationFactory, T1, T2, T3, T4, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAgentMemoryConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentMemoryConfigurationFactory, T2, T3, T4, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAgentMemoryConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentMemoryConfigurationFactory, T3, T4, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAgentMemoryConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentMemoryConfigurationFactory, T4, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAgentMemoryConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAgentMemoryConfigurationFactory, InnerAgentSessionSummaryConfigurationFactory> WithSessionSummaryConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAgentMemoryConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.SessionSummaryConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSessionSummaryConfiguration(combinedResult.T5, subFactoryAction).T2);
}
