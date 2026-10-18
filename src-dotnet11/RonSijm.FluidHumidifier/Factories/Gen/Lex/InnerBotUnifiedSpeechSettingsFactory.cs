// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotUnifiedSpeechSettingsFactory(Action<Humidifier.Lex.BotTypes.UnifiedSpeechSettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.UnifiedSpeechSettings>
{

    internal InnerBotSpeechFoundationModelFactory SpeechFoundationModelFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.UnifiedSpeechSettings Create()
    {
        var unifiedSpeechSettingsResult = CreateUnifiedSpeechSettings();
        factoryAction?.Invoke(unifiedSpeechSettingsResult);

        return unifiedSpeechSettingsResult;
    }

    private Humidifier.Lex.BotTypes.UnifiedSpeechSettings CreateUnifiedSpeechSettings()
    {
        var unifiedSpeechSettingsResult = new Humidifier.Lex.BotTypes.UnifiedSpeechSettings();

        return unifiedSpeechSettingsResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.UnifiedSpeechSettings result)
    {
        base.CreateChildren(result);

        result.SpeechFoundationModel ??= SpeechFoundationModelFactory?.Build();
    }

} // End Of Class

public static class InnerBotUnifiedSpeechSettingsFactoryExtensions
{
    public static CombinedResult<InnerBotUnifiedSpeechSettingsFactory, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel(this InnerBotUnifiedSpeechSettingsFactory parentFactory, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null)
    {
        parentFactory.SpeechFoundationModelFactory = new InnerBotSpeechFoundationModelFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpeechFoundationModelFactory);
    }

    public static CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1>(this CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1>(this CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, T2, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2>(this CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, T2, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2>(this CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotUnifiedSpeechSettingsFactory, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2>(this CombinedResult<T1, T2, InnerBotUnifiedSpeechSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, T2, T3, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3>(this CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, T2, T3, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3>(this CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotUnifiedSpeechSettingsFactory, T3, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotUnifiedSpeechSettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotUnifiedSpeechSettingsFactory, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotUnifiedSpeechSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, T2, T3, T4, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3, T4>(this CombinedResult<InnerBotUnifiedSpeechSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, T2, T3, T4, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotUnifiedSpeechSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotUnifiedSpeechSettingsFactory, T3, T4, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotUnifiedSpeechSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotUnifiedSpeechSettingsFactory, T4, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotUnifiedSpeechSettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotUnifiedSpeechSettingsFactory, InnerBotSpeechFoundationModelFactory> WithSpeechFoundationModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotUnifiedSpeechSettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.SpeechFoundationModel> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpeechFoundationModel(combinedResult.T5, subFactoryAction).T2);
}
