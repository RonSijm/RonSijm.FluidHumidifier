// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class InnerAnalyzerArchiveRuleFactory(Action<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> factoryAction = null) : SubResourceFactory<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule>
{

    protected override Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule Create()
    {
        var archiveRuleResult = CreateArchiveRule();
        factoryAction?.Invoke(archiveRuleResult);

        return archiveRuleResult;
    }

    private Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule CreateArchiveRule()
    {
        var archiveRuleResult = new Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule();

        return archiveRuleResult;
    }

} // End Of Class

public static class InnerAnalyzerArchiveRuleFactoryExtensions
{
}
