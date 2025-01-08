// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactory(Action<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration>
{

    protected override Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration Create()
    {
        var textFullAIPromptEditTemplateConfigurationResult = CreateTextFullAIPromptEditTemplateConfiguration();
        factoryAction?.Invoke(textFullAIPromptEditTemplateConfigurationResult);

        return textFullAIPromptEditTemplateConfigurationResult;
    }

    private Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration CreateTextFullAIPromptEditTemplateConfiguration()
    {
        var textFullAIPromptEditTemplateConfigurationResult = new Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration();

        return textFullAIPromptEditTemplateConfigurationResult;
    }

} // End Of Class

public static class InnerAIPromptTextFullAIPromptEditTemplateConfigurationFactoryExtensions
{
}
