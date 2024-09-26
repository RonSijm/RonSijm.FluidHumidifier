// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class ConfigurationTemplateFactory(string resourceName = null, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplate> factoryAction = null) : ResourceFactory<Humidifier.ElasticBeanstalk.ConfigurationTemplate>(resourceName)
{

    internal List<InnerConfigurationTemplateConfigurationOptionSettingFactory> OptionSettingsFactories { get; set; } = [];

    internal InnerConfigurationTemplateSourceConfigurationFactory SourceConfigurationFactory { get; set; }

    protected override Humidifier.ElasticBeanstalk.ConfigurationTemplate Create()
    {
        var configurationTemplateResult = CreateConfigurationTemplate();
        factoryAction?.Invoke(configurationTemplateResult);

        return configurationTemplateResult;
    }

    private Humidifier.ElasticBeanstalk.ConfigurationTemplate CreateConfigurationTemplate()
    {
        var configurationTemplateResult = new Humidifier.ElasticBeanstalk.ConfigurationTemplate
        {
            GivenName = InputResourceName,
        };

        return configurationTemplateResult;
    }
    public override void CreateChildren(Humidifier.ElasticBeanstalk.ConfigurationTemplate result)
    {
        base.CreateChildren(result);

        result.OptionSettings = OptionSettingsFactories.Any() ? OptionSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.SourceConfiguration ??= SourceConfigurationFactory?.Build();
    }

} // End Of Class

public static class ConfigurationTemplateFactoryExtensions
{
    public static CombinedResult<ConfigurationTemplateFactory, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings(this ConfigurationTemplateFactory parentFactory, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null)
    {
        var factory = new InnerConfigurationTemplateConfigurationOptionSettingFactory(subFactoryAction);
        parentFactory.OptionSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigurationTemplateFactory, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration(this ConfigurationTemplateFactory parentFactory, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null)
    {
        parentFactory.SourceConfigurationFactory = new InnerConfigurationTemplateSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceConfigurationFactory);
    }

    public static CombinedResult<ConfigurationTemplateFactory, T1, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1>(this CombinedResult<ConfigurationTemplateFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1>(this CombinedResult<T1, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, T2, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2>(this CombinedResult<ConfigurationTemplateFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, T2, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2>(this CombinedResult<T1, ConfigurationTemplateFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationTemplateFactory, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2>(this CombinedResult<T1, T2, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, T2, T3, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<ConfigurationTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, T2, T3, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<T1, ConfigurationTemplateFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationTemplateFactory, T3, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationTemplateFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationTemplateFactory, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, T2, T3, T4, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<ConfigurationTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, T2, T3, T4, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationTemplateFactory, T3, T4, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationTemplateFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationTemplateFactory, T4, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationTemplateFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationTemplateFactory, InnerConfigurationTemplateConfigurationOptionSettingFactory> WithOptionSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.ConfigurationOptionSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1>(this CombinedResult<ConfigurationTemplateFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1>(this CombinedResult<T1, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, T2, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2>(this CombinedResult<ConfigurationTemplateFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, T2, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2>(this CombinedResult<T1, ConfigurationTemplateFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationTemplateFactory, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2>(this CombinedResult<T1, T2, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, T2, T3, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3>(this CombinedResult<ConfigurationTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, T2, T3, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, ConfigurationTemplateFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationTemplateFactory, T3, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationTemplateFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationTemplateFactory, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationTemplateFactory, T1, T2, T3, T4, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<ConfigurationTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationTemplateFactory, T2, T3, T4, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationTemplateFactory, T3, T4, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationTemplateFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationTemplateFactory, T4, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationTemplateFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationTemplateFactory, InnerConfigurationTemplateSourceConfigurationFactory> WithSourceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationTemplateFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ConfigurationTemplateTypes.SourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceConfiguration(combinedResult.T5, subFactoryAction));
}
