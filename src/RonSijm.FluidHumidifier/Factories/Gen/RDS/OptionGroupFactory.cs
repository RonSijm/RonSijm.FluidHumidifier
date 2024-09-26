// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class OptionGroupFactory(string resourceName = null, Action<Humidifier.RDS.OptionGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.OptionGroup>(resourceName)
{

    internal List<InnerOptionGroupOptionConfigurationFactory> OptionConfigurationsFactories { get; set; } = [];

    protected override Humidifier.RDS.OptionGroup Create()
    {
        var optionGroupResult = CreateOptionGroup();
        factoryAction?.Invoke(optionGroupResult);

        return optionGroupResult;
    }

    private Humidifier.RDS.OptionGroup CreateOptionGroup()
    {
        var optionGroupResult = new Humidifier.RDS.OptionGroup
        {
            GivenName = InputResourceName,
        };

        return optionGroupResult;
    }
    public override void CreateChildren(Humidifier.RDS.OptionGroup result)
    {
        base.CreateChildren(result);

        result.OptionConfigurations = OptionConfigurationsFactories.Any() ? OptionConfigurationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class OptionGroupFactoryExtensions
{
    public static CombinedResult<OptionGroupFactory, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations(this OptionGroupFactory parentFactory, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null)
    {
        var factory = new InnerOptionGroupOptionConfigurationFactory(subFactoryAction);
        parentFactory.OptionConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<OptionGroupFactory, T1, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1>(this CombinedResult<OptionGroupFactory, T1> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OptionGroupFactory, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1>(this CombinedResult<T1, OptionGroupFactory> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<OptionGroupFactory, T1, T2, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2>(this CombinedResult<OptionGroupFactory, T1, T2> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OptionGroupFactory, T2, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2>(this CombinedResult<T1, OptionGroupFactory, T2> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OptionGroupFactory, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2>(this CombinedResult<T1, T2, OptionGroupFactory> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<OptionGroupFactory, T1, T2, T3, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3>(this CombinedResult<OptionGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OptionGroupFactory, T2, T3, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3>(this CombinedResult<T1, OptionGroupFactory, T2, T3> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OptionGroupFactory, T3, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, OptionGroupFactory, T3> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OptionGroupFactory, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, OptionGroupFactory> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<OptionGroupFactory, T1, T2, T3, T4, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3, T4>(this CombinedResult<OptionGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, OptionGroupFactory, T2, T3, T4, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, OptionGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, OptionGroupFactory, T3, T4, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, OptionGroupFactory, T3, T4> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, OptionGroupFactory, T4, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, OptionGroupFactory, T4> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, OptionGroupFactory, InnerOptionGroupOptionConfigurationFactory> WithOptionConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, OptionGroupFactory> combinedResult, Action<Humidifier.RDS.OptionGroupTypes.OptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOptionConfigurations(combinedResult.T5, subFactoryAction));
}
