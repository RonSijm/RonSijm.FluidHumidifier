// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lex;

public class InnerBotGenerativeAISettingsFactory(Action<Humidifier.Lex.BotTypes.GenerativeAISettings> factoryAction = null) : SubResourceFactory<Humidifier.Lex.BotTypes.GenerativeAISettings>
{

    internal InnerBotRuntimeSettingsFactory RuntimeSettingsFactory { get; set; }

    internal InnerBotBuildtimeSettingsFactory BuildtimeSettingsFactory { get; set; }

    protected override Humidifier.Lex.BotTypes.GenerativeAISettings Create()
    {
        var generativeAISettingsResult = CreateGenerativeAISettings();
        factoryAction?.Invoke(generativeAISettingsResult);

        return generativeAISettingsResult;
    }

    private Humidifier.Lex.BotTypes.GenerativeAISettings CreateGenerativeAISettings()
    {
        var generativeAISettingsResult = new Humidifier.Lex.BotTypes.GenerativeAISettings();

        return generativeAISettingsResult;
    }
    public override void CreateChildren(Humidifier.Lex.BotTypes.GenerativeAISettings result)
    {
        base.CreateChildren(result);

        result.RuntimeSettings ??= RuntimeSettingsFactory?.Build();
        result.BuildtimeSettings ??= BuildtimeSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerBotGenerativeAISettingsFactoryExtensions
{
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, InnerBotRuntimeSettingsFactory> WithRuntimeSettings(this InnerBotGenerativeAISettingsFactory parentFactory, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null)
    {
        parentFactory.RuntimeSettingsFactory = new InnerBotRuntimeSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuntimeSettingsFactory);
    }

    public static CombinedResult<InnerBotGenerativeAISettingsFactory, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings(this InnerBotGenerativeAISettingsFactory parentFactory, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null)
    {
        parentFactory.BuildtimeSettingsFactory = new InnerBotBuildtimeSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BuildtimeSettingsFactory);
    }

    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2>(this CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3, T4, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3, T4>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3, T4, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3, T4, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory, T4, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotGenerativeAISettingsFactory, InnerBotRuntimeSettingsFactory> WithRuntimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.RuntimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimeSettings(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2>(this CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3, T4, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3, T4>(this CombinedResult<InnerBotGenerativeAISettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3, T4, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerBotGenerativeAISettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3, T4, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBotGenerativeAISettingsFactory, T3, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory, T4, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBotGenerativeAISettingsFactory, T4> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBotGenerativeAISettingsFactory, InnerBotBuildtimeSettingsFactory> WithBuildtimeSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBotGenerativeAISettingsFactory> combinedResult, Action<Humidifier.Lex.BotTypes.BuildtimeSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBuildtimeSettings(combinedResult.T5, subFactoryAction).T2);
}
