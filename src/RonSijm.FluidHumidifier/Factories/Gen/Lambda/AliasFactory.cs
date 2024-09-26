// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class AliasFactory(string resourceName = null, Action<Humidifier.Lambda.Alias> factoryAction = null) : ResourceFactory<Humidifier.Lambda.Alias>(resourceName)
{

    internal InnerAliasProvisionedConcurrencyConfigurationFactory ProvisionedConcurrencyConfigFactory { get; set; }

    internal InnerAliasAliasRoutingConfigurationFactory RoutingConfigFactory { get; set; }

    protected override Humidifier.Lambda.Alias Create()
    {
        var aliasResult = CreateAlias();
        factoryAction?.Invoke(aliasResult);

        return aliasResult;
    }

    private Humidifier.Lambda.Alias CreateAlias()
    {
        var aliasResult = new Humidifier.Lambda.Alias
        {
            GivenName = InputResourceName,
        };

        return aliasResult;
    }
    public override void CreateChildren(Humidifier.Lambda.Alias result)
    {
        base.CreateChildren(result);

        result.ProvisionedConcurrencyConfig ??= ProvisionedConcurrencyConfigFactory?.Build();
        result.RoutingConfig ??= RoutingConfigFactory?.Build();
    }

} // End Of Class

public static class AliasFactoryExtensions
{
    public static CombinedResult<AliasFactory, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig(this AliasFactory parentFactory, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null)
    {
        parentFactory.ProvisionedConcurrencyConfigFactory = new InnerAliasProvisionedConcurrencyConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProvisionedConcurrencyConfigFactory);
    }

    public static CombinedResult<AliasFactory, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig(this AliasFactory parentFactory, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null)
    {
        parentFactory.RoutingConfigFactory = new InnerAliasAliasRoutingConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RoutingConfigFactory);
    }

    public static CombinedResult<AliasFactory, T1, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1>(this CombinedResult<AliasFactory, T1> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1>(this CombinedResult<T1, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2>(this CombinedResult<AliasFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2>(this CombinedResult<T1, AliasFactory, T2> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2>(this CombinedResult<T1, T2, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, T3, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<AliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, T3, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<T1, AliasFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, T3, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<T1, T2, AliasFactory, T3> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AliasFactory, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, T3, T4, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<AliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, T3, T4, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, AliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, T3, T4, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, AliasFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AliasFactory, T4, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AliasFactory, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AliasFactory, InnerAliasProvisionedConcurrencyConfigurationFactory> WithProvisionedConcurrencyConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.ProvisionedConcurrencyConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProvisionedConcurrencyConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1>(this CombinedResult<AliasFactory, T1> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1>(this CombinedResult<T1, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2>(this CombinedResult<AliasFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2>(this CombinedResult<T1, AliasFactory, T2> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2>(this CombinedResult<T1, T2, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, T3, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<AliasFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, T3, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<T1, AliasFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, T3, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, AliasFactory, T3> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AliasFactory, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AliasFactory, T1, T2, T3, T4, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<AliasFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AliasFactory, T2, T3, T4, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, AliasFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AliasFactory, T3, T4, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, AliasFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AliasFactory, T4, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AliasFactory, T4> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AliasFactory, InnerAliasAliasRoutingConfigurationFactory> WithRoutingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AliasFactory> combinedResult, Action<Humidifier.Lambda.AliasTypes.AliasRoutingConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoutingConfig(combinedResult.T5, subFactoryAction));
}
