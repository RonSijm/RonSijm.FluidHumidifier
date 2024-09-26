// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotCustomVocabularyFactory(Action<Humidifier.Lex.BotTypes.CustomVocabulary> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.CustomVocabulary>
{

    protected override Humidifier.Lex.BotTypes.CustomVocabulary Create()
    {
        var customVocabularyResult = CreateCustomVocabulary();
        factoryAction?.Invoke(customVocabularyResult);

        return customVocabularyResult;
    }

    private Humidifier.Lex.BotTypes.CustomVocabulary CreateCustomVocabulary()
    {
        var customVocabularyResult = new Humidifier.Lex.BotTypes.CustomVocabulary();

        return customVocabularyResult;
    }

} // End Of Class

public static class InnerBotCustomVocabularyFactoryExtensions
{
}
