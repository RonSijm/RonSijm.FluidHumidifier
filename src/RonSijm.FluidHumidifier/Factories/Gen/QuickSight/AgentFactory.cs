// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class AgentFactory(string resourceName = null, Action<Humidifier.QuickSight.Agent> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Agent>(resourceName)
{

    internal List<InnerAgentAgentTagFactory> TagsFactories { get; set; } = [];

    internal InnerAgentCustomPromptInputFactory CustomPromptInputFactory { get; set; }

    protected override Humidifier.QuickSight.Agent Create()
    {
        var agentResult = CreateAgent();
        factoryAction?.Invoke(agentResult);

        return agentResult;
    }

    private Humidifier.QuickSight.Agent CreateAgent()
    {
        var agentResult = new Humidifier.QuickSight.Agent
        {
            GivenName = InputResourceName,
        };

        return agentResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Agent result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.CustomPromptInput ??= CustomPromptInputFactory?.Build();
    }

} // End Of Class

public static class AgentFactoryExtensions
{
    public static CombinedResult<AgentFactory, InnerAgentAgentTagFactory> WithTags(this AgentFactory parentFactory, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null)
    {
        var factory = new InnerAgentAgentTagFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AgentFactory, InnerAgentCustomPromptInputFactory> WithCustomPromptInput(this AgentFactory parentFactory, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null)
    {
        parentFactory.CustomPromptInputFactory = new InnerAgentCustomPromptInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomPromptInputFactory);
    }

    public static CombinedResult<AgentFactory, T1, InnerAgentAgentTagFactory> WithTags<T1>(this CombinedResult<AgentFactory, T1> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, InnerAgentAgentTagFactory> WithTags<T1>(this CombinedResult<T1, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, T2, InnerAgentAgentTagFactory> WithTags<T1, T2>(this CombinedResult<AgentFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, T2, InnerAgentAgentTagFactory> WithTags<T1, T2>(this CombinedResult<T1, AgentFactory, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentFactory, InnerAgentAgentTagFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, T2, T3, InnerAgentAgentTagFactory> WithTags<T1, T2, T3>(this CombinedResult<AgentFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, T2, T3, InnerAgentAgentTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, AgentFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentFactory, T3, InnerAgentAgentTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, AgentFactory, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentFactory, InnerAgentAgentTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, T2, T3, T4, InnerAgentAgentTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<AgentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, T2, T3, T4, InnerAgentAgentTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, AgentFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentFactory, T3, T4, InnerAgentAgentTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentFactory, T4, InnerAgentAgentTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentFactory, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentFactory, InnerAgentAgentTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.AgentTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1>(this CombinedResult<AgentFactory, T1> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1>(this CombinedResult<T1, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, T2, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2>(this CombinedResult<AgentFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, T2, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2>(this CombinedResult<T1, AgentFactory, T2> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentFactory, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2>(this CombinedResult<T1, T2, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, T2, T3, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3>(this CombinedResult<AgentFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, T2, T3, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3>(this CombinedResult<T1, AgentFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentFactory, T3, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3>(this CombinedResult<T1, T2, AgentFactory, T3> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentFactory, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentFactory, T1, T2, T3, T4, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3, T4>(this CombinedResult<AgentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentFactory, T2, T3, T4, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3, T4>(this CombinedResult<T1, AgentFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentFactory, T3, T4, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentFactory, T4, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentFactory, T4> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentFactory, InnerAgentCustomPromptInputFactory> WithCustomPromptInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentFactory> combinedResult, Action<Humidifier.QuickSight.AgentTypes.CustomPromptInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomPromptInput(combinedResult.T5, subFactoryAction).T2);
}
