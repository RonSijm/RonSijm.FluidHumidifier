// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class OrganizationTelemetryRuleFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRule> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.OrganizationTelemetryRule>(resourceName)
{

    internal InnerOrganizationTelemetryRuleTelemetryRuleFactory RuleFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.OrganizationTelemetryRule Create()
    {
        var organizationTelemetryRuleResult = CreateOrganizationTelemetryRule();
        factoryAction?.Invoke(organizationTelemetryRuleResult);

        return organizationTelemetryRuleResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationTelemetryRule CreateOrganizationTelemetryRule()
    {
        var organizationTelemetryRuleResult = new Humidifier.ObservabilityAdmin.OrganizationTelemetryRule
        {
            GivenName = InputResourceName,
        };

        return organizationTelemetryRuleResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.OrganizationTelemetryRule result)
    {
        base.CreateChildren(result);

        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class OrganizationTelemetryRuleFactoryExtensions
{
    public static CombinedResult<OrganizationTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule(this OrganizationTelemetryRuleFactory parentFactory, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerOrganizationTelemetryRuleTelemetryRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<OrganizationTelemetryRuleFactory, T1, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1>(this CombinedResult<OrganizationTelemetryRuleFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1>(this CombinedResult<T1, OrganizationTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OrganizationTelemetryRuleFactory, T1, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2>(this CombinedResult<OrganizationTelemetryRuleFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationTelemetryRuleFactory, T2, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, OrganizationTelemetryRuleFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OrganizationTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, OrganizationTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OrganizationTelemetryRuleFactory, T1, T2, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<OrganizationTelemetryRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationTelemetryRuleFactory, T2, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, OrganizationTelemetryRuleFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OrganizationTelemetryRuleFactory, T3, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, OrganizationTelemetryRuleFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OrganizationTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, OrganizationTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OrganizationTelemetryRuleFactory, T1, T2, T3, T4, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<OrganizationTelemetryRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationTelemetryRuleFactory, T2, T3, T4, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, OrganizationTelemetryRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OrganizationTelemetryRuleFactory, T3, T4, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, OrganizationTelemetryRuleFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OrganizationTelemetryRuleFactory, T4, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OrganizationTelemetryRuleFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OrganizationTelemetryRuleFactory, InnerOrganizationTelemetryRuleTelemetryRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OrganizationTelemetryRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationTelemetryRuleTypes.TelemetryRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction).T2);
}
