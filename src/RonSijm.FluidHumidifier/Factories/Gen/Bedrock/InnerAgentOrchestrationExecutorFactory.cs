// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentOrchestrationExecutorFactory(Action<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.OrchestrationExecutor>
{

    protected override Humidifier.Bedrock.AgentTypes.OrchestrationExecutor Create()
    {
        var orchestrationExecutorResult = CreateOrchestrationExecutor();
        factoryAction?.Invoke(orchestrationExecutorResult);

        return orchestrationExecutorResult;
    }

    private Humidifier.Bedrock.AgentTypes.OrchestrationExecutor CreateOrchestrationExecutor()
    {
        var orchestrationExecutorResult = new Humidifier.Bedrock.AgentTypes.OrchestrationExecutor();

        return orchestrationExecutorResult;
    }

} // End Of Class

public static class InnerAgentOrchestrationExecutorFactoryExtensions
{
}
