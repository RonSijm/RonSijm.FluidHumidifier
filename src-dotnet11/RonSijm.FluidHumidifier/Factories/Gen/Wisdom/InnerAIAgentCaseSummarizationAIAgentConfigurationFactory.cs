// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentCaseSummarizationAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration Create()
    {
        var caseSummarizationAIAgentConfigurationResult = CreateCaseSummarizationAIAgentConfiguration();
        factoryAction?.Invoke(caseSummarizationAIAgentConfigurationResult);

        return caseSummarizationAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration CreateCaseSummarizationAIAgentConfiguration()
    {
        var caseSummarizationAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration();

        return caseSummarizationAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentCaseSummarizationAIAgentConfigurationFactoryExtensions
{
}
