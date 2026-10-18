// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class ConfigurationBundleFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.ConfigurationBundle> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.ConfigurationBundle>(resourceName)
{

    internal InnerConfigurationBundleVersionCreatedBySourceFactory CreatedByFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.ConfigurationBundle Create()
    {
        var configurationBundleResult = CreateConfigurationBundle();
        factoryAction?.Invoke(configurationBundleResult);

        return configurationBundleResult;
    }

    private Humidifier.BedrockAgentCore.ConfigurationBundle CreateConfigurationBundle()
    {
        var configurationBundleResult = new Humidifier.BedrockAgentCore.ConfigurationBundle
        {
            GivenName = InputResourceName,
        };

        return configurationBundleResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.ConfigurationBundle result)
    {
        base.CreateChildren(result);

        result.CreatedBy ??= CreatedByFactory?.Build();
    }

} // End Of Class

public static class ConfigurationBundleFactoryExtensions
{
    public static CombinedResult<ConfigurationBundleFactory, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy(this ConfigurationBundleFactory parentFactory, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null)
    {
        parentFactory.CreatedByFactory = new InnerConfigurationBundleVersionCreatedBySourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreatedByFactory);
    }

    public static CombinedResult<ConfigurationBundleFactory, T1, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1>(this CombinedResult<ConfigurationBundleFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleFactory, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1>(this CombinedResult<T1, ConfigurationBundleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConfigurationBundleFactory, T1, T2, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2>(this CombinedResult<ConfigurationBundleFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleFactory, T2, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, ConfigurationBundleFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationBundleFactory, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, T2, ConfigurationBundleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConfigurationBundleFactory, T1, T2, T3, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<ConfigurationBundleFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleFactory, T2, T3, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, ConfigurationBundleFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationBundleFactory, T3, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationBundleFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationBundleFactory, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationBundleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConfigurationBundleFactory, T1, T2, T3, T4, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<ConfigurationBundleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleFactory, T2, T3, T4, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationBundleFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationBundleFactory, T3, T4, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationBundleFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationBundleFactory, T4, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationBundleFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConfigurationBundleFactory, InnerConfigurationBundleVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationBundleFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T5, subFactoryAction).T2);
}
