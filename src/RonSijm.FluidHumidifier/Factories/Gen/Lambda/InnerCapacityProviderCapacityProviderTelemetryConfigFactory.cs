// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderCapacityProviderTelemetryConfigFactory(Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig>
{

    internal InnerCapacityProviderCapacityProviderLoggingConfigFactory LoggingConfigFactory { get; set; }

    protected override Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig Create()
    {
        var capacityProviderTelemetryConfigResult = CreateCapacityProviderTelemetryConfig();
        factoryAction?.Invoke(capacityProviderTelemetryConfigResult);

        return capacityProviderTelemetryConfigResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig CreateCapacityProviderTelemetryConfig()
    {
        var capacityProviderTelemetryConfigResult = new Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig();

        return capacityProviderTelemetryConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.CapacityProviderTypes.CapacityProviderTelemetryConfig result)
    {
        base.CreateChildren(result);

        result.LoggingConfig ??= LoggingConfigFactory?.Build();
    }

} // End Of Class

public static class InnerCapacityProviderCapacityProviderTelemetryConfigFactoryExtensions
{
    public static CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig(this InnerCapacityProviderCapacityProviderTelemetryConfigFactory parentFactory, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null)
    {
        parentFactory.LoggingConfigFactory = new InnerCapacityProviderCapacityProviderLoggingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigFactory);
    }

    public static CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, T2, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T2, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, T2, InnerCapacityProviderCapacityProviderTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, T2, T3, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T2, T3, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T3, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityProviderTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, T2, T3, T4, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T2, T3, T4, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T3, T4, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T4, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapacityProviderCapacityProviderTelemetryConfigFactory, InnerCapacityProviderCapacityProviderLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapacityProviderCapacityProviderTelemetryConfigFactory> combinedResult, Action<Humidifier.Lambda.CapacityProviderTypes.CapacityProviderLoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T5, subFactoryAction).T2);
}
