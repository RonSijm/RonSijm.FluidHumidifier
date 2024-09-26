// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotTestBotAliasSettingsFactory(Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.TestBotAliasSettings>
{

    internal InnerBotConversationLogSettingsFactory ConversationLogSettingsFactory { get; set; }

    internal InnerBotSentimentAnalysisSettingsFactory SentimentAnalysisSettingsFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.TestBotAliasSettings Create()
    {
        var testBotAliasSettingsResult = CreateTestBotAliasSettings();
        factoryAction?.Invoke(testBotAliasSettingsResult);

        return testBotAliasSettingsResult;
    }

    private Humidifier.Lex.BotTypes.TestBotAliasSettings CreateTestBotAliasSettings()
    {
        var testBotAliasSettingsResult = new Humidifier.Lex.BotTypes.TestBotAliasSettings();

        return testBotAliasSettingsResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.TestBotAliasSettings result)
    {
        base.CreateChildren(result);

        result.ConversationLogSettings ??= ConversationLogSettingsFactory?.Build();
        result.SentimentAnalysisSettings ??= SentimentAnalysisSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerBotTestBotAliasSettingsFactoryExtensions
{
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, InnerBotConversationLogSettingsFactory> WithConversationLogSettings(this InnerBotTestBotAliasSettingsFactory parentFactory, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null)
    {
        parentFactory.ConversationLogSettingsFactory = new InnerBotConversationLogSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConversationLogSettingsFactory);
    }

    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings(this InnerBotTestBotAliasSettingsFactory parentFactory, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null)
    {
        parentFactory.SentimentAnalysisSettingsFactory = new InnerBotSentimentAnalysisSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SentimentAnalysisSettingsFactory);
    }

    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2>(this CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3, T4, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3, T4, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3, T4, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory, T4, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotTestBotAliasSettingsFactory, InnerBotConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2>(this CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3, T4, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<InnerBotTestBotAliasSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3, T4, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotTestBotAliasSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3, T4, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotTestBotAliasSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory, T4, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotTestBotAliasSettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotTestBotAliasSettingsFactory, InnerBotSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotTestBotAliasSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T5, subFactoryAction));
}
