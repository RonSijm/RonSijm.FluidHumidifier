// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerWebFunctionRevisionServiceConfigFactory(Action<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig>
{

    internal InnerWebFunctionRevisionTelemetryConfigFactory TelemetryConfigFactory { get; set; }

    protected override Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig Create()
    {
        var serviceConfigResult = CreateServiceConfig();
        factoryAction?.Invoke(serviceConfigResult);

        return serviceConfigResult;
    }

    private Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig CreateServiceConfig()
    {
        var serviceConfigResult = new Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig();

        return serviceConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.WebFunctionRevisionTypes.ServiceConfig result)
    {
        base.CreateChildren(result);

        result.TelemetryConfig ??= TelemetryConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebFunctionRevisionServiceConfigFactoryExtensions
{
    public static CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig(this InnerWebFunctionRevisionServiceConfigFactory parentFactory, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null)
    {
        parentFactory.TelemetryConfigFactory = new InnerWebFunctionRevisionTelemetryConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TelemetryConfigFactory);
    }

    public static CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1>(this CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1>(this CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, T2, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2>(this CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, T2, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2>(this CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionServiceConfigFactory, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebFunctionRevisionServiceConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, T2, T3, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3>(this CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, T2, T3, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionServiceConfigFactory, T3, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebFunctionRevisionServiceConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionServiceConfigFactory, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionServiceConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, T2, T3, T4, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebFunctionRevisionServiceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, T2, T3, T4, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebFunctionRevisionServiceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebFunctionRevisionServiceConfigFactory, T3, T4, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebFunctionRevisionServiceConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebFunctionRevisionServiceConfigFactory, T4, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebFunctionRevisionServiceConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionServiceConfigFactory, InnerWebFunctionRevisionTelemetryConfigFactory> WithTelemetryConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebFunctionRevisionServiceConfigFactory> combinedResult, Action<Humidifier.Lambda.WebFunctionRevisionTypes.TelemetryConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTelemetryConfig(combinedResult.T5, subFactoryAction).T2);
}
