// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleWAFLoggingParametersFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters>
{

    internal InnerTelemetryRuleLoggingFilterFactory LoggingFilterFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters Create()
    {
        var wAFLoggingParametersResult = CreateWAFLoggingParameters();
        factoryAction?.Invoke(wAFLoggingParametersResult);

        return wAFLoggingParametersResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters CreateWAFLoggingParameters()
    {
        var wAFLoggingParametersResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters();

        return wAFLoggingParametersResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.TelemetryRuleTypes.WAFLoggingParameters result)
    {
        base.CreateChildren(result);

        result.LoggingFilter ??= LoggingFilterFactory?.Build();
    }

} // End Of Class

public static class InnerTelemetryRuleWAFLoggingParametersFactoryExtensions
{
    public static CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter(this InnerTelemetryRuleWAFLoggingParametersFactory parentFactory, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null)
    {
        parentFactory.LoggingFilterFactory = new InnerTelemetryRuleLoggingFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingFilterFactory);
    }

    public static CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1>(this CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1>(this CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, T2, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, T2, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTelemetryRuleWAFLoggingParametersFactory, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<T1, T2, InnerTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, T2, T3, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTelemetryRuleWAFLoggingParametersFactory, T3, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerTelemetryRuleWAFLoggingParametersFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTelemetryRuleWAFLoggingParametersFactory, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3, T4, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<InnerTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, T2, T3, T4, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerTelemetryRuleWAFLoggingParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTelemetryRuleWAFLoggingParametersFactory, T3, T4, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTelemetryRuleWAFLoggingParametersFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTelemetryRuleWAFLoggingParametersFactory, T4, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTelemetryRuleWAFLoggingParametersFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTelemetryRuleWAFLoggingParametersFactory, InnerTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T5, subFactoryAction).T2);
}
