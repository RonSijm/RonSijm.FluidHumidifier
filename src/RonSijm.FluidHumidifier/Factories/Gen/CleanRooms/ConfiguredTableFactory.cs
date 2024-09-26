// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class ConfiguredTableFactory(string resourceName = null, Action<Humidifier.CleanRooms.ConfiguredTable> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.ConfiguredTable>(resourceName)
{

    internal List<InnerConfiguredTableAnalysisRuleFactory> AnalysisRulesFactories { get; set; } = [];

    internal InnerConfiguredTableTableReferenceFactory TableReferenceFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTable Create()
    {
        var configuredTableResult = CreateConfiguredTable();
        factoryAction?.Invoke(configuredTableResult);

        return configuredTableResult;
    }

    private Humidifier.CleanRooms.ConfiguredTable CreateConfiguredTable()
    {
        var configuredTableResult = new Humidifier.CleanRooms.ConfiguredTable
        {
            GivenName = InputResourceName,
        };

        return configuredTableResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTable result)
    {
        base.CreateChildren(result);

        result.AnalysisRules = AnalysisRulesFactories.Any() ? AnalysisRulesFactories.Select(x => x.Build()).ToList() : null;
        result.TableReference ??= TableReferenceFactory?.Build();
    }

} // End Of Class

public static class ConfiguredTableFactoryExtensions
{
    public static CombinedResult<ConfiguredTableFactory, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules(this ConfiguredTableFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null)
    {
        var factory = new InnerConfiguredTableAnalysisRuleFactory(subFactoryAction);
        parentFactory.AnalysisRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConfiguredTableFactory, InnerConfiguredTableTableReferenceFactory> WithTableReference(this ConfiguredTableFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null)
    {
        parentFactory.TableReferenceFactory = new InnerConfiguredTableTableReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TableReferenceFactory);
    }

    public static CombinedResult<ConfiguredTableFactory, T1, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1>(this CombinedResult<ConfiguredTableFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1>(this CombinedResult<T1, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, T2, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2>(this CombinedResult<ConfiguredTableFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, T2, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2>(this CombinedResult<T1, ConfiguredTableFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableFactory, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2>(this CombinedResult<T1, T2, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, T2, T3, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<ConfiguredTableFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, T2, T3, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<T1, ConfiguredTableFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableFactory, T3, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<T1, T2, ConfiguredTableFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfiguredTableFactory, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, T2, T3, T4, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<ConfiguredTableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, T2, T3, T4, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, ConfiguredTableFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableFactory, T3, T4, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfiguredTableFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfiguredTableFactory, T4, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfiguredTableFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfiguredTableFactory, InnerConfiguredTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1>(this CombinedResult<ConfiguredTableFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1>(this CombinedResult<T1, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, T2, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2>(this CombinedResult<ConfiguredTableFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, T2, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2>(this CombinedResult<T1, ConfiguredTableFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableFactory, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2>(this CombinedResult<T1, T2, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, T2, T3, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3>(this CombinedResult<ConfiguredTableFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, T2, T3, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3>(this CombinedResult<T1, ConfiguredTableFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableFactory, T3, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3>(this CombinedResult<T1, T2, ConfiguredTableFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfiguredTableFactory, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConfiguredTableFactory, T1, T2, T3, T4, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3, T4>(this CombinedResult<ConfiguredTableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConfiguredTableFactory, T2, T3, T4, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3, T4>(this CombinedResult<T1, ConfiguredTableFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConfiguredTableFactory, T3, T4, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConfiguredTableFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConfiguredTableFactory, T4, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConfiguredTableFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConfiguredTableFactory, InnerConfiguredTableTableReferenceFactory> WithTableReference<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConfiguredTableFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableReference(combinedResult.T5, subFactoryAction));
}
