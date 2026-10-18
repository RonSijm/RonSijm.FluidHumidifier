// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotDeepgramSpeechModelConfigFactory(Action<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig>
{

    protected override Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig Create()
    {
        var deepgramSpeechModelConfigResult = CreateDeepgramSpeechModelConfig();
        factoryAction?.Invoke(deepgramSpeechModelConfigResult);

        return deepgramSpeechModelConfigResult;
    }

    private Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig CreateDeepgramSpeechModelConfig()
    {
        var deepgramSpeechModelConfigResult = new Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig();

        return deepgramSpeechModelConfigResult;
    }

} // End Of Class

public static class InnerBotDeepgramSpeechModelConfigFactoryExtensions
{
}
