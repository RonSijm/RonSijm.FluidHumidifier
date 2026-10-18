// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotNluImprovementSpecificationFactory(Action<Humidifier.Lex.BotTypes.NluImprovementSpecification> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.NluImprovementSpecification>
{

    internal InnerBotIntentDisambiguationSettingsFactory IntentDisambiguationSettingsFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.NluImprovementSpecification Create()
    {
        var nluImprovementSpecificationResult = CreateNluImprovementSpecification();
        factoryAction?.Invoke(nluImprovementSpecificationResult);

        return nluImprovementSpecificationResult;
    }

    private Humidifier.Lex.BotTypes.NluImprovementSpecification CreateNluImprovementSpecification()
    {
        var nluImprovementSpecificationResult = new Humidifier.Lex.BotTypes.NluImprovementSpecification();

        return nluImprovementSpecificationResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.NluImprovementSpecification result)
    {
        base.CreateChildren(result);

        result.IntentDisambiguationSettings ??= IntentDisambiguationSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerBotNluImprovementSpecificationFactoryExtensions
{
    public static CombinedResult<InnerBotNluImprovementSpecificationFactory, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings(this InnerBotNluImprovementSpecificationFactory parentFactory, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null)
    {
        parentFactory.IntentDisambiguationSettingsFactory = new InnerBotIntentDisambiguationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntentDisambiguationSettingsFactory);
    }

    public static CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1>(this CombinedResult<InnerBotNluImprovementSpecificationFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1>(this CombinedResult<T1, InnerBotNluImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, T2, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2>(this CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, T2, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2>(this CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotNluImprovementSpecificationFactory, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2>(this CombinedResult<T1, T2, InnerBotNluImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, T2, T3, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3>(this CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, T2, T3, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3>(this CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotNluImprovementSpecificationFactory, T3, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotNluImprovementSpecificationFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotNluImprovementSpecificationFactory, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotNluImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, T2, T3, T4, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3, T4>(this CombinedResult<InnerBotNluImprovementSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, T2, T3, T4, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotNluImprovementSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotNluImprovementSpecificationFactory, T3, T4, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotNluImprovementSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotNluImprovementSpecificationFactory, T4, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotNluImprovementSpecificationFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotNluImprovementSpecificationFactory, InnerBotIntentDisambiguationSettingsFactory> WithIntentDisambiguationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotNluImprovementSpecificationFactory> combinedResult, Action<Humidifier.Lex.BotTypes.IntentDisambiguationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIntentDisambiguationSettings(combinedResult.T5, subFactoryAction).T2);
}
