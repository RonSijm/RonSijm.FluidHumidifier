// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class AnalyzerFactory(string resourceName = null, Action<Humidifier.AccessAnalyzer.Analyzer> factoryAction = null) : ResourceFactory<Humidifier.AccessAnalyzer.Analyzer>(resourceName)
{

    internal List<InnerAnalyzerArchiveRuleFactory> ArchiveRulesFactories { get; set; } = [];

    internal InnerAnalyzerAnalyzerConfigurationFactory AnalyzerConfigurationFactory { get; set; }

    protected override Humidifier.AccessAnalyzer.Analyzer Create()
    {
        var analyzerResult = CreateAnalyzer();
        factoryAction?.Invoke(analyzerResult);

        return analyzerResult;
    }

    private Humidifier.AccessAnalyzer.Analyzer CreateAnalyzer()
    {
        var analyzerResult = new Humidifier.AccessAnalyzer.Analyzer
        {
            GivenName = InputResourceName,
        };

        return analyzerResult;
    }
    public override void CreateChildren(Humidifier.AccessAnalyzer.Analyzer result)
    {
        base.CreateChildren(result);

        result.ArchiveRules = ArchiveRulesFactories.Any() ? ArchiveRulesFactories.Select(x => x.Build()).ToList() : null;
        result.AnalyzerConfiguration ??= AnalyzerConfigurationFactory?.Build();
    }

} // End Of Class

public static class AnalyzerFactoryExtensions
{
    public static CombinedResult<AnalyzerFactory, InnerAnalyzerArchiveRuleFactory> WithArchiveRules(this AnalyzerFactory parentFactory, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null)
    {
        var factory = new InnerAnalyzerArchiveRuleFactory(subFactoryAction);
        parentFactory.ArchiveRulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AnalyzerFactory, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration(this AnalyzerFactory parentFactory, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null)
    {
        parentFactory.AnalyzerConfigurationFactory = new InnerAnalyzerAnalyzerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnalyzerConfigurationFactory);
    }

    public static CombinedResult<AnalyzerFactory, T1, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1>(this CombinedResult<AnalyzerFactory, T1> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithArchiveRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1>(this CombinedResult<T1, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithArchiveRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, T2, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2>(this CombinedResult<AnalyzerFactory, T1, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, T2, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2>(this CombinedResult<T1, AnalyzerFactory, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalyzerFactory, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2>(this CombinedResult<T1, T2, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, T2, T3, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3>(this CombinedResult<AnalyzerFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, T2, T3, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3>(this CombinedResult<T1, AnalyzerFactory, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalyzerFactory, T3, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3>(this CombinedResult<T1, T2, AnalyzerFactory, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalyzerFactory, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, T2, T3, T4, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3, T4>(this CombinedResult<AnalyzerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, T2, T3, T4, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3, T4>(this CombinedResult<T1, AnalyzerFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalyzerFactory, T3, T4, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnalyzerFactory, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalyzerFactory, T4, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnalyzerFactory, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnalyzerFactory, InnerAnalyzerArchiveRuleFactory> WithArchiveRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArchiveRules(combinedResult.T5, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1>(this CombinedResult<AnalyzerFactory, T1> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1>(this CombinedResult<T1, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, T2, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2>(this CombinedResult<AnalyzerFactory, T1, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, T2, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2>(this CombinedResult<T1, AnalyzerFactory, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalyzerFactory, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2>(this CombinedResult<T1, T2, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, T2, T3, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3>(this CombinedResult<AnalyzerFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, T2, T3, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3>(this CombinedResult<T1, AnalyzerFactory, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalyzerFactory, T3, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AnalyzerFactory, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalyzerFactory, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AnalyzerFactory, T1, T2, T3, T4, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3, T4>(this CombinedResult<AnalyzerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AnalyzerFactory, T2, T3, T4, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AnalyzerFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AnalyzerFactory, T3, T4, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AnalyzerFactory, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AnalyzerFactory, T4, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AnalyzerFactory, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AnalyzerFactory, InnerAnalyzerAnalyzerConfigurationFactory> WithAnalyzerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AnalyzerFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyzerConfiguration(combinedResult.T5, subFactoryAction));
}
