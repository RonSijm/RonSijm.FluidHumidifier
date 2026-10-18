// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class IntermediateTableFactory(string resourceName = null, Action<Humidifier.CleanRooms.IntermediateTable> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.IntermediateTable>(resourceName)
{

    internal List<InnerIntermediateTableIntermediateTableAnalysisRuleFactory> AnalysisRulesFactories { get; set; } = [];

    internal InnerIntermediateTablePopulationAnalysisConfigurationFactory PopulationAnalysisConfigurationFactory { get; set; }

    protected override Humidifier.CleanRooms.IntermediateTable Create()
    {
        var intermediateTableResult = CreateIntermediateTable();
        factoryAction?.Invoke(intermediateTableResult);

        return intermediateTableResult;
    }

    private Humidifier.CleanRooms.IntermediateTable CreateIntermediateTable()
    {
        var intermediateTableResult = new Humidifier.CleanRooms.IntermediateTable
        {
            GivenName = InputResourceName,
        };

        return intermediateTableResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.IntermediateTable result)
    {
        base.CreateChildren(result);

        result.AnalysisRules = AnalysisRulesFactories.Any() ? AnalysisRulesFactories.Select(x => x.Build()).ToList() : null;
        result.PopulationAnalysisConfiguration ??= PopulationAnalysisConfigurationFactory?.Build();
    }

} // End Of Class

public static class IntermediateTableFactoryExtensions
{
    public static CombinedResult<IntermediateTableFactory, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules(this IntermediateTableFactory parentFactory, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null)
    {
        var factory = new InnerIntermediateTableIntermediateTableAnalysisRuleFactory(subFactoryAction);
        parentFactory.AnalysisRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IntermediateTableFactory, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration(this IntermediateTableFactory parentFactory, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null)
    {
        parentFactory.PopulationAnalysisConfigurationFactory = new InnerIntermediateTablePopulationAnalysisConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PopulationAnalysisConfigurationFactory);
    }

    public static CombinedResult<IntermediateTableFactory, T1, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1>(this CombinedResult<IntermediateTableFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1>(this CombinedResult<T1, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2>(this CombinedResult<IntermediateTableFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, T2, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2>(this CombinedResult<T1, IntermediateTableFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntermediateTableFactory, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2>(this CombinedResult<T1, T2, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<IntermediateTableFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, T2, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<T1, IntermediateTableFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntermediateTableFactory, T3, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<T1, T2, IntermediateTableFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntermediateTableFactory, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<IntermediateTableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, T2, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, IntermediateTableFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntermediateTableFactory, T3, T4, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntermediateTableFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntermediateTableFactory, T4, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntermediateTableFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IntermediateTableFactory, InnerIntermediateTableIntermediateTableAnalysisRuleFactory> WithAnalysisRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.IntermediateTableAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRules(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1>(this CombinedResult<IntermediateTableFactory, T1> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1>(this CombinedResult<T1, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2>(this CombinedResult<IntermediateTableFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, T2, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2>(this CombinedResult<T1, IntermediateTableFactory, T2> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntermediateTableFactory, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2>(this CombinedResult<T1, T2, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, T2, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3>(this CombinedResult<IntermediateTableFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, T2, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3>(this CombinedResult<T1, IntermediateTableFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntermediateTableFactory, T3, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IntermediateTableFactory, T3> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntermediateTableFactory, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IntermediateTableFactory, T1, T2, T3, T4, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3, T4>(this CombinedResult<IntermediateTableFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntermediateTableFactory, T2, T3, T4, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IntermediateTableFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntermediateTableFactory, T3, T4, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntermediateTableFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntermediateTableFactory, T4, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntermediateTableFactory, T4> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IntermediateTableFactory, InnerIntermediateTablePopulationAnalysisConfigurationFactory> WithPopulationAnalysisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntermediateTableFactory> combinedResult, Action<Humidifier.CleanRooms.IntermediateTableTypes.PopulationAnalysisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPopulationAnalysisConfiguration(combinedResult.T5, subFactoryAction).T2);
}
