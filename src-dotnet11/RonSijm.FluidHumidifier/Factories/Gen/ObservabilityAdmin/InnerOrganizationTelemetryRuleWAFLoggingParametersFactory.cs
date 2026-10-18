// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleWAFLoggingParametersFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters>
{

    internal InnerOrganizationTelemetryRuleLoggingFilterFactory LoggingFilterFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters Create()
    {
        var wAFLoggingParametersResult = CreateWAFLoggingParameters();
        factoryAction?.Invoke(wAFLoggingParametersResult);

        return wAFLoggingParametersResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters CreateWAFLoggingParameters()
    {
        var wAFLoggingParametersResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters();

        return wAFLoggingParametersResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.WAFLoggingParameters result)
    {
        base.CreateChildren(result);

        result.LoggingFilter ??= LoggingFilterFactory?.Build();
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleWAFLoggingParametersFactoryExtensions
{
    public static CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter(this InnerOrganizationTelemetryRuleWAFLoggingParametersFactory parentFactory, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null)
    {
        parentFactory.LoggingFilterFactory = new InnerOrganizationTelemetryRuleLoggingFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingFilterFactory);
    }

    public static CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1>(this CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1>(this CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, T2, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T2, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2>(this CombinedResult<T1, T2, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T2, T3, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T3, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3, T4, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T2, T3, T4, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T3, T4, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T4, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory, InnerOrganizationTelemetryRuleLoggingFilterFactory> WithLoggingFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOrganizationTelemetryRuleWAFLoggingParametersFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.LoggingFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingFilter(combinedResult.T5, subFactoryAction).T2);
}
