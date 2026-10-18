// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentNoteTakingAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration Create()
    {
        var noteTakingAIAgentConfigurationResult = CreateNoteTakingAIAgentConfiguration();
        factoryAction?.Invoke(noteTakingAIAgentConfigurationResult);

        return noteTakingAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration CreateNoteTakingAIAgentConfiguration()
    {
        var noteTakingAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration();

        return noteTakingAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentNoteTakingAIAgentConfigurationFactoryExtensions
{
}
