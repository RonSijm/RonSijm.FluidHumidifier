// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class TelemetryRuleFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.TelemetryRule> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.TelemetryRule>(resourceName)
{

    internal InnerTelemetryRuleTelemetryRuleFactory RuleFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.TelemetryRule Create()
    {
        var telemetryRuleResult = CreateTelemetryRule();
        factoryAction?.Invoke(telemetryRuleResult);

        return telemetryRuleResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryRule CreateTelemetryRule()
    {
        var telemetryRuleResult = new Humidifier.ObservabilityAdmin.TelemetryRule
        {
            GivenName = InputResourceName,
        };

        return telemetryRuleResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.TelemetryRule result)
    {
        base.CreateChildren(result);

        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class TelemetryRuleFactoryExtensions
{
    public static CombinedResult<TelemetryRuleFactory, InnerTelemetryRuleTelemetryRuleFactory> WithRule(this TelemetryRuleFactory parentFactory, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerTelemetryRuleTelemetryRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<TelemetryRuleFactory, T1, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1>(this CombinedResult<TelemetryRuleFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryRuleFactory, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1>(this CombinedResult<T1, TelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TelemetryRuleFactory, T1, T2, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2>(this CombinedResult<TelemetryRuleFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryRuleFactory, T2, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, TelemetryRuleFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TelemetryRuleFactory, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, TelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TelemetryRuleFactory, T1, T2, T3, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<TelemetryRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryRuleFactory, T2, T3, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, TelemetryRuleFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TelemetryRuleFactory, T3, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, TelemetryRuleFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TelemetryRuleFactory, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, TelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TelemetryRuleFactory, T1, T2, T3, T4, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<TelemetryRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TelemetryRuleFactory, T2, T3, T4, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, TelemetryRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TelemetryRuleFactory, T3, T4, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, TelemetryRuleFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TelemetryRuleFactory, T4, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TelemetryRuleFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TelemetryRuleFactory, InnerTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.TelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction).T2);
}
