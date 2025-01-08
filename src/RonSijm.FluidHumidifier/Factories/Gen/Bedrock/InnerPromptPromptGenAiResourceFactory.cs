// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptPromptGenAiResourceFactory(Action<Humidifier.Bedrock.PromptTypes.PromptGenAiResource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.PromptGenAiResource>
{

    internal InnerPromptPromptAgentResourceFactory AgentFactory { get; set; }

    protected override Humidifier.Bedrock.PromptTypes.PromptGenAiResource Create()
    {
        var promptGenAiResourceResult = CreatePromptGenAiResource();
        factoryAction?.Invoke(promptGenAiResourceResult);

        return promptGenAiResourceResult;
    }

    private Humidifier.Bedrock.PromptTypes.PromptGenAiResource CreatePromptGenAiResource()
    {
        var promptGenAiResourceResult = new Humidifier.Bedrock.PromptTypes.PromptGenAiResource();

        return promptGenAiResourceResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.PromptTypes.PromptGenAiResource result)
    {
        base.CreateChildren(result);

        result.Agent ??= AgentFactory?.Build();
    }

} // End Of Class

public static class InnerPromptPromptGenAiResourceFactoryExtensions
{
    public static CombinedResult<InnerPromptPromptGenAiResourceFactory, InnerPromptPromptAgentResourceFactory> WithAgent(this InnerPromptPromptGenAiResourceFactory parentFactory, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null)
    {
        parentFactory.AgentFactory = new InnerPromptPromptAgentResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AgentFactory);
    }

    public static CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, InnerPromptPromptAgentResourceFactory> WithAgent<T1>(this CombinedResult<InnerPromptPromptGenAiResourceFactory, T1> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, InnerPromptPromptAgentResourceFactory> WithAgent<T1>(this CombinedResult<T1, InnerPromptPromptGenAiResourceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, T2, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2>(this CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, T2, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2>(this CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, T2> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptGenAiResourceFactory, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2>(this CombinedResult<T1, T2, InnerPromptPromptGenAiResourceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, T2, T3, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3>(this CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, T2, T3, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3>(this CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptGenAiResourceFactory, T3, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3>(this CombinedResult<T1, T2, InnerPromptPromptGenAiResourceFactory, T3> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptGenAiResourceFactory, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPromptPromptGenAiResourceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, T2, T3, T4, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3, T4>(this CombinedResult<InnerPromptPromptGenAiResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, T2, T3, T4, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3, T4>(this CombinedResult<T1, InnerPromptPromptGenAiResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPromptPromptGenAiResourceFactory, T3, T4, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPromptPromptGenAiResourceFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPromptPromptGenAiResourceFactory, T4, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPromptPromptGenAiResourceFactory, T4> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPromptPromptGenAiResourceFactory, InnerPromptPromptAgentResourceFactory> WithAgent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPromptPromptGenAiResourceFactory> combinedResult, Action<Humidifier.Bedrock.PromptTypes.PromptAgentResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAgent(combinedResult.T5, subFactoryAction));
}
