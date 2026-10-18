// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AccessAnalyzer;

public class ArchiveRuleFactory(string resourceName = null, Action<Humidifier.AccessAnalyzer.ArchiveRule> factoryAction = null) : ResourceFactory<Humidifier.AccessAnalyzer.ArchiveRule>(resourceName)
{

    protected override Humidifier.AccessAnalyzer.ArchiveRule Create()
    {
        var archiveRuleResult = CreateArchiveRule();
        factoryAction?.Invoke(archiveRuleResult);

        return archiveRuleResult;
    }

    private Humidifier.AccessAnalyzer.ArchiveRule CreateArchiveRule()
    {
        var archiveRuleResult = new Humidifier.AccessAnalyzer.ArchiveRule
        {
            GivenName = InputResourceName,
        };

        return archiveRuleResult;
    }

} // End Of Class

public static class ArchiveRuleFactoryExtensions
{
}
