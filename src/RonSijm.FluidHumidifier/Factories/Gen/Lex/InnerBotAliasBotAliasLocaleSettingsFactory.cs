// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotAliasBotAliasLocaleSettingsFactory(Action<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings>
{

    internal InnerBotAliasCodeHookSpecificationFactory CodeHookSpecificationFactory { get; set; }

    protected override Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings Create()
    {
        var botAliasLocaleSettingsResult = CreateBotAliasLocaleSettings();
        factoryAction?.Invoke(botAliasLocaleSettingsResult);

        return botAliasLocaleSettingsResult;
    }

    private Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings CreateBotAliasLocaleSettings()
    {
        var botAliasLocaleSettingsResult = new Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings();

        return botAliasLocaleSettingsResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotAliasTypes.BotAliasLocaleSettings result)
    {
        base.CreateChildren(result);

        result.CodeHookSpecification ??= CodeHookSpecificationFactory?.Build();
    }

} // End Of Class

public static class InnerBotAliasBotAliasLocaleSettingsFactoryExtensions
{
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification(this InnerBotAliasBotAliasLocaleSettingsFactory parentFactory, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null)
    {
        parentFactory.CodeHookSpecificationFactory = new InnerBotAliasCodeHookSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeHookSpecificationFactory);
    }

    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, T2, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, T2, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2>(this CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, T2, T3, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, T2, T3, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory, T3, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsFactory, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, T2, T3, T4, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3, T4>(this CombinedResult<InnerBotAliasBotAliasLocaleSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, T2, T3, T4, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotAliasBotAliasLocaleSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory, T3, T4, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotAliasBotAliasLocaleSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsFactory, T4, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotAliasBotAliasLocaleSettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsFactory, InnerBotAliasCodeHookSpecificationFactory> WithCodeHookSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotAliasBotAliasLocaleSettingsFactory> combinedResult, Action<Humidifier.Lex.BotAliasTypes.CodeHookSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeHookSpecification(combinedResult.T5, subFactoryAction));
}
