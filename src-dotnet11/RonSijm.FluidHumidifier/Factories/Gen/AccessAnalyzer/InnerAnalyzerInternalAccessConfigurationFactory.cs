// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerInternalAccessConfigurationFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration>
{

    internal InnerAnalyzerInternalAccessAnalysisRuleFactory InternalAccessAnalysisRuleFactory { get; set; }

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration Create()
    {
        var internalAccessConfigurationResult = CreateInternalAccessConfiguration();
        factoryAction?.Invoke(internalAccessConfigurationResult);

        return internalAccessConfigurationResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration CreateInternalAccessConfiguration()
    {
        var internalAccessConfigurationResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration();

        return internalAccessConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration result)
    {
        base.CreateChildren(result);

        result.InternalAccessAnalysisRule ??= InternalAccessAnalysisRuleFactory?.Build();
    }

} // End Of Class

public static class InnerAnalyzerInternalAccessConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule(this InnerAnalyzerInternalAccessConfigurationFactory parentFactory, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null)
    {
        parentFactory.InternalAccessAnalysisRuleFactory = new InnerAnalyzerInternalAccessAnalysisRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InternalAccessAnalysisRuleFactory);
    }

    public static CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1>(this CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1>(this CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, T2, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2>(this CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, T2, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2>(this CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, T2> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalyzerInternalAccessConfigurationFactory, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2>(this CombinedResult<T1, T2, InnerAnalyzerInternalAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, T2, T3, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3>(this CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, T2, T3, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3>(this CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalyzerInternalAccessConfigurationFactory, T3, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnalyzerInternalAccessConfigurationFactory, T3> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalyzerInternalAccessConfigurationFactory, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnalyzerInternalAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, T2, T3, T4, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3, T4>(this CombinedResult<InnerAnalyzerInternalAccessConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, T2, T3, T4, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnalyzerInternalAccessConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAnalyzerInternalAccessConfigurationFactory, T3, T4, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnalyzerInternalAccessConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAnalyzerInternalAccessConfigurationFactory, T4, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnalyzerInternalAccessConfigurationFactory, T4> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAnalyzerInternalAccessConfigurationFactory, InnerAnalyzerInternalAccessAnalysisRuleFactory> WithInternalAccessAnalysisRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnalyzerInternalAccessConfigurationFactory> combinedResult, Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInternalAccessAnalysisRule(combinedResult.T5, subFactoryAction).T2);
}
