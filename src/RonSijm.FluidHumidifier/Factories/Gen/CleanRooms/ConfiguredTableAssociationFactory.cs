// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class ConfiguredTableAssociationFactory(string resourceName = null, Action<Humidifier.CleanRooms.ConfiguredTableAssociation> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.ConfiguredTableAssociation>(resourceName)
{

    internal List<InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> ConfiguredTableAssociationAnalysisRulesFactories { get; set; } = [];

    protected override Humidifier.CleanRooms.ConfiguredTableAssociation Create()
    {
        var configuredTableAssociationResult = CreateConfiguredTableAssociation();
        factoryAction?.Invoke(configuredTableAssociationResult);

        return configuredTableAssociationResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableAssociation CreateConfiguredTableAssociation()
    {
        var configuredTableAssociationResult = new Humidifier.CleanRooms.ConfiguredTableAssociation
        {
            GivenName = InputResourceName,
        };

        return configuredTableAssociationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableAssociation result)
    {
        base.CreateChildren(result);

        result.ConfiguredTableAssociationAnalysisRules = ConfiguredTableAssociationAnalysisRulesFactories.Any() ? ConfiguredTableAssociationAnalysisRulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ConfiguredTableAssociationFactoryExtensions
{
    public static CombinedResult<ConfiguredTableAssociationFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules(this ConfiguredTableAssociationFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null)
    {
        var factory = new InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory(subFactoryAction);
        parentFactory.ConfiguredTableAssociationAnalysisRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfiguredTableAssociationFactory, T1, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1>(this CombinedResult<ConfiguredTableAssociationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableAssociationFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1>(this CombinedResult<T1, ConfiguredTableAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfiguredTableAssociationFactory, T1, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2>(this CombinedResult<ConfiguredTableAssociationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableAssociationFactory, T2, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2>(this CombinedResult<T1, ConfiguredTableAssociationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableAssociationFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2>(this CombinedResult<T1, T2, ConfiguredTableAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfiguredTableAssociationFactory, T1, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3>(this CombinedResult<ConfiguredTableAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableAssociationFactory, T2, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3>(this CombinedResult<T1, ConfiguredTableAssociationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableAssociationFactory, T3, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3>(this CombinedResult<T1, T2, ConfiguredTableAssociationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfiguredTableAssociationFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfiguredTableAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfiguredTableAssociationFactory, T1, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3, T4>(this CombinedResult<ConfiguredTableAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableAssociationFactory, T2, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, ConfiguredTableAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableAssociationFactory, T3, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfiguredTableAssociationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfiguredTableAssociationFactory, T4, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfiguredTableAssociationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfiguredTableAssociationFactory, InnerConfiguredTableAssociationConfiguredTableAssociationAnalysisRuleFactory> WithConfiguredTableAssociationAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfiguredTableAssociationFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableAssociationTypes.ConfiguredTableAssociationAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguredTableAssociationAnalysisRules(combinedResult.T5, subFactoryAction));
}
