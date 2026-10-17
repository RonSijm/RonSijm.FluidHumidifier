// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerInternalAccessAnalysisRuleFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule>
{

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule Create()
    {
        var internalAccessAnalysisRuleResult = CreateInternalAccessAnalysisRule();
        factoryAction?.Invoke(internalAccessAnalysisRuleResult);

        return internalAccessAnalysisRuleResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule CreateInternalAccessAnalysisRule()
    {
        var internalAccessAnalysisRuleResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule();

        return internalAccessAnalysisRuleResult;
    }

} // End Of Class

public static class InnerAnalyzerInternalAccessAnalysisRuleFactoryExtensions
{
}
