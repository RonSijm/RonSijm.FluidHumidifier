// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAliasBotAliasLocaleSettingsItemFactory(Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem>
{

    internal InnerBotAliasBotAliasLocaleSettingsFactory BotAliasLocaleSettingFactory { get; set; }

    protected override Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem Create()
    {
        var botAliasLocaleSettingsItemResult = CreateBotAliasLocaleSettingsItem();
        factoryAction?.Invoke(botAliasLocaleSettingsItemResult);

        return botAliasLocaleSettingsItemResult;
    }

    private Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem CreateBotAliasLocaleSettingsItem()
    {
        var botAliasLocaleSettingsItemResult = new Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem();

        return botAliasLocaleSettingsItemResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettingsItem result)
    {
        base.CreateChildren(result);

        result.BotAliasLocaleSetting ??= BotAliasLocaleSettingFactory?.Build();
    }

} // End Of Class

public static class InnerBotAliasBotAliasLocaleSettingsItemFactoryExtensions
{
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting(this InnerBotAliasBotAliasLocaleSettingsItemFactory parentFactory, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null)
    {
        parentFactory.BotAliasLocaleSettingFactory = new InnerBotAliasBotAliasLocaleSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BotAliasLocaleSettingFactory);
    }

    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, T2, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2>(this CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, T2, T3, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory, T3, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3, T4>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsItemFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsItemFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory, T3, T4, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsItemFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory, T4, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsItemFactory, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsItemFactory, InnerBotAliasBotAliasLocaleSettingsFactory> WithBotAliasLocaleSetting<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsItemFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotAliasLocaleSetting(combinedResult.T5, subFactoryAction));
}
