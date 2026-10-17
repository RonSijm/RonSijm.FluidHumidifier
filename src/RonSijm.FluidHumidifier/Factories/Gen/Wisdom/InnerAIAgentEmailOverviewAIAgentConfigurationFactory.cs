// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentEmailOverviewAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration Create()
    {
        var emailOverviewAIAgentConfigurationResult = CreateEmailOverviewAIAgentConfiguration();
        factoryAction?.Invoke(emailOverviewAIAgentConfigurationResult);

        return emailOverviewAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration CreateEmailOverviewAIAgentConfiguration()
    {
        var emailOverviewAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration();

        return emailOverviewAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentEmailOverviewAIAgentConfigurationFactoryExtensions
{
}
