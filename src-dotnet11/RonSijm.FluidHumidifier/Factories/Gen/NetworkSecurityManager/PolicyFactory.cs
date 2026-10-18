// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class PolicyFactory(string resourceName = null, Action<Humidifier.NetworkSecurityManager.Policy> factoryAction = null) : ResourceFactory<Humidifier.NetworkSecurityManager.Policy>(resourceName)
{

    internal List<InnerPolicyAssociatedTemplateAndRuleFactory> AssociatedTemplateAndRuleListFactories { get; set; } = [];

    internal InnerPolicyPolicyConfigurationFactory PolicyConfigurationFactory { get; set; }

    protected override Humidifier.NetworkSecurityManager.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.NetworkSecurityManager.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.NetworkSecurityManager.Policy
        {
            GivenName = InputResourceName,
        };

        return policyResult;
    }
    public override void CreateChildren(Humidifier.NetworkSecurityManager.Policy result)
    {
        base.CreateChildren(result);

        result.AssociatedTemplateAndRuleList = AssociatedTemplateAndRuleListFactories.Any() ? AssociatedTemplateAndRuleListFactories.Select(x => x.Build()).ToList() : null;
        result.PolicyConfiguration ??= PolicyConfigurationFactory?.Build();
    }

} // End Of Class

public static class PolicyFactoryExtensions
{
    public static CombinedResult<PolicyFactory, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList(this PolicyFactory parentFactory, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null)
    {
        var factory = new InnerPolicyAssociatedTemplateAndRuleFactory(subFactoryAction);
        parentFactory.AssociatedTemplateAndRuleListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<PolicyFactory, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration(this PolicyFactory parentFactory, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null)
    {
        parentFactory.PolicyConfigurationFactory = new InnerPolicyPolicyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyConfigurationFactory);
    }

    public static CombinedResult<PolicyFactory, T1, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyAssociatedTemplateAndRuleFactory> WithAssociatedTemplateAndRuleList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssociatedTemplateAndRuleList(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1>(this CombinedResult<PolicyFactory, T1> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1>(this CombinedResult<T1, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, T2, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2>(this CombinedResult<PolicyFactory, T1, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, T2, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2>(this CombinedResult<T1, PolicyFactory, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyFactory, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2>(this CombinedResult<T1, T2, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, T2, T3, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3>(this CombinedResult<PolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, T2, T3, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, PolicyFactory, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyFactory, T3, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, PolicyFactory, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyFactory, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<PolicyFactory, T1, T2, T3, T4, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<PolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, PolicyFactory, T2, T3, T4, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, PolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, PolicyFactory, T3, T4, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, PolicyFactory, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, PolicyFactory, T4, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PolicyFactory, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, PolicyFactory, InnerPolicyPolicyConfigurationFactory> WithPolicyConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PolicyFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicyConfiguration(combinedResult.T5, subFactoryAction).T2);
}
