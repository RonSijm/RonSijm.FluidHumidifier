// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConfigurationPolicyPolicyFactory(Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy>
{

    internal InnerConfigurationPolicySecurityHubPolicyFactory SecurityHubFactory { get; set; }

    protected override Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy Create()
    {
        var policyResult = CreatePolicy();
        factoryAction?.Invoke(policyResult);

        return policyResult;
    }

    private Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy CreatePolicy()
    {
        var policyResult = new Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy();

        return policyResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy result)
    {
        base.CreateChildren(result);

        result.SecurityHub ??= SecurityHubFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationPolicyPolicyFactoryExtensions
{
    public static CombinedResult<InnerConfigurationPolicyPolicyFactory, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub(this InnerConfigurationPolicyPolicyFactory parentFactory, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null)
    {
        parentFactory.SecurityHubFactory = new InnerConfigurationPolicySecurityHubPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecurityHubFactory);
    }

    public static CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1>(this CombinedResult<InnerConfigurationPolicyPolicyFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityHub(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1>(this CombinedResult<T1, InnerConfigurationPolicyPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityHub(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2>(this CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, T2, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2>(this CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationPolicyPolicyFactory, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationPolicyPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, T2, T3, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3>(this CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, T2, T3, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationPolicyPolicyFactory, T3, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationPolicyPolicyFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationPolicyPolicyFactory, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationPolicyPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, T2, T3, T4, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationPolicyPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, T2, T3, T4, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationPolicyPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationPolicyPolicyFactory, T3, T4, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationPolicyPolicyFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationPolicyPolicyFactory, T4, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationPolicyPolicyFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationPolicyPolicyFactory, InnerConfigurationPolicySecurityHubPolicyFactory> WithSecurityHub<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationPolicyPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityHub(combinedResult.T5, subFactoryAction));
}
