// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotSpeechRecognitionSettingsFactory(Action<Humidifier.Lex.BotTypes.SpeechRecognitionSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.SpeechRecognitionSettings>
{

    internal InnerBotSpeechModelConfigFactory SpeechModelConfigFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.SpeechRecognitionSettings Create()
    {
        var speechRecognitionSettingsResult = CreateSpeechRecognitionSettings();
        factoryAction?.Invoke(speechRecognitionSettingsResult);

        return speechRecognitionSettingsResult;
    }

    private Humidifier.Lex.BotTypes.SpeechRecognitionSettings CreateSpeechRecognitionSettings()
    {
        var speechRecognitionSettingsResult = new Humidifier.Lex.BotTypes.SpeechRecognitionSettings();

        return speechRecognitionSettingsResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.SpeechRecognitionSettings result)
    {
        base.CreateChildren(result);

        result.SpeechModelConfig ??= SpeechModelConfigFactory?.Build();
    }

} // End Of Class

public static class InnerBotSpeechRecognitionSettingsFactoryExtensions
{
    public static CombinedResult<InnerBotSpeechRecognitionSettingsFactory, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig(this InnerBotSpeechRecognitionSettingsFactory parentFactory, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null)
    {
        parentFactory.SpeechModelConfigFactory = new InnerBotSpeechModelConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpeechModelConfigFactory);
    }

    public static CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1>(this CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1>(this CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, T2, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2>(this CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, T2, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2>(this CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSpeechRecognitionSettingsFactory, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2>(this CombinedResult<T1, T2, InnerBotSpeechRecognitionSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, T2, T3, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3>(this CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, T2, T3, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3>(this CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSpeechRecognitionSettingsFactory, T3, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotSpeechRecognitionSettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSpeechRecognitionSettingsFactory, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotSpeechRecognitionSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, T2, T3, T4, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3, T4>(this CombinedResult<InnerBotSpeechRecognitionSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, T2, T3, T4, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotSpeechRecognitionSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSpeechRecognitionSettingsFactory, T3, T4, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotSpeechRecognitionSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSpeechRecognitionSettingsFactory, T4, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotSpeechRecognitionSettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotSpeechRecognitionSettingsFactory, InnerBotSpeechModelConfigFactory> WithSpeechModelConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotSpeechRecognitionSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechModelConfig(combinedResult.T5, subFactoryAction).T2);
}
