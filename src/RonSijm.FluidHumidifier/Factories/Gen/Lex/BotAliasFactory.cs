// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class BotAliasFactory(string resourceName = null, Action<Humidifier.Lex.BotAlias> factoryAction = null) : ResourceFactory<Humidifier.Lex.BotAlias>(resourceName)
{

    internal List<InnerBotAliasBotAliasLocaleSettingsItemFactory> BotAliasLocaleSettingsFactories { get; set; } = [];

    internal InnerBotAliasConversationLogSettingsFactory ConversationLogSettingsFactory { get; set; }

    internal InnerBotAliasSentimentAnalysisSettingsFactory SentimentAnalysisSettingsFactory { get; set; }

    protected override Humidifier.Lex.BotAlias Create()
    {
        var botAliasResult = CreateBotAlias();
        factoryAction?.Invoke(botAliasResult);

        return botAliasResult;
    }

    private Humidifier.Lex.BotAlias CreateBotAlias()
    {
        var botAliasResult = new Humidifier.Lex.BotAlias
        {
            GivenName = InputResourceName,
        };

        return botAliasResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotAlias result)
    {
        base.CreateChildren(result);

        result.BotAliasLocaleSettings = BotAliasLocaleSettingsFactories.Any() ? BotAliasLocaleSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.ConversationLogSettings ??= ConversationLogSettingsFactory?.Build();
        result.SentimentAnalysisSettings ??= SentimentAnalysisSettingsFactory?.Build();
    }

} // End Of Class

public static class BotAliasFactoryExtensions
{
    public static CombinedResult<BotAliasFactory, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings(this BotAliasFactory parentFactory, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null)
    {
        var factory = new InnerBotAliasBotAliasLocaleSettingsItemFactory(subFactoryAction);
        parentFactory.BotAliasLocaleSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BotAliasFactory, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings(this BotAliasFactory parentFactory, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null)
    {
        parentFactory.ConversationLogSettingsFactory = new InnerBotAliasConversationLogSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConversationLogSettingsFactory);
    }

    public static CombinedResult<BotAliasFactory, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings(this BotAliasFactory parentFactory, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null)
    {
        parentFactory.SentimentAnalysisSettingsFactory = new InnerBotAliasSentimentAnalysisSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SentimentAnalysisSettingsFactory);
    }

    public static CombinedResult<BotAliasFactory, T1, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1>(this CombinedResult<BotAliasFactory, T1> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1>(this CombinedResult<T1, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2>(this CombinedResult<BotAliasFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2>(this CombinedResult<T1, BotAliasFactory, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2>(this CombinedResult<T1, T2, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3>(this CombinedResult<BotAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3>(this CombinedResult<T1, BotAliasFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3>(this CombinedResult<T1, T2, BotAliasFactory, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotAliasFactory, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3, T4>(this CombinedResult<BotAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3, T4>(this CombinedResult<T1, BotAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, T3, T4, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotAliasFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotAliasFactory, T4, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotAliasFactory, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotAliasFactory, InnerBotAliasBotAliasLocaleSettingsItemFactory> WithBotAliasLocaleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1>(this CombinedResult<BotAliasFactory, T1> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1>(this CombinedResult<T1, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2>(this CombinedResult<BotAliasFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2>(this CombinedResult<T1, BotAliasFactory, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2>(this CombinedResult<T1, T2, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, T3, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<BotAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, T3, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<T1, BotAliasFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, T3, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, BotAliasFactory, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotAliasFactory, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, T3, T4, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<BotAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, T3, T4, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, BotAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, T3, T4, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotAliasFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotAliasFactory, T4, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotAliasFactory, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotAliasFactory, InnerBotAliasConversationLogSettingsFactory> WithConversationLogSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.ConversationLogSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConversationLogSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1>(this CombinedResult<BotAliasFactory, T1> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1>(this CombinedResult<T1, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2>(this CombinedResult<BotAliasFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2>(this CombinedResult<T1, BotAliasFactory, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2>(this CombinedResult<T1, T2, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, T3, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<BotAliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, T3, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<T1, BotAliasFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, T3, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<T1, T2, BotAliasFactory, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotAliasFactory, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotAliasFactory, T1, T2, T3, T4, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<BotAliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotAliasFactory, T2, T3, T4, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, BotAliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotAliasFactory, T3, T4, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotAliasFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotAliasFactory, T4, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotAliasFactory, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotAliasFactory, InnerBotAliasSentimentAnalysisSettingsFactory> WithSentimentAnalysisSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotAliasFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.SentimentAnalysisSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSentimentAnalysisSettings(combinedResult.T5, subFactoryAction));
}
