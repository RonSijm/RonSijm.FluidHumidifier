// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAliasSentimentAnalysisSettingsFactory(Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings>
{

    protected override Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings Create()
    {
        var sentimentAnalysisSettingsResult = CreateSentimentAnalysisSettings();
        factoryAction?.Invoke(sentimentAnalysisSettingsResult);

        return sentimentAnalysisSettingsResult;
    }

    private Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings CreateSentimentAnalysisSettings()
    {
        var sentimentAnalysisSettingsResult = new Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings();

        return sentimentAnalysisSettingsResult;
    }

} // End Of Class

public static class InnerBotAliasSentimentAnalysisSettingsFactoryExtensions
{
}
