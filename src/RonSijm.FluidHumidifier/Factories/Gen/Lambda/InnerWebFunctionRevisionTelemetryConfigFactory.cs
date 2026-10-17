// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionTelemetryConfigFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig>
{

    internal InnerWebFunctionRevisionLoggingConfigFactory LoggingConfigFactory { get; set; }

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig Create()
    {
        var telemetryConfigResult = CreateTelemetryConfig();
        factoryAction?.Invoke(telemetryConfigResult);

        return telemetryConfigResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig CreateTelemetryConfig()
    {
        var telemetryConfigResult = new Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig();

        return telemetryConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig result)
    {
        base.CreateChildren(result);

        result.LoggingConfig ??= LoggingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebFunctionRevisionTelemetryConfigFactoryExtensions
{
    public static CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig(this InnerWebFunctionRevisionTelemetryConfigFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null)
    {
        parentFactory.LoggingConfigFactory = new InnerWebFunctionRevisionLoggingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigFactory);
    }

    public static CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, T2, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, T2, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, T2, T3, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, T2, T3, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory, T3, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionTelemetryConfigFactory, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, T2, T3, T4, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebFunctionRevisionTelemetryConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, T2, T3, T4, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebFunctionRevisionTelemetryConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory, T3, T4, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionTelemetryConfigFactory, T4, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionTelemetryConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionTelemetryConfigFactory, InnerWebFunctionRevisionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T5, subFactoryAction).T2);
}
