// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentCustomOrchestrationFactory(Action<Humidifier.Bedrock.AgentTypes.CustomOrchestration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.CustomOrchestration>
{

    internal InnerAgentOrchestrationExecutorFactory ExecutorFactory { get; set; }

    protected override Humidifier.Bedrock.AgentTypes.CustomOrchestration Create()
    {
        var customOrchestrationResult = CreateCustomOrchestration();
        factoryAction?.Invoke(customOrchestrationResult);

        return customOrchestrationResult;
    }

    private Humidifier.Bedrock.AgentTypes.CustomOrchestration CreateCustomOrchestration()
    {
        var customOrchestrationResult = new Humidifier.Bedrock.AgentTypes.CustomOrchestration();

        return customOrchestrationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.AgentTypes.CustomOrchestration result)
    {
        base.CreateChildren(result);

        result.Executor ??= ExecutorFactory?.Build();
    }

} // End Of Class

public static class InnerAgentCustomOrchestrationFactoryExtensions
{
    public static CombinedResult<InnerAgentCustomOrchestrationFactory, InnerAgentOrchestrationExecutorFactory> WithExecutor(this InnerAgentCustomOrchestrationFactory parentFactory, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null)
    {
        parentFactory.ExecutorFactory = new InnerAgentOrchestrationExecutorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExecutorFactory);
    }

    public static CombinedResult<InnerAgentCustomOrchestrationFactory, T1, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1>(this CombinedResult<InnerAgentCustomOrchestrationFactory, T1> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecutor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomOrchestrationFactory, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1>(this CombinedResult<T1, InnerAgentCustomOrchestrationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, WithExecutor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomOrchestrationFactory, T1, T2, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2>(this CombinedResult<InnerAgentCustomOrchestrationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomOrchestrationFactory, T2, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2>(this CombinedResult<T1, InnerAgentCustomOrchestrationFactory, T2> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomOrchestrationFactory, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2>(this CombinedResult<T1, T2, InnerAgentCustomOrchestrationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomOrchestrationFactory, T1, T2, T3, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3>(this CombinedResult<InnerAgentCustomOrchestrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomOrchestrationFactory, T2, T3, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3>(this CombinedResult<T1, InnerAgentCustomOrchestrationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomOrchestrationFactory, T3, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3>(this CombinedResult<T1, T2, InnerAgentCustomOrchestrationFactory, T3> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentCustomOrchestrationFactory, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAgentCustomOrchestrationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAgentCustomOrchestrationFactory, T1, T2, T3, T4, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3, T4>(this CombinedResult<InnerAgentCustomOrchestrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAgentCustomOrchestrationFactory, T2, T3, T4, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3, T4>(this CombinedResult<T1, InnerAgentCustomOrchestrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAgentCustomOrchestrationFactory, T3, T4, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAgentCustomOrchestrationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAgentCustomOrchestrationFactory, T4, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAgentCustomOrchestrationFactory, T4> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAgentCustomOrchestrationFactory, InnerAgentOrchestrationExecutorFactory> WithExecutor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAgentCustomOrchestrationFactory> combinedResult, Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExecutor(combinedResult.T5, subFactoryAction).T2);
}
