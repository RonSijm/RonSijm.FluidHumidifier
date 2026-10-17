// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentOrchestrationAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration Create()
    {
        var orchestrationAIAgentConfigurationResult = CreateOrchestrationAIAgentConfiguration();
        factoryAction?.Invoke(orchestrationAIAgentConfigurationResult);

        return orchestrationAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration CreateOrchestrationAIAgentConfiguration()
    {
        var orchestrationAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration();

        return orchestrationAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentOrchestrationAIAgentConfigurationFactoryExtensions
{
}
