// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentEmailResponseAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration Create()
    {
        var emailResponseAIAgentConfigurationResult = CreateEmailResponseAIAgentConfiguration();
        factoryAction?.Invoke(emailResponseAIAgentConfigurationResult);

        return emailResponseAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration CreateEmailResponseAIAgentConfiguration()
    {
        var emailResponseAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration();

        return emailResponseAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentEmailResponseAIAgentConfigurationFactoryExtensions
{
}
