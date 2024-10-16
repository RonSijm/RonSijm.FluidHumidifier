// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class ConfigurationPolicyFactory(string resourceName = null, Action<Humidifier.SecurityHub.ConfigurationPolicy> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.ConfigurationPolicy>(resourceName)
{

    internal InnerConfigurationPolicyPolicyFactory ConfigurationPolicy_Factory { get; set; }

    protected override Humidifier.SecurityHub.ConfigurationPolicy Create()
    {
        var configurationPolicyResult = CreateConfigurationPolicy();
        factoryAction?.Invoke(configurationPolicyResult);

        return configurationPolicyResult;
    }

    private Humidifier.SecurityHub.ConfigurationPolicy CreateConfigurationPolicy()
    {
        var configurationPolicyResult = new Humidifier.SecurityHub.ConfigurationPolicy
        {
            GivenName = InputResourceName,
        };

        return configurationPolicyResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.ConfigurationPolicy result)
    {
        base.CreateChildren(result);

        result.ConfigurationPolicy_ ??= ConfigurationPolicy_Factory?.Build();
    }

} // End Of Class

public static class ConfigurationPolicyFactoryExtensions
{
    public static CombinedResult<ConfigurationPolicyFactory, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_(this ConfigurationPolicyFactory parentFactory, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null)
    {
        parentFactory.ConfigurationPolicy_Factory = new InnerConfigurationPolicyPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationPolicy_Factory);
    }

    public static CombinedResult<ConfigurationPolicyFactory, T1, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1>(this CombinedResult<ConfigurationPolicyFactory, T1> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationPolicyFactory, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1>(this CombinedResult<T1, ConfigurationPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationPolicyFactory, T1, T2, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2>(this CombinedResult<ConfigurationPolicyFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationPolicyFactory, T2, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2>(this CombinedResult<T1, ConfigurationPolicyFactory, T2> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationPolicyFactory, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2>(this CombinedResult<T1, T2, ConfigurationPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationPolicyFactory, T1, T2, T3, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3>(this CombinedResult<ConfigurationPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationPolicyFactory, T2, T3, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3>(this CombinedResult<T1, ConfigurationPolicyFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationPolicyFactory, T3, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationPolicyFactory, T3> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationPolicyFactory, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationPolicyFactory, T1, T2, T3, T4, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3, T4>(this CombinedResult<ConfigurationPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationPolicyFactory, T2, T3, T4, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationPolicyFactory, T3, T4, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationPolicyFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationPolicyFactory, T4, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationPolicyFactory, T4> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationPolicyFactory, InnerConfigurationPolicyPolicyFactory> WithConfigurationPolicy_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationPolicyFactory> combinedResult, Action<Humidifier.SecurityHub.ConfigurationPolicyTypes.Policy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationPolicy_(combinedResult.T5, subFactoryAction));
}
