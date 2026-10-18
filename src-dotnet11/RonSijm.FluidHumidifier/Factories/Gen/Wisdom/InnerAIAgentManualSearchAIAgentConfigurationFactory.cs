// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentManualSearchAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration Create()
    {
        var manualSearchAIAgentConfigurationResult = CreateManualSearchAIAgentConfiguration();
        factoryAction?.Invoke(manualSearchAIAgentConfigurationResult);

        return manualSearchAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration CreateManualSearchAIAgentConfiguration()
    {
        var manualSearchAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration();

        return manualSearchAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentManualSearchAIAgentConfigurationFactoryExtensions
{
}
