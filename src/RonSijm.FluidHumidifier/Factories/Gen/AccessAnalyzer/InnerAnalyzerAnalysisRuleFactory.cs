// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerAnalysisRuleFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule>
{

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule Create()
    {
        var analysisRuleResult = CreateAnalysisRule();
        factoryAction?.Invoke(analysisRuleResult);

        return analysisRuleResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule CreateAnalysisRule()
    {
        var analysisRuleResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule();

        return analysisRuleResult;
    }

} // End Of Class

public static class InnerAnalyzerAnalysisRuleFactoryExtensions
{
}
