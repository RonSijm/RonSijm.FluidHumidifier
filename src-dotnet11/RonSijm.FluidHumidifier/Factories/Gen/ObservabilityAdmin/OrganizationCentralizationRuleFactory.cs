// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class OrganizationCentralizationRuleFactory(string resourceName = null, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRule> factoryAction = null) : ResourceFactory<Humidifier.ObservabilityAdmin.OrganizationCentralizationRule>(resourceName)
{

    internal InnerOrganizationCentralizationRuleCentralizationRuleFactory RuleFactory { get; set; }

    protected override Humidifier.ObservabilityAdmin.OrganizationCentralizationRule Create()
    {
        var organizationCentralizationRuleResult = CreateOrganizationCentralizationRule();
        factoryAction?.Invoke(organizationCentralizationRuleResult);

        return organizationCentralizationRuleResult;
    }

    private Humidifier.ObservabilityAdmin.OrganizationCentralizationRule CreateOrganizationCentralizationRule()
    {
        var organizationCentralizationRuleResult = new Humidifier.ObservabilityAdmin.OrganizationCentralizationRule
        {
            GivenName = InputResourceName,
        };

        return organizationCentralizationRuleResult;
    }
    public override void CreateChildren(Humidifier.ObservabilityAdmin.OrganizationCentralizationRule result)
    {
        base.CreateChildren(result);

        result.Rule ??= RuleFactory?.Build();
    }

} // End Of Class

public static class OrganizationCentralizationRuleFactoryExtensions
{
    public static CombinedResult<OrganizationCentralizationRuleFactory, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule(this OrganizationCentralizationRuleFactory parentFactory, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null)
    {
        parentFactory.RuleFactory = new InnerOrganizationCentralizationRuleCentralizationRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleFactory);
    }

    public static CombinedResult<OrganizationCentralizationRuleFactory, T1, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1>(this CombinedResult<OrganizationCentralizationRuleFactory, T1> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationCentralizationRuleFactory, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1>(this CombinedResult<T1, OrganizationCentralizationRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<OrganizationCentralizationRuleFactory, T1, T2, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2>(this CombinedResult<OrganizationCentralizationRuleFactory, T1, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationCentralizationRuleFactory, T2, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, OrganizationCentralizationRuleFactory, T2> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OrganizationCentralizationRuleFactory, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2>(this CombinedResult<T1, T2, OrganizationCentralizationRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<OrganizationCentralizationRuleFactory, T1, T2, T3, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<OrganizationCentralizationRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationCentralizationRuleFactory, T2, T3, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, OrganizationCentralizationRuleFactory, T2, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OrganizationCentralizationRuleFactory, T3, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, OrganizationCentralizationRuleFactory, T3> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OrganizationCentralizationRuleFactory, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, OrganizationCentralizationRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<OrganizationCentralizationRuleFactory, T1, T2, T3, T4, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<OrganizationCentralizationRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, OrganizationCentralizationRuleFactory, T2, T3, T4, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, OrganizationCentralizationRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, OrganizationCentralizationRuleFactory, T3, T4, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, OrganizationCentralizationRuleFactory, T3, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, OrganizationCentralizationRuleFactory, T4, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OrganizationCentralizationRuleFactory, T4> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, OrganizationCentralizationRuleFactory, InnerOrganizationCentralizationRuleCentralizationRuleFactory> WithRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OrganizationCentralizationRuleFactory> combinedResult, Action<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRule(combinedResult.T5, subFactoryAction).T2);
}
