// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotBotLocaleFactory(Action<Humidifier.Lex.BotTypes.BotLocale> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.BotLocale>
{

    internal InnerBotCustomVocabularyFactory CustomVocabularyFactory { get; set; }

    internal InnerBotVoiceSettingsFactory VoiceSettingsFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.BotLocale Create()
    {
        var botLocaleResult = CreateBotLocale();
        factoryAction?.Invoke(botLocaleResult);

        return botLocaleResult;
    }

    private Humidifier.Lex.BotTypes.BotLocale CreateBotLocale()
    {
        var botLocaleResult = new Humidifier.Lex.BotTypes.BotLocale();

        return botLocaleResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.BotLocale result)
    {
        base.CreateChildren(result);

        result.CustomVocabulary ??= CustomVocabularyFactory?.Build();
        result.VoiceSettings ??= VoiceSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerBotBotLocaleFactoryExtensions
{
    public static CombinedResult<InnerBotBotLocaleFactory, InnerBotCustomVocabularyFactory> WithCustomVocabulary(this InnerBotBotLocaleFactory parentFactory, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null)
    {
        parentFactory.CustomVocabularyFactory = new InnerBotCustomVocabularyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomVocabularyFactory);
    }

    public static CombinedResult<InnerBotBotLocaleFactory, InnerBotVoiceSettingsFactory> WithVoiceSettings(this InnerBotBotLocaleFactory parentFactory, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null)
    {
        parentFactory.VoiceSettingsFactory = new InnerBotVoiceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VoiceSettingsFactory);
    }

    public static CombinedResult<InnerBotBotLocaleFactory, T1, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1>(this CombinedResult<InnerBotBotLocaleFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1>(this CombinedResult<T1, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, T2, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2>(this CombinedResult<InnerBotBotLocaleFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, T2, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2>(this CombinedResult<T1, InnerBotBotLocaleFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotBotLocaleFactory, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2>(this CombinedResult<T1, T2, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3>(this CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3>(this CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3, T4, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3, T4>(this CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3, T4, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3, T4, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory, T4, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotBotLocaleFactory, InnerBotCustomVocabularyFactory> WithCustomVocabulary<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.CustomVocabulary> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomVocabulary(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1>(this CombinedResult<InnerBotBotLocaleFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVoiceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1>(this CombinedResult<T1, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithVoiceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, T2, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2>(this CombinedResult<InnerBotBotLocaleFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, T2, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2>(this CombinedResult<T1, InnerBotBotLocaleFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotBotLocaleFactory, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2>(this CombinedResult<T1, T2, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3>(this CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3>(this CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3, T4, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3, T4>(this CombinedResult<InnerBotBotLocaleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3, T4, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotBotLocaleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3, T4, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotBotLocaleFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory, T4, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotBotLocaleFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotBotLocaleFactory, InnerBotVoiceSettingsFactory> WithVoiceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotBotLocaleFactory> combinedResult, Action<Humidifier.Lex.BotTypes.VoiceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceSettings(combinedResult.T5, subFactoryAction));
}
