// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class BotFactory(string resourceName = null, Action<Humidifier.Lex.Bot> factoryAction = null) : ResourceFactory<Humidifier.Lex.Bot>(resourceName)
{

    internal List<InnerBotBotLocaleFactory> BotLocalesFactories { get; set; } = [];

    internal InnerBotS3LocationFactory BotFileS3LocationFactory { get; set; }

    internal InnerBotTestBotAliasSettingsFactory TestBotAliasSettingsFactory { get; set; }

    internal InnerBotDataPrivacyFactory DataPrivacyFactory { get; set; }

    protected override Humidifier.Lex.Bot Create()
    {
        var botResult = CreateBot();
        factoryAction?.Invoke(botResult);

        return botResult;
    }

    private Humidifier.Lex.Bot CreateBot()
    {
        var botResult = new Humidifier.Lex.Bot
        {
            GivenName = InputResourceName,
        };

        return botResult;
    }
    public override void CreateChildren(Humidifier.Lex.Bot result)
    {
        base.CreateChildren(result);

        result.BotLocales = BotLocalesFactories.Any() ? BotLocalesFactories.Select(x => x.Build()).ToList() : null;
        result.BotFileS3Location ??= BotFileS3LocationFactory?.Build();
        result.TestBotAliasSettings ??= TestBotAliasSettingsFactory?.Build();
        result.DataPrivacy ??= DataPrivacyFactory?.Build();
    }

} // End Of Class

public static class BotFactoryExtensions
{
    public static CombinedResult<BotFactory, InnerBotBotLocaleFactory> WithBotLocales(this BotFactory parentFactory, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null)
    {
        var factory = new InnerBotBotLocaleFactory(subFactoryAction);
        parentFactory.BotLocalesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BotFactory, InnerBotS3LocationFactory> WithBotFileS3Location(this BotFactory parentFactory, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.BotFileS3LocationFactory = new InnerBotS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BotFileS3LocationFactory);
    }

    public static CombinedResult<BotFactory, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings(this BotFactory parentFactory, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null)
    {
        parentFactory.TestBotAliasSettingsFactory = new InnerBotTestBotAliasSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TestBotAliasSettingsFactory);
    }

    public static CombinedResult<BotFactory, InnerBotDataPrivacyFactory> WithDataPrivacy(this BotFactory parentFactory, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null)
    {
        parentFactory.DataPrivacyFactory = new InnerBotDataPrivacyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataPrivacyFactory);
    }

    public static CombinedResult<BotFactory, T1, InnerBotBotLocaleFactory> WithBotLocales<T1>(this CombinedResult<BotFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotLocales(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, InnerBotBotLocaleFactory> WithBotLocales<T1>(this CombinedResult<T1, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotLocales(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, InnerBotBotLocaleFactory> WithBotLocales<T1, T2>(this CombinedResult<BotFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, InnerBotBotLocaleFactory> WithBotLocales<T1, T2>(this CombinedResult<T1, BotFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, InnerBotBotLocaleFactory> WithBotLocales<T1, T2>(this CombinedResult<T1, T2, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3>(this CombinedResult<BotFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3>(this CombinedResult<T1, BotFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3>(this CombinedResult<T1, T2, BotFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, T4, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3, T4>(this CombinedResult<BotFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, T4, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3, T4>(this CombinedResult<T1, BotFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, T4, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, T4, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotFactory, InnerBotBotLocaleFactory> WithBotLocales<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BotLocale> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotLocales(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BotFactory, T1, InnerBotS3LocationFactory> WithBotFileS3Location<T1>(this CombinedResult<BotFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, InnerBotS3LocationFactory> WithBotFileS3Location<T1>(this CombinedResult<T1, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2>(this CombinedResult<BotFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2>(this CombinedResult<T1, BotFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2>(this CombinedResult<T1, T2, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3>(this CombinedResult<BotFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3>(this CombinedResult<T1, BotFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3>(this CombinedResult<T1, T2, BotFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, T4, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3, T4>(this CombinedResult<BotFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, T4, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3, T4>(this CombinedResult<T1, BotFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, T4, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, T4, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotFactory, InnerBotS3LocationFactory> WithBotFileS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBotFileS3Location(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BotFactory, T1, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1>(this CombinedResult<BotFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1>(this CombinedResult<T1, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2>(this CombinedResult<BotFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2>(this CombinedResult<T1, BotFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2>(this CombinedResult<T1, T2, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3>(this CombinedResult<BotFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3>(this CombinedResult<T1, BotFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3>(this CombinedResult<T1, T2, BotFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, T4, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3, T4>(this CombinedResult<BotFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, T4, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3, T4>(this CombinedResult<T1, BotFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, T4, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, T4, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotFactory, InnerBotTestBotAliasSettingsFactory> WithTestBotAliasSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.TestBotAliasSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTestBotAliasSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BotFactory, T1, InnerBotDataPrivacyFactory> WithDataPrivacy<T1>(this CombinedResult<BotFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, InnerBotDataPrivacyFactory> WithDataPrivacy<T1>(this CombinedResult<T1, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2>(this CombinedResult<BotFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2>(this CombinedResult<T1, BotFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2>(this CombinedResult<T1, T2, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3>(this CombinedResult<BotFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3>(this CombinedResult<T1, BotFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3>(this CombinedResult<T1, T2, BotFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3>(this CombinedResult<T1, T2, T3, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BotFactory, T1, T2, T3, T4, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3, T4>(this CombinedResult<BotFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BotFactory, T2, T3, T4, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, BotFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BotFactory, T3, T4, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, T2, BotFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BotFactory, T4, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BotFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BotFactory, InnerBotDataPrivacyFactory> WithDataPrivacy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BotFactory> combinedResult, Action<Humidifier.Lex.BotTypes.DataPrivacy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataPrivacy(combinedResult.T5, subFactoryAction));
}
