// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerConfigurationPolicySecurityHubPolicyFactory(Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy>
{

    internal InnerConfigurationPolicySecurityControlsConfigurationFactory SecurityControlsConfigurationFactory { get; set; }

    protected override Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy Create()
    {
        var securityHubPolicyResult = CreateSecurityHubPolicy();
        factoryAction?.Invoke(securityHubPolicyResult);

        return securityHubPolicyResult;
    }

    private Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy CreateSecurityHubPolicy()
    {
        var securityHubPolicyResult = new Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy();

        return securityHubPolicyResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityHubPolicy result)
    {
        base.CreateChildren(result);

        result.SecurityControlsConfiguration ??= SecurityControlsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationPolicySecurityHubPolicyFactoryExtensions
{
    public static CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration(this InnerConfigurationPolicySecurityHubPolicyFactory parentFactory, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null)
    {
        parentFactory.SecurityControlsConfigurationFactory = new InnerConfigurationPolicySecurityControlsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecurityControlsConfigurationFactory);
    }

    public static CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1>(this CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1>(this CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, T2, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2>(this CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, T2, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2>(this CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, T2, T3, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3>(this CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, T2, T3, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory, T3, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationPolicySecurityHubPolicyFactory, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationPolicySecurityHubPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, T2, T3, T4, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationPolicySecurityHubPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, T2, T3, T4, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationPolicySecurityHubPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory, T3, T4, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationPolicySecurityHubPolicyFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationPolicySecurityHubPolicyFactory, T4, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationPolicySecurityHubPolicyFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationPolicySecurityHubPolicyFactory, InnerConfigurationPolicySecurityControlsConfigurationFactory> WithSecurityControlsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationPolicySecurityHubPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.SecurityControlsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityControlsConfiguration(combinedResult.T5, subFactoryAction));
}
