// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotSentimentAnalysisSettingsFactory(Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.SentimentAnalysisSettings>
{

    protected override Humidifier.Lex.BotTypes.SentimentAnalysisSettings Create()
    {
        var sentimentAnalysisSettingsResult = CreateSentimentAnalysisSettings();
        factoryAction?.Invoke(sentimentAnalysisSettingsResult);

        return sentimentAnalysisSettingsResult;
    }

    private Humidifier.Lex.BotTypes.SentimentAnalysisSettings CreateSentimentAnalysisSettings()
    {
        var sentimentAnalysisSettingsResult = new Humidifier.Lex.BotTypes.SentimentAnalysisSettings();

        return sentimentAnalysisSettingsResult;
    }

} // End Of Class

public static class InnerBotSentimentAnalysisSettingsFactoryExtensions
{
}
