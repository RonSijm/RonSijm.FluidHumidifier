// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class VersionFactory(string resourceName = null, Action<Humidifier.Lambda.Version> factoryAction = null) : ResourceFactory<Humidifier.Lambda.Version>(resourceName)
{

    internal InnerVersionProvisionedConcurrencyConfigurationFactory ProvisionedConcurrencyConfigFactory { get; set; }

    internal InnerVersionRuntimePolicyFactory RuntimePolicyFactory { get; set; }

    protected override Humidifier.Lambda.Version Create()
    {
        var versionResult = CreateVersion();
        factoryAction?.Invoke(versionResult);

        return versionResult;
    }

    private Humidifier.Lambda.Version CreateVersion()
    {
        var versionResult = new Humidifier.Lambda.Version
        {
            GivenName = InputResourceName,
        };

        return versionResult;
    }
    public override void CreateChildren(Humidifier.Lambda.Version result)
    {
        base.CreateChildren(result);

        result.ProvisionedConcurrencyConfig ??= ProvisionedConcurrencyConfigFactory?.Build();
        result.RuntimePolicy ??= RuntimePolicyFactory?.Build();
    }

} // End Of Class

public static class VersionFactoryExtensions
{
    public static CombinedResult<VersionFactory, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig(this VersionFactory parentFactory, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null)
    {
        parentFactory.ProvisionedConcurrencyConfigFactory = new InnerVersionProvisionedConcurrencyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProvisionedConcurrencyConfigFactory);
    }

    public static CombinedResult<VersionFactory, InnerVersionRuntimePolicyFactory> WithRuntimePolicy(this VersionFactory parentFactory, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null)
    {
        parentFactory.RuntimePolicyFactory = new InnerVersionRuntimePolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuntimePolicyFactory);
    }

    public static CombinedResult<VersionFactory, T1, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1>(this CombinedResult<VersionFactory, T1> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1>(this CombinedResult<T1, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, T2, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2>(this CombinedResult<VersionFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, T2, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2>(this CombinedResult<T1, VersionFactory, T2> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VersionFactory, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2>(this CombinedResult<T1, T2, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, T2, T3, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<VersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, T2, T3, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<T1, VersionFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VersionFactory, T3, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<T1, T2, VersionFactory, T3> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VersionFactory, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, T2, T3, T4, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<VersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, T2, T3, T4, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, VersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VersionFactory, T3, T4, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, VersionFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VersionFactory, T4, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VersionFactory, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VersionFactory, InnerVersionProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1>(this CombinedResult<VersionFactory, T1> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1>(this CombinedResult<T1, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, T2, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2>(this CombinedResult<VersionFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, T2, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2>(this CombinedResult<T1, VersionFactory, T2> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VersionFactory, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2>(this CombinedResult<T1, T2, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, T2, T3, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3>(this CombinedResult<VersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, T2, T3, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3>(this CombinedResult<T1, VersionFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VersionFactory, T3, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3>(this CombinedResult<T1, T2, VersionFactory, T3> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VersionFactory, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VersionFactory, T1, T2, T3, T4, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3, T4>(this CombinedResult<VersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VersionFactory, T2, T3, T4, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3, T4>(this CombinedResult<T1, VersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VersionFactory, T3, T4, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, VersionFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VersionFactory, T4, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VersionFactory, T4> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VersionFactory, InnerVersionRuntimePolicyFactory> WithRuntimePolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VersionFactory> combinedResult, Action<Humidifier.Lambda.VersionTypes.RuntimePolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuntimePolicy(combinedResult.T5, subFactoryAction));
}
