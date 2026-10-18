// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentActionGroupExecutorFactory(Action<Humidifier.Bedrock.AgentTypes.ActionGroupExecutor> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.ActionGroupExecutor>
{

    protected override Humidifier.Bedrock.AgentTypes.ActionGroupExecutor Create()
    {
        var actionGroupExecutorResult = CreateActionGroupExecutor();
        factoryAction?.Invoke(actionGroupExecutorResult);

        return actionGroupExecutorResult;
    }

    private Humidifier.Bedrock.AgentTypes.ActionGroupExecutor CreateActionGroupExecutor()
    {
        var actionGroupExecutorResult = new Humidifier.Bedrock.AgentTypes.ActionGroupExecutor();

        return actionGroupExecutorResult;
    }

} // End Of Class

public static class InnerAgentActionGroupExecutorFactoryExtensions
{
}
