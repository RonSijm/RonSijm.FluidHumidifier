// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMQuickSetup;

public class ConfigurationManagerFactory(string resourceName = null, Action<Humidifier.SSMQuickSetup.ConfigurationManager> factoryAction = null) : ResourceFactory<Humidifier.SSMQuickSetup.ConfigurationManager>(resourceName)
{

    internal List<InnerConfigurationManagerConfigurationDefinitionFactory> ConfigurationDefinitionsFactories { get; set; } = [];

    protected override Humidifier.SSMQuickSetup.ConfigurationManager Create()
    {
        var configurationManagerResult = CreateConfigurationManager();
        factoryAction?.Invoke(configurationManagerResult);

        return configurationManagerResult;
    }

    private Humidifier.SSMQuickSetup.ConfigurationManager CreateConfigurationManager()
    {
        var configurationManagerResult = new Humidifier.SSMQuickSetup.ConfigurationManager
        {
            GivenName = InputResourceName,
        };

        return configurationManagerResult;
    }
    public override void CreateChildren(Humidifier.SSMQuickSetup.ConfigurationManager result)
    {
        base.CreateChildren(result);

        result.ConfigurationDefinitions = ConfigurationDefinitionsFactories.Any() ? ConfigurationDefinitionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ConfigurationManagerFactoryExtensions
{
    public static CombinedResult<ConfigurationManagerFactory, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions(this ConfigurationManagerFactory parentFactory, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null)
    {
        var factory = new InnerConfigurationManagerConfigurationDefinitionFactory(subFactoryAction);
        parentFactory.ConfigurationDefinitionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfigurationManagerFactory, T1, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1>(this CombinedResult<ConfigurationManagerFactory, T1> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationManagerFactory, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1>(this CombinedResult<T1, ConfigurationManagerFactory> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfigurationManagerFactory, T1, T2, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2>(this CombinedResult<ConfigurationManagerFactory, T1, T2> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationManagerFactory, T2, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2>(this CombinedResult<T1, ConfigurationManagerFactory, T2> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationManagerFactory, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2>(this CombinedResult<T1, T2, ConfigurationManagerFactory> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfigurationManagerFactory, T1, T2, T3, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3>(this CombinedResult<ConfigurationManagerFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationManagerFactory, T2, T3, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3>(this CombinedResult<T1, ConfigurationManagerFactory, T2, T3> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationManagerFactory, T3, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, ConfigurationManagerFactory, T3> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationManagerFactory, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfigurationManagerFactory> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfigurationManagerFactory, T1, T2, T3, T4, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3, T4>(this CombinedResult<ConfigurationManagerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfigurationManagerFactory, T2, T3, T4, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, ConfigurationManagerFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfigurationManagerFactory, T3, T4, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfigurationManagerFactory, T3, T4> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfigurationManagerFactory, T4, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfigurationManagerFactory, T4> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfigurationManagerFactory, InnerConfigurationManagerConfigurationDefinitionFactory> WithConfigurationDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfigurationManagerFactory> combinedResult, Action<Humidifier.SSMQuickSetup.ConfigurationManagerTypes.ConfigurationDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationDefinitions(combinedResult.T5, subFactoryAction));
}
