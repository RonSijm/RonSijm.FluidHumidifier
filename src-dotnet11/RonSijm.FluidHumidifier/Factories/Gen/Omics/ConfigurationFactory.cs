// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class ConfigurationFactory(string resourceName = null, Action<Humidifier.Omics.Configuration> factoryAction = null) : ResourceFactory<Humidifier.Omics.Configuration>(resourceName)
{

    internal InnerConfigurationRunConfigurationsFactory RunConfigurationsFactory { get; set; }

    protected override Humidifier.Omics.Configuration Create()
    {
        var configurationResult = CreateConfiguration();
        factoryAction?.Invoke(configurationResult);

        return configurationResult;
    }

    private Humidifier.Omics.Configuration CreateConfiguration()
    {
        var configurationResult = new Humidifier.Omics.Configuration
        {
            GivenName = InputResourceName,
        };

        return configurationResult;
    }
    public override void CreateChildren(Humidifier.Omics.Configuration result)
    {
        base.CreateChildren(result);

        result.RunConfigurations ??= RunConfigurationsFactory?.Build();
    }

} // End Of Class

public static class ConfigurationFactoryExtensions
{
    public static CombinedResult<ConfigurationFactory, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations(this ConfigurationFactory parentFactory, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null)
    {
        parentFactory.RunConfigurationsFactory = new InnerConfigurationRunConfigurationsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RunConfigurationsFactory);
    }

    public static CombinedResult<ConfigurationFactory, T1, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1>(this CombinedResult<ConfigurationFactory, T1> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationFactory, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1>(this CombinedResult<T1, ConfigurationFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, WithRunConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConfigurationFactory, T1, T2, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2>(this CombinedResult<ConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationFactory, T2, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2>(this CombinedResult<T1, ConfigurationFactory, T2> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationFactory, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2>(this CombinedResult<T1, T2, ConfigurationFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConfigurationFactory, T1, T2, T3, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3>(this CombinedResult<ConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationFactory, T2, T3, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3>(this CombinedResult<T1, ConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationFactory, T3, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationFactory, T3> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationFactory, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConfigurationFactory, T1, T2, T3, T4, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3, T4>(this CombinedResult<ConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConfigurationFactory, T2, T3, T4, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConfigurationFactory, T3, T4, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConfigurationFactory, T4, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationFactory, T4> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConfigurationFactory, InnerConfigurationRunConfigurationsFactory> WithRunConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationFactory> combinedResult, Action<Humidifier.Omics.ConfigurationTypes.RunConfigurations> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRunConfigurations(combinedResult.T5, subFactoryAction).T2);
}
