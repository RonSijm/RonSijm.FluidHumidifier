// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerOrganizationTelemetryRuleTelemetryRuleFactory(Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule>
{

    internal InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory DestinationConfigurationFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule Create()
    {
        var telemetryRuleResult = CreateTelemetryRule();
        factoryAction?.Invoke(telemetryRuleResult);

        return telemetryRuleResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule CreateTelemetryRule()
    {
        var telemetryRuleResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule();

        return telemetryRuleResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule result)
    {
        base.CreateChildren(result);

        result.DestinationConfiguration ??= DestinationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerOrganizationTelemetryRuleTelemetryRuleFactoryExtensions
{
    public static CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration(this InnerOrganizationTelemetryRuleTelemetryRuleFactory parentFactory, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationConfigurationFactory = new InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigurationFactory);
    }

    public static CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, T2, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T2, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, T2, T3, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T2, T3, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T3, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, T2, T3, T4, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerOrganizationTelemetryRuleTelemetryRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T2, T3, T4, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T3, T4, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T4, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOrganizationTelemetryRuleTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOrganizationTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
