// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotSpeechModelConfigFactory(Action<Humidifier.Lex.BotTypes.SpeechModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.SpeechModelConfig>
{

    internal InnerBotDeepgramSpeechModelConfigFactory DeepgramConfigFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.SpeechModelConfig Create()
    {
        var speechModelConfigResult = CreateSpeechModelConfig();
        factoryAction?.Invoke(speechModelConfigResult);

        return speechModelConfigResult;
    }

    private Humidifier.Lex.BotTypes.SpeechModelConfig CreateSpeechModelConfig()
    {
        var speechModelConfigResult = new Humidifier.Lex.BotTypes.SpeechModelConfig();

        return speechModelConfigResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.SpeechModelConfig result)
    {
        base.CreateChildren(result);

        result.DeepgramConfig ??= DeepgramConfigFactory?.Build();
    }

} // End Of Class

public static class InnerBotSpeechModelConfigFactoryExtensions
{
    public static CombinedResult<InnerBotSpeechModelConfigFactory, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig(this InnerBotSpeechModelConfigFactory parentFactory, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null)
    {
        parentFactory.DeepgramConfigFactory = new InnerBotDeepgramSpeechModelConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeepgramConfigFactory);
    }

    public static CombinedResult<InnerBotSpeechModelConfigFactory, T1, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1>(this CombinedResult<InnerBotSpeechModelConfigFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechModelConfigFactory, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1>(this CombinedResult<T1, InnerBotSpeechModelConfigFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotSpeechModelConfigFactory, T1, T2, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2>(this CombinedResult<InnerBotSpeechModelConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechModelConfigFactory, T2, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2>(this CombinedResult<T1, InnerBotSpeechModelConfigFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSpeechModelConfigFactory, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2>(this CombinedResult<T1, T2, InnerBotSpeechModelConfigFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotSpeechModelConfigFactory, T1, T2, T3, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3>(this CombinedResult<InnerBotSpeechModelConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechModelConfigFactory, T2, T3, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3>(this CombinedResult<T1, InnerBotSpeechModelConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSpeechModelConfigFactory, T3, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotSpeechModelConfigFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSpeechModelConfigFactory, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotSpeechModelConfigFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotSpeechModelConfigFactory, T1, T2, T3, T4, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3, T4>(this CombinedResult<InnerBotSpeechModelConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotSpeechModelConfigFactory, T2, T3, T4, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotSpeechModelConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotSpeechModelConfigFactory, T3, T4, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotSpeechModelConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotSpeechModelConfigFactory, T4, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotSpeechModelConfigFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotSpeechModelConfigFactory, InnerBotDeepgramSpeechModelConfigFactory> WithDeepgramConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotSpeechModelConfigFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeepgramConfig(combinedResult.T5, subFactoryAction).T2);
}
