// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerUnusedAccessConfigurationFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration>
{

    internal InnerAnalyzerAnalysisRuleFactory AnalysisRuleFactory { get; set; }

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration Create()
    {
        var unusedAccessConfigurationResult = CreateUnusedAccessConfiguration();
        factoryAction?.Invoke(unusedAccessConfigurationResult);

        return unusedAccessConfigurationResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration CreateUnusedAccessConfiguration()
    {
        var unusedAccessConfigurationResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration();

        return unusedAccessConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration result)
    {
        base.CreateChildren(result);

        result.AnalysisRule ??= AnalysisRuleFactory?.Build();
    }

} // End Of Class

public static class InnerAnalyzerUnusedAccessConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule(this InnerAnalyzerUnusedAccessConfigurationFactory parentFactory, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null)
    {
        parentFactory.AnalysisRuleFactory = new InnerAnalyzerAnalysisRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnalysisRuleFactory);
    }

    public static CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1>(this CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1>(this CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalysisRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, T2, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2>(this CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, T2, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2>(this CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2>(this CombinedResult<T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, T2, T3, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3>(this CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, T2, T3, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3>(this CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory, T3, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalyzerUnusedAccessConfigurationFactory, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalyzerUnusedAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, T2, T3, T4, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3, T4>(this CombinedResult<InnerAnalyzerUnusedAccessConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, T2, T3, T4, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalyzerUnusedAccessConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory, T3, T4, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalyzerUnusedAccessConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnalyzerUnusedAccessConfigurationFactory, T4, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalyzerUnusedAccessConfigurationFactory, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnalyzerUnusedAccessConfigurationFactory, InnerAnalyzerAnalysisRuleFactory> WithAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalyzerUnusedAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalysisRule(combinedResult.T5, subFactoryAction));
}
