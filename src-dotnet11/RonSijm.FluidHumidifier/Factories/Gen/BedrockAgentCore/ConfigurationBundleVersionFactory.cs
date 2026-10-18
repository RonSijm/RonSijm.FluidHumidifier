// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class ConfigurationBundleVersionFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersion> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.ConfigurationBundleVersion>(resourceName)
{

    internal InnerConfigurationBundleVersionVersionCreatedBySourceFactory CreatedByFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.ConfigurationBundleVersion Create()
    {
        var configurationBundleVersionResult = CreateConfigurationBundleVersion();
        factoryAction?.Invoke(configurationBundleVersionResult);

        return configurationBundleVersionResult;
    }

    private Humidifier.BedrockAgentCore.ConfigurationBundleVersion CreateConfigurationBundleVersion()
    {
        var configurationBundleVersionResult = new Humidifier.BedrockAgentCore.ConfigurationBundleVersion
        {
            GivenName = InputResourceName,
        };

        return configurationBundleVersionResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.ConfigurationBundleVersion result)
    {
        base.CreateChildren(result);

        result.CreatedBy ??= CreatedByFactory?.Build();
    }

} // End Of Class

public static class ConfigurationBundleVersionFactoryExtensions
{
    public static CombinedResult<ConfigurationBundleVersionFactory, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy(this ConfigurationBundleVersionFactory parentFactory, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null)
    {
        parentFactory.CreatedByFactory = new InnerConfigurationBundleVersionVersionCreatedBySourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreatedByFactory);
    }

    public static CombinedResult<ConfigurationBundleVersionFactory, T1, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1>(this CombinedResult<ConfigurationBundleVersionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleVersionFactory, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1>(this CombinedResult<T1, ConfigurationBundleVersionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConfigurationBundleVersionFactory, T1, T2, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2>(this CombinedResult<ConfigurationBundleVersionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleVersionFactory, T2, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, ConfigurationBundleVersionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationBundleVersionFactory, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2>(this CombinedResult<T1, T2, ConfigurationBundleVersionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConfigurationBundleVersionFactory, T1, T2, T3, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<ConfigurationBundleVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleVersionFactory, T2, T3, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, ConfigurationBundleVersionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationBundleVersionFactory, T3, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationBundleVersionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationBundleVersionFactory, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationBundleVersionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConfigurationBundleVersionFactory, T1, T2, T3, T4, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<ConfigurationBundleVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationBundleVersionFactory, T2, T3, T4, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationBundleVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationBundleVersionFactory, T3, T4, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationBundleVersionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationBundleVersionFactory, T4, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationBundleVersionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConfigurationBundleVersionFactory, InnerConfigurationBundleVersionVersionCreatedBySourceFactory> WithCreatedBy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationBundleVersionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatedBy(combinedResult.T5, subFactoryAction).T2);
}
