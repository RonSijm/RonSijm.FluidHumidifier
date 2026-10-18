// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkSecurityManager;

public class InnerPolicyPolicyConfigurationFactory(Action<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration>
{

    internal InnerPolicyWafConfigFactory WafConfigFactory { get; set; }

    protected override Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration Create()
    {
        var policyConfigurationResult = CreatePolicyConfiguration();
        factoryAction?.Invoke(policyConfigurationResult);

        return policyConfigurationResult;
    }

    private Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration CreatePolicyConfiguration()
    {
        var policyConfigurationResult = new Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration();

        return policyConfigurationResult;
    }
    public override void CreateChildren(Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration result)
    {
        base.CreateChildren(result);

        result.WafConfig ??= WafConfigFactory?.Build();
    }

} // End Of Class

public static class InnerPolicyPolicyConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPolicyPolicyConfigurationFactory, InnerPolicyWafConfigFactory> WithWafConfig(this InnerPolicyPolicyConfigurationFactory parentFactory, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null)
    {
        parentFactory.WafConfigFactory = new InnerPolicyWafConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WafConfigFactory);
    }

    public static CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, InnerPolicyWafConfigFactory> WithWafConfig<T1>(this CombinedResult<InnerPolicyPolicyConfigurationFactory, T1> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithWafConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, InnerPolicyWafConfigFactory> WithWafConfig<T1>(this CombinedResult<T1, InnerPolicyPolicyConfigurationFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithWafConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, T2, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2>(this CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, T2, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2>(this CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, T2> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyConfigurationFactory, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2>(this CombinedResult<T1, T2, InnerPolicyPolicyConfigurationFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, T2, T3, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3>(this CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, T2, T3, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3>(this CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyConfigurationFactory, T3, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerPolicyPolicyConfigurationFactory, T3> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyConfigurationFactory, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyConfigurationFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, T2, T3, T4, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3, T4>(this CombinedResult<InnerPolicyPolicyConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, T2, T3, T4, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerPolicyPolicyConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerPolicyPolicyConfigurationFactory, T3, T4, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPolicyPolicyConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerPolicyPolicyConfigurationFactory, T4, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPolicyPolicyConfigurationFactory, T4> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyConfigurationFactory, InnerPolicyWafConfigFactory> WithWafConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPolicyPolicyConfigurationFactory> combinedResult, Action<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWafConfig(combinedResult.T5, subFactoryAction).T2);
}
