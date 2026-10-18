// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerKnowledgeBaseParsingPromptFactory(Action<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt>
{

    protected override Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt Create()
    {
        var parsingPromptResult = CreateParsingPrompt();
        factoryAction?.Invoke(parsingPromptResult);

        return parsingPromptResult;
    }

    private Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt CreateParsingPrompt()
    {
        var parsingPromptResult = new Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt();

        return parsingPromptResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseParsingPromptFactoryExtensions
{
}
