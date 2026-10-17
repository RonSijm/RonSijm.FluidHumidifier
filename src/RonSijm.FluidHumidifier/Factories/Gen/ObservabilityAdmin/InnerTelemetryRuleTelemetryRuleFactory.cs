// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryRuleTelemetryRuleFactory(Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule>
{

    internal InnerTelemetryRuleTelemetryDestinationConfigurationFactory DestinationConfigurationFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule Create()
    {
        var telemetryRuleResult = CreateTelemetryRule();
        factoryAction?.Invoke(telemetryRuleResult);

        return telemetryRuleResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule CreateTelemetryRule()
    {
        var telemetryRuleResult = new Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule();

        return telemetryRuleResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule result)
    {
        base.CreateChildren(result);

        result.DestinationConfiguration ??= DestinationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTelemetryRuleTelemetryRuleFactoryExtensions
{
    public static CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration(this InnerTelemetryRuleTelemetryRuleFactory parentFactory, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationConfigurationFactory = new InnerTelemetryRuleTelemetryDestinationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigurationFactory);
    }

    public static CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1>(this CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, T2, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, T2, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTelemetryRuleTelemetryRuleFactory, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, T2, T3, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, T2, T3, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTelemetryRuleTelemetryRuleFactory, T3, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTelemetryRuleTelemetryRuleFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTelemetryRuleTelemetryRuleFactory, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, T2, T3, T4, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTelemetryRuleTelemetryRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, T2, T3, T4, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTelemetryRuleTelemetryRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTelemetryRuleTelemetryRuleFactory, T3, T4, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTelemetryRuleTelemetryRuleFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTelemetryRuleTelemetryRuleFactory, T4, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTelemetryRuleTelemetryRuleFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTelemetryRuleTelemetryRuleFactory, InnerTelemetryRuleTelemetryDestinationConfigurationFactory> WithDestinationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTelemetryRuleTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryDestinationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
